// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIWebVTTListener.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// Listener for a JS WebVTT parser (vtt.js).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8a2d7780-2045-4a29-99f4-df15cae5fc49")]
	public interface nsIWebVTTListener
	{
		
		/// <summary>
        /// Is called when the WebVTTParser successfully parses a WebVTT cue.
        ///
        /// @param cue An object representing the data of a parsed WebVTT cue.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnCue(ref Gecko.JsVal cue, System.IntPtr jsContext);
		
		/// <summary>
        /// Is called when the WebVTT parser successfully parses a WebVTT region.
        ///
        /// @param region An object representing the data of a parsed
        /// WebVTT region.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnRegion(ref Gecko.JsVal region, System.IntPtr jsContext);
		
		/// <summary>
        /// Is called when the WebVTT parser encounters a parsing error.
        ///
        /// @param error The error code of the ParserError the occured.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnParsingError(int errorCode, System.IntPtr jsContext);
	}
}
