using System;
using System.Runtime.InteropServices;
using Gecko.DOM;
using Gecko.DOM.Svg;
using Gecko.Interop;
using Gecko.WebIDL;
using DocumentFragment = Gecko.DOM.DocumentFragment;
using Location = Gecko.DOM.Location;

namespace Gecko
{
    /// <summary>
    /// Base document class (documents can be HTML,SVG,XUL)
    /// </summary>
    public class GeckoDomDocument
        : GeckoNode
    {
        internal nsIDOMDocument _domDocument;

        // TODO: FIXME: remove internal add readonly props.
        protected internal Lazy<WebIDL.Document> _document;
        protected internal Lazy<WebIDL.DocumentOrShadowRoot> _documentOrShadowRoot;

        internal GeckoDomDocument(nsISupports window, nsIDOMDocument document)
            : base(window, document)
        {
            _domDocument = document;
            _document = new Lazy<Document>(() => new WebIDL.Document((mozIDOMWindowProxy)window, (nsISupports)document));
            _documentOrShadowRoot = new Lazy<DocumentOrShadowRoot>(() => new WebIDL.DocumentOrShadowRoot((mozIDOMWindowProxy)window, (nsISupports)document));
        }

        /// <summary>
        /// for tests
        /// </summary>
        public nsIDOMDocument NativeDomDocument
        {
            get { return _domDocument; }
        }


        public DOM.DomDocumentType Doctype
        {
            get { /*return _domDocument.GetDoctypeAttribute().Wrap(DomDocumentType.Create);*/throw new NotImplementedException(); }
        }

        //[return: MarshalAs(UnmanagedType.Interface)]
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //nsIDOMDOMImplementation GetImplementationAttribute();

        /// <summary>
        /// Gets the top-level document element (for HTML documents, this is the html tag).
        /// </summary>
        public GeckoElement DocumentElement
        {
            get
            {
                return _document.Value.DocumentElement.Wrap(Window, GeckoElement.CreateDomElementWrapper);
            }
        }

        public GeckoHtmlElement CreateHtmlElement(string tagName)
        {
            if (string.IsNullOrEmpty(tagName))
                throw new ArgumentException("tagName");

            return GeckoHtmlElement.Create(Window, _document.Value.CreateElement(tagName));
        }

        public GeckoElement CreateElement(string tagName)
        {
            if (string.IsNullOrEmpty(tagName))
                throw new ArgumentException("tagName");

            return GeckoElement.CreateDomElementWrapper(Window, _document.Value.CreateElement(tagName));
        }

        public DocumentFragment CreateDocumentFragment()
        {
            throw new NotImplementedException();
#if PORTFF60
            return _domDocument.CreateDocumentFragment()
                .Wrap(DocumentFragment.CreateDocumentFragmentWrapper);
#endif
        }

        public GeckoTextNode CreateTextNode(string data)
        {
            throw new NotImplementedException();
#if PORTFF60
            return nsString.Pass<nsIDOMText>(_domDocument.CreateTextNode, data)
                .Wrap(DOM.GeckoTextNode.CreateTextNodeWrapper);
#endif
        }

        public GeckoComment CreateComment(string data)
        {
            throw new NotImplementedException();
#if PORTFF60
            return nsString.Pass<nsIDOMComment>(_domDocument.CreateComment, data)
                .Wrap(GeckoComment.CreateCommentWrapper);
#endif
        }

        //[return: MarshalAs(UnmanagedType.Interface)]
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //nsIDOMCDATASection CreateCDATASection([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase data);

        //[return: MarshalAs(UnmanagedType.Interface)]
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //nsIDOMProcessingInstruction CreateProcessingInstruction([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase target, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase data);

        public GeckoAttribute CreateAttribute(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("name");
            throw new NotImplementedException();
#if PORTFF60
            return nsString.Pass</* nsIDOMAttr */nsISupports>(_domDocument.CreateAttribute, name)
                .Wrap(GeckoAttribute.CreateAttributeWrapper);
#endif
        }

        /// <summary>
        /// Returns a collection containing all elements in the document with a given tag name.
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public GeckoElementCollection GetElementsByTagName(string tagName)
        {
            if (string.IsNullOrEmpty(tagName))
                return null;

            return _document.Value.GetElementsByTagName(tagName).Wrap(Window, (window, x) => new GeckoElementCollection(Window, (nsIDOMNodeList)x));
        }

        public GeckoNode ImportNode(GeckoNode node, bool deep)
        {
            if (node == null)
                throw new ArgumentNullException("node");

            throw new NotImplementedException();
#if PORTFF60
            return _domDocument.ImportNode(node.DomObject, deep, 1)
                .Wrap(Create);
#endif
        }


        public GeckoHtmlElement CreateElement(string namespaceUri, string qualifiedName)
        {
            if (string.IsNullOrEmpty(namespaceUri))
                throw new ArgumentException("namespaceUri");
            if (string.IsNullOrEmpty(qualifiedName))
                throw new ArgumentException("qualifiedName");

            throw new NotImplementedException();
#if PORTFF60
            var native = nsString.Pass<nsIDOMElement>(_domDocument.CreateElementNS, namespaceUri, qualifiedName);

            return GeckoHtmlElement.Create((/* nsIDOMHTMLElement **/nsISupports) native);
#endif
        }

        public GeckoAttribute CreateAttribute(string namespaceUri, string qualifiedName)
        {
            if (string.IsNullOrEmpty(namespaceUri))
                throw new ArgumentException("namespaceUri");
            if (string.IsNullOrEmpty(qualifiedName))
                throw new ArgumentException("qualifiedName");

            throw new NotImplementedException();
#if PORTFF60
            return nsString.Pass</* nsIDOMAttr */nsISupports>(_domDocument.CreateAttributeNS, namespaceUri, qualifiedName)
                .Wrap(GeckoAttribute.CreateAttributeWrapper);
#endif
        }

        public DomEventArgs CreateEvent(string name)
        {
            var e = _document.Value.CreateEvent(name);

            return e.Wrap(Window, (x,y) => DomEventArgs.Create(y));
        }


        /// <summary>
        /// Returns a collection containing all elements in the document with a given namespaceUri & localName.
        /// </summary>
        /// <returns></returns>
        public GeckoElementCollection GetElementsByTagNameNS(string namespaceUri, string localName)
        {
            if (string.IsNullOrEmpty(namespaceUri))
                throw new ArgumentException("namespaceUri");
            if (string.IsNullOrEmpty(localName))
                throw new ArgumentException("localName");

            throw new NotImplementedException();
#if PORTFF60
            var native = nsString.Pass<nsIDOMNodeList>(_domDocument.GetElementsByTagNameNS, namespaceUri, localName);

            return new GeckoElementCollection(native);
#endif
        }


        /// <summary>
        /// Searches for and returns the element in the document with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Found element or null if element does not exist</returns>
        public GeckoElement GetElementById(string id)
        {
            if (string.IsNullOrEmpty(id))
                return null;

            return (GeckoElement)new WebIDL.Document((mozIDOMWindowProxy)Window, (nsISupports)_domDocument).GetElementById(id).Wrap(Window, Create);
        }

        /// <summary>
        /// Searches for and returns the Html element in the document with the given id.
        /// Will throw an invalid cast exception is element is not a HtmlElement.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GeckoHtmlElement GetHtmlElementById(string id)
        {
            if (string.IsNullOrEmpty(id))
                return null;

            return (GeckoHtmlElement)new WebIDL.Document((mozIDOMWindowProxy)Window, (nsISupports)_domDocument).GetElementById(id).Wrap(Window, Create);
        }

        public string InputEncoding => _document.Value.InputEncoding;

        public string Uri => _document.Value.URL;

        ///// <summary>
        ///// Introduced in DOM Level 3:
        ///// </summary>
        //[return: MarshalAs(UnmanagedType.Interface)]
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //nsIDOMNode AdoptNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode source);

        /// <summary>
        /// <see cref="http://html5.org/specs/dom-range.html#dom-document-createrange"/>
        /// </summary>
        /// <returns></returns>
        public GeckoRange CreateRange()
        {
            return new GeckoRange(Window, (nsIDOMRange)_document.Value.CreateRange()); 
        }

        //[return: MarshalAs(UnmanagedType.Interface)]
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //nsIDOMNodeIterator CreateNodeIterator([MarshalAs(UnmanagedType.Interface)] nsIDOMNode root, uint whatToShow, [MarshalAs(UnmanagedType.Interface)] nsIDOMNodeFilter filter, [MarshalAs(UnmanagedType.U1)] bool entityReferenceExpansion);

        //[return: MarshalAs(UnmanagedType.Interface)]
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //nsIDOMTreeWalker CreateTreeWalker([MarshalAs(UnmanagedType.Interface)] nsIDOMNode root, uint whatToShow, [MarshalAs(UnmanagedType.Interface)] nsIDOMNodeFilter filter, [MarshalAs(UnmanagedType.U1)] bool entityReferenceExpansion);

        //[return: MarshalAs(UnmanagedType.Interface)]
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //nsIDOMEvent CreateEvent([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase eventType);

        /// <summary>
        /// The window associated with this document.
        /// <see cref="http://www.whatwg.org/html/#dom-document-defaultview"/>
        /// </summary>
        public GeckoWindow DefaultView => _document.Value.DefaultView.Wrap(Window, (window, x) => new GeckoWindow(x));

        /// <summary>
        /// <see cref="http://www.whatwg.org/html/#dom-document-characterset"/>
        /// </summary>
        public string CharacterSet
        {
            get { /*return nsString.Get(_domDocument.GetCharacterSetAttribute);*/ throw new NotImplementedException(); }
        }

        /// <summary>
        /// <see cref="http://www.whatwg.org/html/#dom-document-dir"/>
        /// </summary>
        public string Dir
        {
            get { return _document.Value.Dir; }
            set { _document.Value.Dir = value; }
        }


        /// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-location>
        /// </summary>
        public Location Location
        {
            get { /*return _domDocument.GetLocationAttribute().Wrap(Location.Create);*/ throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the document title.
        /// </summary>
        public string Title
        {
            get { /*return nsString.Get(_domDocument.GetTitleAttribute);*/ throw new NotImplementedException(); }
            set { /*nsString.Set(_domDocument.SetTitleAttribute, value);*/ throw new NotImplementedException(); }
        }


        /// <summary>
        /// <see cref="http://www.whatwg.org/html/#dom-document-readystate"/>
        /// </summary>
        public string ReadyState
        {
            get { /*return nsString.Get(_domDocument.GetReadyStateAttribute);*/ throw new NotImplementedException(); }
        }

        ///// <summary>
        ///// @see <http://www.whatwg.org/html/#dom-document-lastmodified>
        ///// </summary>
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //void GetLastModifiedAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLastModified);

        public string Referrer
        {
            get {/* return nsString.Get(_domDocument.GetReferrerAttribute); */ throw new NotImplementedException(); }
        }

        /// <summary>
        /// <see cref="http://www.whatwg.org/html/#dom-document-hasfocus"/>
        /// </summary>
        public bool HasFocus()
        {
            //return _domDocument.HasFocus();
            throw new NotImplementedException();
        }

        ///// <summary>
        ///// @see <http://www.whatwg.org/html/#dom-document-activeelement>
        ///// </summary>
        //[return: MarshalAs(UnmanagedType.Interface)]
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //nsIDOMElement GetActiveElementAttribute();

        /// <summary>
        /// Gets the currently focused element.
        /// </summary>
        public GeckoHtmlElement ActiveElement => (GeckoHtmlElement) _documentOrShadowRoot.Value.ActiveElement.Wrap(Window, Create);

        /// <summary>
        /// Returns a set of elements with the given class name. When called on the document object, the complete document is searched, including the root node.
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public GeckoNodeCollection GetElementsByClassName(string classes)
        {
            var list = (nsIDOMNodeList)_document.Value.GetElementsByClassName(classes);
            return GeckoNodeCollection.Create(Window, (nsISupports)list);
        }

        ///// <summary>
        ///// @see <http://dev.w3.org/csswg/cssom/#dom-document-stylesheets>
        ///// </summary>
        //[return: MarshalAs(UnmanagedType.Interface)]
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //nsIDOMStyleSheetList GetStyleSheetsAttribute();

        /// <summary>
        /// <see cref="http://dev.w3.org/csswg/cssom/#dom-document-preferredStyleSheetSet"/>
        /// </summary>
        public string PreferredStyleSheetSet
        {
            get { /*return nsString.Get(_domDocument.GetPreferredStyleSheetSetAttribute);*/ throw new NotImplementedException(); }
        }

        /// <summary>
        /// <see cref="http://dev.w3.org/csswg/cssom/#dom-document-selectedStyleSheetSet"/>
        /// </summary>
        public string SelectedStyleSheetSet
        {
            get { /*return nsString.Get(_domDocument.GetSelectedStyleSheetSetAttribute);*/ throw new NotImplementedException(); }
            set { /*nsString.Set(_domDocument.SetSelectedStyleSheetSetAttribute, value);*/ throw new NotImplementedException(); }
        }

        /// <summary>
        /// <see cref="http://dev.w3.org/csswg/cssom/#dom-document-lastStyleSheetSet"/>
        /// </summary>
        public string LastStyleSheetSet
        {
            get { /*return nsString.Get(_domDocument.GetLastStyleSheetSetAttribute);*/ throw new NotImplementedException(); }
        }


        ///// <summary>
        ///// This must return the live list of the currently available style sheet
        ///// sets. This list is constructed by enumerating all the style sheets for
        ///// this document available to the implementation, in the order they are
        ///// listed in the styleSheets attribute, adding the title of each style sheet
        ///// with a title to the list, avoiding duplicates by dropping titles that
        ///// match (case-sensitively) titles that have already been added to the
        ///// list.
        /////
        ///// @see <http://dev.w3.org/csswg/cssom/#dom-document-styleSheetSets>
        ///// </summary>
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //System.IntPtr GetStyleSheetSetsAttribute();

        /// <summary>
        /// <see cref="http://dev.w3.org/csswg/cssom/#dom-document-enableStyleSheetsForSet"/>
        /// </summary>
        /// <param name="name"></param>
        public void EnableStyleSheetsForSet(string name)
        {
            //nsString.Set(_domDocument.EnableStyleSheetsForSet, name);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the element visible at the given point, relative to the upper-left-most visible point in the document.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public GeckoElement ElementFromPoint(int x, int y)
        {
            //return _domDocument.ElementFromPoint(x, y).Wrap(GeckoElement.CreateDomElementWrapper);
            throw new NotImplementedException();
        }

        public string ContentType
        {
            get { /*return nsString.Get(_domDocument.GetContentTypeAttribute);*/  throw new NotImplementedException(); }
        }

        /// <summary>
        /// True if this document is synthetic : stand alone image, video, audio file,
        /// etc.
        /// </summary>
        public bool MozSyntheticDocument
        {
            get {/* return _domDocument.GetMozSyntheticDocumentAttribute();*/  throw new NotImplementedException(); }
        }

        ///// <summary>
        ///// Returns the script element whose script is currently being processed.
        /////
        ///// @see <https://developer.mozilla.org/en/DOM/document.currentScript>
        ///// </summary>
        //[return: MarshalAs(UnmanagedType.Interface)]
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //nsIDOMElement GetCurrentScriptAttribute();

        public GeckoNode CurrentScript
        {
            get { /*return _domDocument.GetCurrentScriptAttribute().Wrap(Create);*/  throw new NotImplementedException(); }
        }

        /// <summary>
        /// <see cref="https://developer.mozilla.org/en/DOM/document.releaseCapture"/>
        /// </summary>
        public void ReleaseCapture()
        {
            //_domDocument.ReleaseCapture();
            throw new NotImplementedException();
        }

        ///// <summary>
        ///// Use the given DOM element as the source image of target |-moz-element()|.
        /////
        ///// This function introduces a new special ID (called "image element ID"),
        ///// which is only used by |-moz-element()|, and associates it with the given
        ///// DOM element.  Image elements ID's have the higher precedence than general
        ///// HTML id's, so if |document.mozSetImageElement(<id>, <element>)| is called,
        ///// |-moz-element(#<id>)| uses |<element>| as the source image even if there
        ///// is another element with id attribute = |<id>|.  To unregister an image
        ///// element ID |<id>|, call |document.mozSetImageElement(<id>, null)|.
        /////
        ///// Example:
        ///// <script>
        ///// canvas = document.createElement("canvas");
        ///// canvas.setAttribute("width", 100);
        ///// canvas.setAttribute("height", 100);
        ///// // draw to canvas
        ///// document.mozSetImageElement("canvasbg", canvas);
        ///// </script>
        ///// <div style="background-image: -moz-element(#canvasbg);"></div>
        /////
        ///// @param aImageElementId an image element ID to associate with
        ///// |aImageElement|
        ///// @param aImageElement a DOM element to be used as the source image of
        ///// |-moz-element(#aImageElementId)|. If this is null, the function will
        ///// unregister the image element ID |aImageElementId|.
        /////
        ///// @see <https://developer.mozilla.org/en/DOM/document.mozSetImageElement>
        ///// </summary>
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //void MozSetImageElement([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aImageElementId, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aImageElement);

        ///// <summary>
        ///// Element which is currently the full-screen element as per the DOM
        ///// full-screen api.
        /////
        ///// @see <https://wiki.mozilla.org/index.php?title=Gecko:FullScreenAPI>
        ///// </summary>
        //[return: MarshalAs(UnmanagedType.Interface)]
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        ///* /* nsIDOMHTMLElement*/nsISupports GetMozFullScreenElementAttribute();

        /// <summary>
        /// Causes the document to leave DOM full-screen mode, if it's in
        /// full-screen mode, as per the DOM full-screen api.
        /// <see cref="https://wiki.mozilla.org/index.php?title=Gecko:FullScreenAPI"/>
        /// </summary>
        public void MozCancelFullScreen()
        {
            //_domDocument.MozCancelFullScreen();
            throw new NotImplementedException();
        }

        /// <summary>
        /// Denotes whether this document is in DOM full-screen mode, as per the DOM
        /// full-screen api.
        /// <see cref="https://wiki.mozilla.org/index.php?title=Gecko:FullScreenAPI"/>
        /// </summary>
        public bool MozFullScreen
        {
            get { /*return _domDocument.GetMozFullScreenAttribute();*/  throw new NotImplementedException(); }
        }


        /// <summary>
        /// Denotes whether the full-screen-api.enabled is true, no windowed
        /// plugins are present, and all ancestor documents have the
        /// mozallowfullscreen attribute set.
        /// <see cref="https://wiki.mozilla.org/index.php?title=Gecko:FullScreenAPI"/>
        /// </summary>
        public bool MozFullScreenEnabled
        {
            get { /*return _domDocument.GetMozFullScreenEnabledAttribute(); */  throw new NotImplementedException(); }
        }

        ///// <summary>
        ///// Inline event handler for readystatechange events.
        ///// </summary>
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //System.IntPtr GetOnreadystatechangeAttribute(System.IntPtr jsContext);

        ///// <summary>
        ///// Inline event handler for readystatechange events.
        ///// </summary>
        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //void SetOnreadystatechangeAttribute(System.IntPtr aOnreadystatechange, System.IntPtr jsContext);

        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //System.IntPtr GetOnmouseenterAttribute(System.IntPtr jsContext);

        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //void SetOnmouseenterAttribute(System.IntPtr aOnmouseenter, System.IntPtr jsContext);

        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //System.IntPtr GetOnmouseleaveAttribute(System.IntPtr jsContext);

        //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //void SetOnmouseleaveAttribute(System.IntPtr aOnmouseleave, System.IntPtr jsContext);

        /// <summary>
        /// Visibility API implementation.
        /// </summary>
        public bool MozHidden
        {
            get { /*return _domDocument.GetMozHiddenAttribute(); */  throw new NotImplementedException(); }
        }

        public string MozVisibilityState
        {
            get { /*return nsString.Get(_domDocument.GetMozVisibilityStateAttribute);*/  throw new NotImplementedException(); }
        }


        public static GeckoDomDocument CreateDomDocumentWraper(nsISupports window, nsIDOMDocument domDocument)
        {
            // REVIEW: PORTFF60 - should we cache this?
            return new GeckoDocument(window, domDocument);
        }
    }
}
