using System;
using System.Collections.Generic;
using Gecko.DOM;

namespace Gecko
{
    /// <summary>
    /// Represents a DOM HTML document.
    /// </summary>
    public class GeckoDocument : GeckoDomDocument
    {
        private /* nsIDOMHTMLDocument */nsIDOMDocument _domHtmlDocument;

        internal GeckoDocument(/* nsIDOMHTMLDocument */nsIDOMDocument document) : base(document)
        {
            this._domHtmlDocument = document;
        }

        internal static GeckoDocument Create(/* nsIDOMHTMLDocument */nsIDOMDocument document)
        {
            return (document == null) ? null : new GeckoDocument(document);
        }

        public override GeckoDocument OwnerDocument
        {
            get { return this; }
        }

        /// <summary>
        /// Gets the HTML head element.
        /// </summary>
        public GeckoHeadElement Head
        {
            get
            {
#if PORTFF60
                return (_domHtmlDocument == null)
                    ? null
                    : GeckoHtmlElement.Create<GeckoHeadElement>((/* nsIDOMHTMLElement */nsISupports) _domHtmlDocument.GetHeadAttribute());
#endif
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the HTML body element.
        /// </summary>
        public GeckoHtmlElement Body
        {
            get
            {
#if PORTFF60
                return (_domHtmlDocument == null)
                    ? null
                    : GeckoHtmlElement.Create<GeckoHtmlElement>(_domHtmlDocument.GetBodyAttribute());
#endif
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Represents a collection of style sheets in a <see cref="GeckoDocument"/>.
        /// </summary>
        public class StyleSheetCollection : IEnumerable<GeckoStyleSheet>
        {
            internal StyleSheetCollection(GeckoDocument document)
            {
                //this.List = document._domHtmlDocument.GetStyleSheetsAttribute();
                throw new NotImplementedException();
            }

            private /* nsIDOMStyleSheetList */nsISupports List;

            /// <summary>
            /// Gets the number of items in the collection.
            /// </summary>
            public int Count
            {
                get {/* return (List == null) ? 0 : (int) List.GetLengthAttribute();*/throw new NotImplementedException(); }
            }

            /// <summary>
            /// Gets the item at the specified index in the collection.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public GeckoStyleSheet this[int index]
            {
                get
                {
                    if (index < 0 || index >= Count)
                        throw new ArgumentOutOfRangeException("index");

                    //return GeckoStyleSheet.Create((nsIDOMCSSStyleSheet) List.Item((uint) index));
                    throw new NotImplementedException();
                }
            }

#region IEnumerable<GeckoStyleSheet> Members

            /// <summary>
            /// Returns an <see cref="IEnumerator{GeckoStyleSheet}"/> which can enumerate through the collection.
            /// </summary>
            /// <returns></returns>
            public IEnumerator<GeckoStyleSheet> GetEnumerator()
            {
                int length = Count;
                //for (int i = 0; i < length; i++)
                //{
                //    yield return GeckoStyleSheet.Create((nsIDOMCSSStyleSheet) List.Item((uint) i));
                //}
                throw new NotImplementedException();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                foreach (GeckoStyleSheet element in this)
                    yield return element;
            }

#endregion
        }

        /// <summary>
        /// Gets the collection of style sheets in the <see cref="GeckoDocument"/>.
        /// </summary>
        public StyleSheetCollection StyleSheets
        {
            get { return (_StyleSheets == null) ? (_StyleSheets = new StyleSheetCollection(this)) : _StyleSheets; }
        }

        private StyleSheetCollection _StyleSheets;

        /// <summary>
        /// Gets the URL of the document.
        /// </summary>
        public Uri Url
        {
            get { /*return (_domHtmlDocument == null) ? null : new Uri(nsString.Get(_domHtmlDocument.GetURLAttribute));*/throw new NotImplementedException(); }
        }

        public GeckoElementCollection Forms
        {
            get
            {
                //return (_domHtmlDocument == null)
                //    ? null
                //    : new GeckoHtmlElementCollection(_domHtmlDocument.GetFormsAttribute());
                throw new NotImplementedException();
            }
        }

        public GeckoElementCollection Images
        {
            get
            {
                //return (_domHtmlDocument == null)
                //    ? null
                //    : new GeckoHtmlElementCollection(_domHtmlDocument.GetImagesAttribute());
                throw new NotImplementedException();
            }
        }

        public GeckoElementCollection Anchors
        {
            get
            {
                //return (_domHtmlDocument == null)
                //    ? null
                //    : new GeckoHtmlElementCollection(_domHtmlDocument.GetAnchorsAttribute());
                throw new NotImplementedException();
            }
        }

        public GeckoElementCollection Applets
        {
            get
            {
                //return (_domHtmlDocument == null)
                //    ? null
                //    : new GeckoHtmlElementCollection(_domHtmlDocument.GetAppletsAttribute());
                throw new NotImplementedException();
            }
        }

        public GeckoElementCollection Links
        {
            get
            {
                //return (_domHtmlDocument == null)
                //    ? null
                //    : new GeckoHtmlElementCollection(_domHtmlDocument.GetLinksAttribute());
                throw new NotImplementedException();
            }
        }

        public string Cookie
        {
            get {/* return (_domHtmlDocument == null) ? null : nsString.Get(_domHtmlDocument.GetCookieAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_domHtmlDocument.SetCookieAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Domain
        {
            get { /*return (_domHtmlDocument == null) ? null : nsString.Get(_domHtmlDocument.GetDomainAttribute);*/throw new NotImplementedException(); }
        }


        /// <summary>
        /// Returns a collection containing all elements in the document with a given name.		
        /// </summary>
        /// <param name="name">This is NOT the tagname but the name attribute.</param>
        /// <returns></returns>
        public GeckoElementCollection GetElementsByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;

            //return new GeckoElementCollection(_domHtmlDocument.GetElementsByName(new nsAString(name)));
            throw new NotImplementedException();
        }
    }
}