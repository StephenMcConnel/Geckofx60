using System.Runtime.InteropServices;
using System;

namespace Gecko
{
    /// <summary>
    /// This is just a piece of a JsVal implementation, just enough to get the message out.
    /// netmonkey and spidermonkeydotnet have fuller implementations
    /// </summary>
    /// <remarks>
    /// 		/// WARNING:
    /// https://developer.mozilla.org/En/SpiderMonkey/JSAPI_Reference/Jsval
    /// Says: "jsval is a variant type whose exact representation varies by architecture.  
    ///			Embeddings should not rely on observed representation details, the size of jsval, 
    ///			or whether jsval is a primitive type."
    ///	In the code below, we are just using API calls to access it, except for the attempt to get at the value tag directly (which didn't work).
    ///		
    /// </remarks>
    [StructLayout(LayoutKind.Explicit)]
    public struct JsVal
    {
        public static JsVal FromPtr(ulong value)
        {
            return new JsVal() {AsBits = value};
        }

        /// <summary>
        /// Construct a JSVal from a JSObject pointer
        /// This is platform specific (I did this after trying very hard to find gecko45 apis that would allow me do this and failng.)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static JsVal FromPtr(IntPtr value)
        {
            // ENHANCE: change AsBits to signed value to allow removing of unchecked.
            unchecked
            {
                if (Xpcom.Is32Bit)
                    return new JsVal() { AsPtr = value, tag = (uint)ValueTag32Bit.Object };
                else
                    return new JsVal() { AsBits = (ulong)(value.ToInt64() | ((long)ValueTag64Bit.Object << 47)) };
            }
        }

        public static JsVal FromDouble(double d)
        {
            return new JsVal() {AsDouble = d};
        }

        [FieldOffset(0)] public ulong AsBits;
        [FieldOffset(0)] public double AsDouble;
        [FieldOffset(0)] public IntPtr AsPtr;
        [FieldOffset(0)] public int I32;
        [FieldOffset(0)] public uint U32;
        [FieldOffset(0)] public int Boo;
        [FieldOffset(0)] public ulong Ptr;
        // This field is not valid for 64bit JsVal. (64bit little endian tag is stored in 17 most significant bits of the 8 byte JsVal)
        [FieldOffset(4)] public uint tag;
        
        public enum ValueTag64Bit : uint
        {
            Clear = 0x1FFF0,
            Int32 = Clear | 1,
            Boolean = Clear | 2,
            Undefined = Clear | 3,
            Null = Clear | 4,
            Magic = Clear | 5,
            String = Clear | 6,
            Symbol = Clear | 7,
            Object = Clear | 0x0c
        }

        public enum ValueTag32Bit : uint
        {
            Clear = 0xFFFFFF80,
            Int32 = Clear | 1,
            Boolean = Clear | 2,
            Undefined = Clear | 3,
            Null = Clear | 4,
            Magic = Clear | 5,
            String = Clear | 6,
            Symbol = Clear | 7,
            Object = Clear | 0x0c
        }

        public uint Tag
        {
            get { return Xpcom.Is32Bit ? tag : (uint)(AsBits >> 47); }
        }

        public bool IsNull
        {
            get { return Tag == (Xpcom.Is32Bit ? (uint) ValueTag32Bit.Null : (uint) ValueTag64Bit.Null); }
        }

        public bool IsUndefined
        {
            get { return Tag == (Xpcom.Is32Bit ? (uint) ValueTag32Bit.Undefined : (uint) ValueTag64Bit.Undefined); }
        }

        public bool IsBoolean
        {
            get { return Tag == (Xpcom.Is32Bit ? (uint) ValueTag32Bit.Boolean : (uint) ValueTag64Bit.Boolean); }
        }

        public bool IsNumber
        {
            get { return Tag <= (Xpcom.Is32Bit ? (uint) ValueTag32Bit.Int32 : (uint) ValueTag64Bit.Int32); }
        }

        public bool IsInt
        {
            get { return Tag <= (Xpcom.Is32Bit ? (uint) ValueTag32Bit.Int32 : (uint) ValueTag64Bit.Int32); }
        }

        public bool IsDouble
        {
            get { return Tag <= (Xpcom.Is32Bit ? (uint) ValueTag32Bit.Clear : (uint) ValueTag64Bit.Clear); }
        }

        public bool IsString
        {
            get { return Tag == (Xpcom.Is32Bit ? (uint) ValueTag32Bit.String : (uint) ValueTag64Bit.String); }
        }

        public bool IsObject
        {
            get { return Tag <= (Xpcom.Is32Bit ? (uint) ValueTag32Bit.Object : (uint) ValueTag64Bit.Object); }
        }

        public bool ToBoolean()
        {
            return Boo != 0;
        }

        public double ToDouble()
        {
            return AsDouble;
        }

        public int ToInteger()
        {
            return I32;
        }

        public override string ToString()
        {
            var context = AutoJSContext.Current;
            if (context == null)
                throw new Exception("AutoJSContext not set.");

            return AutoJSContext.Current?.ConvertValueToString(this) ?? string.Empty;
        }

        public object ToObject<T>()
        {
            if (typeof(T).IsValueType)
            {
                if (IsBoolean)
                {
                    return ToBoolean();
                }

                if (IsDouble)
                {
                    return ToDouble();
                }

                if (IsInt)
                {
                    return ToInteger();
                }                
            }

            if (IsNull)
            {
                return null;
            }

            if (IsUndefined)
            {
                return "Undefined";
            }

            if (IsString)
            {
                return ToString();
            }

            if (IsObject)
            {
                return ToComObjectInternal();
            }

            return null;
        }

        public object ToObject()
        {
            if (IsNull)
            {
                return null;
            }
            if (IsUndefined)
            {
                return "Undefined";
            }

            if (IsBoolean)
            {
                return ToBoolean();
            }

            if (IsInt)
            {
                return ToInteger();
            }

            if (IsDouble)
            {
                return ToDouble();
            }

            if (IsString)
            {
                return ToString();
            }

            if (IsObject)
            {
                return ToComObjectInternal();
            }

            return null;
        }

        /// <summary>
        /// Converts to COM object without null check
        /// </summary>
        /// <returns></returns>
        private object ToComObjectInternal()
        {
            var context = AutoJSContext.Current;
            if (context == null)
                throw new Exception("AutoJSContext not set.");
            {
                var jsObject = SpiderMonkey.JS_ValueToObject(context.ContextPointer, this);

                var guid = typeof (nsISupports).GUID;
                var pUnk = IntPtr.Zero;
                try
                {
                    pUnk = Xpcom.XPConnect.Instance.WrapJS(context.ContextPointer, jsObject, ref guid);
                    var comObj = Xpcom.GetObjectForIUnknown(pUnk);

                    return comObj;
                }
                finally
                {
                    if (pUnk != IntPtr.Zero)
                    {
                        Marshal.Release(pUnk);
                    }
                }
            }
        }

        /// <summary>
        /// Convert to COM object with Null checking
        /// </summary>
        /// <param name="cx"></param>
        /// <returns>COM object or Null</returns>
        internal object ToComObject(IntPtr cx)
        {
            if (IsNull) return null;

            return ToComObjectInternal();
        }

        public JSType Type
        {
            get
            {
                var context = AutoJSContext.Current;
                if (context == null)
                    throw new Exception("AutoJSContext not set.");
               
                return SpiderMonkey.JS_TypeOfValue(context.ContextPointer, ref this);               
            }
        }
    }
}
