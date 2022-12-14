using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.Collections
{
    /// <summary>
    /// Generic wrapper for Enumerator to classes nsIDOMNodeList//* nsIDOMHTMLCollection */nsISupports
    /// It looks like /* nsIDOMHTMLCollection */nsISupports MUST BE subclass of nsIDOMNodeList - but :-(
    /// </summary>
    /// <typeparam name="TWrapper"></typeparam>
    /// <typeparam name="TGeckoObject"></typeparam>
    internal sealed class GeckoNodeEnumerator<TWrapper, TGeckoNode>
        : IEnumerator<TWrapper>
        where TGeckoNode : class, nsIDOMNode
        where TWrapper : class
    {
        private readonly mozIDOMWindowProxy _window;
        private Wrapper _wrapper;
        private uint _position;
        private TGeckoNode _current;
        private Func<mozIDOMWindowProxy, TGeckoNode, TWrapper> _translator;

        internal GeckoNodeEnumerator(mozIDOMWindowProxy window, nsIDOMNodeList list, Func<mozIDOMWindowProxy, TGeckoNode, TWrapper> translator)
            : this(window, new Wrapper1(window, list), translator)
        {
            _window = window;
        }


        public GeckoNodeEnumerator(mozIDOMWindowProxy window,/* nsIDOMHTMLCollection */nsISupports collection, Func<mozIDOMWindowProxy, TGeckoNode, TWrapper> translator)
            : this(window, new Wrapper2(collection), translator)
        {
        }

        private GeckoNodeEnumerator(mozIDOMWindowProxy window, Wrapper wrapper, Func<mozIDOMWindowProxy, TGeckoNode, TWrapper> translator)
        {
            _wrapper = wrapper;
            _translator = translator;
            // searching first TGeckoNode (for example we need only GeckoElement's)
            _position = 0;
        }


        public void Dispose()
        {
            var disposable = _wrapper as IDisposable;
            if (disposable != null)
                disposable.Dispose();
            _wrapper = null;
            _translator = null;
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            while (_position < _wrapper.Length)
            {
                var test = _wrapper.Item(_position);
                _position++;
                if (test is TGeckoNode)
                {
                    _current = (TGeckoNode) test;
                    return true;
                }
            }
            return false;
        }

        public void Reset()
        {
            _position = 0;
            _current = null;
        }

        public TWrapper Current
        {
            get { return _translator(_window, _current); }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }


        private abstract class Wrapper
        {
            public abstract nsIDOMNode Item(uint index);
            public abstract int Length { get; }
        }

        private sealed class Wrapper1
            : Wrapper
        {
            private nsIDOMNodeList _list;
            private int _length;

            internal Wrapper1(mozIDOMWindowProxy window, nsIDOMNodeList list)
            {
                _list = list;
                _length = (int) list.GetLengthAttribute();
            }

            public override nsIDOMNode Item(uint index)
            {
                return _list.Item(index);
            }

            public override int Length
            {
                get { return _length; }
            }
        }

        private sealed class Wrapper2
            : Wrapper
        {
            private /* nsIDOMHTMLCollection */nsISupports _collection;
            private int _length;

            public Wrapper2(/* nsIDOMHTMLCollection */nsISupports collection)
            {
                _collection = collection;
                //_length = (int) collection.GetLengthAttribute();
                throw new NotImplementedException();
            }

            public override nsIDOMNode Item(uint index)
            {
                //return _collection.Item(index);
                throw new NotImplementedException();
            }

            public override int Length
            {
                get { return _length; }
            }
        }
    }
}