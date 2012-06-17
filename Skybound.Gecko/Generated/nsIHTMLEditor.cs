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
// Generated by IDLImporter from file nsIHTMLEditor.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>nsIHTMLEditor </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("FF67AD39-ED58-4CD1-A1A3-DCD988390A97")]
	public interface nsIHTMLEditor
	{
		
		/// <summary>
        /// AddDefaultProperty() registers a default style property with the editor
        ///
        /// @param aProperty   the property to set by default
        /// @param aAttribute  the attribute of the property, if applicable.
        /// May be null.
        /// Example: aProperty="font", aAttribute="color"
        /// @param aValue      if aAttribute is not null, the value of the attribute.
        /// Example: aProperty="font", aAttribute="color",
        /// aValue="0x00FFFF"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddDefaultProperty([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		/// <summary>
        /// RemoveDefaultProperty() unregisters a default style property with the editor
        ///
        /// @param aProperty   the property to remove from defaults
        /// @param aAttribute  the attribute of the property, if applicable.
        /// May be null.
        /// Example: aProperty="font", aAttribute="color"
        /// @param aValue      if aAttribute is not null, the value of the attribute.
        /// Example: aProperty="font", aAttribute="color",
        /// aValue="0x00FFFF"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveDefaultProperty([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		/// <summary>
        /// RemoveAllDefaultProperties() unregisters all default style properties with the editor
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAllDefaultProperties();
		
		/// <summary>
        /// SetInlineProperty() sets the aggregate properties on the current selection
        ///
        /// @param aProperty   the property to set on the selection
        /// @param aAttribute  the attribute of the property, if applicable.
        /// May be null.
        /// Example: aProperty="font", aAttribute="color"
        /// @param aValue      if aAttribute is not null, the value of the attribute.
        /// May be null.
        /// Example: aProperty="font", aAttribute="color",
        /// aValue="0x00FFFF"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCSSInlineProperty([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		/// <summary>Member SetInlineProperty </summary>
		/// <param name='aProperty'> </param>
		/// <param name='aAttribute'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInlineProperty([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		/// <summary>
        /// getInlineProperty() gets aggregate properties of the current selection.
        /// All object in the current selection are scanned and their attributes are
        /// represented in a list of Property object.
        ///
        /// @param aProperty   the property to get on the selection
        /// @param aAttribute  the attribute of the property, if applicable.
        /// May be null.
        /// Example: aProperty="font", aAttribute="color"
        /// @param aValue      if aAttribute is not null, the value of the attribute.
        /// May be null.
        /// Example: aProperty="font", aAttribute="color",
        /// aValue="0x00FFFF"
        /// @param aFirst      [OUT] PR_TRUE if the first text node in the
        /// selection has the property
        /// @param aAny        [OUT] PR_TRUE if any of the text nodes in the
        /// selection have the property
        /// @param aAll        [OUT] PR_TRUE if all of the text nodes in the
        /// selection have the property
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInlineProperty([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue, [MarshalAs(UnmanagedType.U1)] ref bool aFirst, [MarshalAs(UnmanagedType.U1)] ref bool aAny, [MarshalAs(UnmanagedType.U1)] ref bool aAll);
		
		/// <summary>Member GetInlinePropertyWithAttrValue </summary>
		/// <param name='aProperty'> </param>
		/// <param name='aAttribute'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFirst'> </param>
		/// <param name='aAny'> </param>
		/// <param name='aAll'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInlinePropertyWithAttrValue([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue, [MarshalAs(UnmanagedType.U1)] ref bool aFirst, [MarshalAs(UnmanagedType.U1)] ref bool aAny, [MarshalAs(UnmanagedType.U1)] ref bool aAll, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// removeAllInlineProperties() deletes all the inline properties from all
        /// text in the current selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAllInlineProperties();
		
		/// <summary>
        /// removeInlineProperty() deletes the properties from all text in the current
        /// selection.  If aProperty is not set on the selection, nothing is done.
        ///
        /// @param aProperty   the property to remove from the selection
        /// All atoms are for normal HTML tags (e.g.:
        /// nsIEditorProperty::font) except when you want to
        /// remove just links and not named anchors.
        /// For that, use nsIEditorProperty::href
        /// @param aAttribute  the attribute of the property, if applicable.
        /// May be null.
        /// Example: aProperty=nsIEditorProptery::font,
        /// aAttribute="color"
        /// nsIEditProperty::allAttributes is special.
        /// It indicates that all content-based text properties
        /// are to be removed from the selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveInlineProperty([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAttribute);
		
		/// <summary>
        /// Increase font size for text in selection by 1 HTML unit
        /// All existing text is scanned for existing <FONT SIZE> attributes
        /// so they will be incremented instead of inserting new <FONT> tag
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void IncreaseFontSize();
		
		/// <summary>
        /// Decrease font size for text in selection by 1 HTML unit
        /// All existing text is scanned for existing <FONT SIZE> attributes
        /// so they will be decreased instead of inserting new <FONT> tag
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DecreaseFontSize();
		
		/// <summary>
        /// Tests if a node is a BLOCK element according the the HTML 4.0 DTD.
        /// This does NOT consider CSS effect on display type
        ///
        /// @param aNode      the node to test
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NodeIsBlock([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node);
		
		/// <summary>
        /// Insert some HTML source at the current location
        ///
        /// @param aInputString   the string to be inserted
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertHTML([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aInputString);
		
		/// <summary>
        /// Paste the text in the OS clipboard at the cursor position, replacing
        /// the selected text (if any), but strip out any HTML styles and formatting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PasteNoFormatting(int aSelectionType);
		
		/// <summary>
        /// Rebuild the entire document from source HTML
        /// Needed to be able to edit HEAD and other outside-of-BODY content
        ///
        /// @param aSourceString   HTML source string of the entire new document
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RebuildDocumentFromSource([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSourceString);
		
		/// <summary>
        /// Insert some HTML source, interpreting
        /// the string argument according to the given context.
        ///
        /// @param aInputString   the string to be inserted
        /// @param aContextStr    Context of insertion
        /// @param aInfoStr       Related info to aInputString
        /// @param aFlavor        Transferable flavor, can be ""
        /// @param aSourceDoc          document where input was dragged from (may be null)
        /// @param aDestinationNode    location for insertion (such as when dropped)
        /// @param aDestinationOffset  used with aDestNode to determine insert location
        /// @param aDeleteSelection    used with aDestNode during drag&drop
        /// @param aCollapseSelection  used with aDestNode during drag&drop
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertHTMLWithContext([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aInputString, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aContextStr, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aInfoStr, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aFlavor, [MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aSourceDoc, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aDestinationNode, int aDestinationOffset, [MarshalAs(UnmanagedType.U1)] bool aDeleteSelection);
		
		/// <summary>
        /// Insert an element, which may have child nodes, at the selection
        /// Used primarily to insert a new element for various insert element dialogs,
        /// but it enforces the HTML 4.0 DTD "CanContain" rules, so it should
        /// be useful for other elements.
        ///
        /// @param aElement           The element to insert
        /// @param aDeleteSelection   Delete the selection before inserting
        /// If aDeleteSelection is PR_FALSE, then the element is inserted
        /// after the end of the selection for all element except
        /// Named Anchors, which insert before the selection
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertElementAtSelection([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.U1)] bool aDeleteSelection);
		
		/// <summary>
        /// Set the documents title.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocumentTitle([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle);
		
		/// <summary>
        /// Set the BaseURL for the document to the current URL
        /// but only if the page doesn't have a <base> tag
        /// This should be done after the document URL has changed,
        /// such as after saving a file
        /// This is used as base for relativizing link and image urls
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateBaseURL();
		
		/// <summary>
        /// Set the selection at the suppled element
        ///
        /// @param aElement   An element in the document
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>
        /// Create a collapsed selection just after aElement
        ///
        /// XXX could we parameterize SelectElement(before/select/after>?
        ///
        /// The selection is set to parent-of-aElement with an
        /// offset 1 greater than aElement's offset
        /// but it enforces the HTML 4.0 DTD "CanContain" rules, so it should
        /// be useful for other elements.
        ///
        /// @param aElement  An element in the document
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCaretAfterElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>
        /// SetParagraphFormat       Insert a block paragraph tag around selection
        /// @param aParagraphFormat  "p", "h1" to "h6", "address", "pre", or "blockquote"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParagraphFormat([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aParagraphFormat);
		
		/// <summary>
        /// getParagraphState returns what block tag paragraph format is in
        /// the selection.
        /// @param aMixed     True if there is more than one format
        /// @return           Name of block tag. "" is returned for none.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetParagraphState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// getFontFaceState returns what font face is in the selection.
        /// @param aMixed    True if there is more than one font face
        /// @return          Name of face.  Note: "tt" is returned for
        /// tt tag.  "" is returned for none.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFontFaceState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// getFontColorState returns what font face is in the selection.
        /// @param aMixed     True if there is more than one font color
        /// @return           Color string. "" is returned for none.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFontColorState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// getFontColorState returns what font face is in the selection.
        /// @param aMixed     True if there is more than one font color
        /// @return           Color string. "" is returned for none.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBackgroundColorState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// getHighlightColorState returns what the highlight color of the selection.
        /// @param aMixed     True if there is more than one font color
        /// @return           Color string. "" is returned for none.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHighlightColorState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// getListState returns what list type is in the selection.
        /// @param aMixed    True if there is more than one type of list, or
        /// if there is some list and non-list
        /// @param aOL       The company that employs me.  No, really, it's
        /// true if an "ol" list is selected.
        /// @param aUL       true if an "ul" list is selected.
        /// @param aDL       true if a "dl" list is selected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetListState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.U1)] ref bool aOL, [MarshalAs(UnmanagedType.U1)] ref bool aUL, [MarshalAs(UnmanagedType.U1)] ref bool aDL);
		
		/// <summary>
        /// getListItemState returns what list item type is in the selection.
        /// @param aMixed    True if there is more than one type of list item, or
        /// if there is some list and non-list
        /// @param aLI       true if "li" list items are selected.
        /// @param aDT       true if "dt" list items are selected.
        /// @param aDD       true if "dd" list items are selected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetListItemState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.U1)] ref bool aLI, [MarshalAs(UnmanagedType.U1)] ref bool aDT, [MarshalAs(UnmanagedType.U1)] ref bool aDD);
		
		/// <summary>
        /// getAlignment     returns what alignment is in the selection.
        /// @param aMixed    True if there is more than one type of list item, or
        /// if there is some list and non-list
        /// @param aAlign    enum value for first encountered alignment
        /// (left/center/right)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAlignment([MarshalAs(UnmanagedType.U1)] ref bool aMixed, ref short aAlign);
		
		/// <summary>
        /// Document me!
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIndentState([MarshalAs(UnmanagedType.U1)] ref bool aCanIndent, [MarshalAs(UnmanagedType.U1)] ref bool aCanOutdent);
		
		/// <summary>
        /// Document me!
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MakeOrChangeList([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aListType, [MarshalAs(UnmanagedType.U1)] bool entireList, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBulletType);
		
		/// <summary>
        /// Document me!
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveList([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aListType);
		
		/// <summary>
        /// Document me!
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Indent([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aIndent);
		
		/// <summary>
        /// Document me!
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Align([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAlign);
		
		/// <summary>
        /// Return the input node or a parent matching the given aTagName,
        /// starting the search at the supplied node.
        /// An example of use is for testing if a node is in a table cell
        /// given a selection anchor node.
        ///
        /// @param aTagName  The HTML tagname
        /// Special input values:
        /// Use "href" to get a link node
        /// (an "A" tag with the "href" attribute set)
        /// Use "anchor" or "namedanchor" to get a named anchor node
        /// (an "A" tag with the "name" attribute set)
        /// Use "list" to get an OL, UL, or DL list node
        /// Use "td" to get either a TD or TH cell node
        ///
        /// @param aNode    The node in the document to start the search.
        /// If it is null, the anchor node of the current selection is used.
        /// @return         NS_EDITOR_ELEMENT_NOT_FOUND if an element is not found
        /// (passes NS_SUCCEEDED macro)
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetElementOrParentByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTagName, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);
		
		/// <summary>
        /// Return an element only if it is the only node selected,
        /// such as an image, horizontal rule, etc.
        /// The exception is a link, which is more like a text attribute:
        /// The Anchor tag is returned if the selection is within the textnode(s)
        /// that are children of the "A" node.
        /// This could be a collapsed selection, i.e., a caret
        /// within the link text.
        ///
        /// @param aTagName  The HTML tagname or and empty string
        /// to get any element (but only if it is the only element selected)
        /// Special input values for Links and Named anchors:
        /// Use "href" to get a link node
        /// (an "A" tag with the "href" attribute set)
        /// Use "anchor" or "namedanchor" to get a named anchor node
        /// (an "A" tag with the "name" attribute set)
        /// @return          NS_EDITOR_ELEMENT_NOT_FOUND if an element is not found
        /// (passes NS_SUCCEEDED macro)
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetSelectedElement([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTagName);
		
		/// <summary>
        /// Output the contents of the <HEAD> section as text/HTML format
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHeadContentsAsHTML([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Replace all children of <HEAD> with string of HTML source
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReplaceHeadContentsWithHTML([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSourceToInsert);
		
		/// <summary>
        /// Return a new element with default attribute values
        ///
        /// This does not rely on the selection, and is not sensitive to context.
        ///
        /// Used primarily to supply new element for various insert element dialogs
        /// (Image, Link, NamedAnchor, Table, and HorizontalRule
        /// are the only returned elements as of 7/25/99)
        ///
        /// @param aTagName  The HTML tagname
        /// Special input values for Links and Named anchors:
        /// Use "href" to get a link node
        /// (an "A" tag with the "href" attribute set)
        /// Use "anchor" or "namedanchor" to get a named anchor node
        /// (an "A" tag with the "name" attribute set)
        /// @return          The new element created.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement CreateElementWithDefaults([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTagName);
		
		/// <summary>
        /// Insert an link element as the parent of the current selection
        ///
        /// @param aElement   An "A" element with a non-empty "href" attribute
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertLinkAroundSelection([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aAnchorElement);
		
		/// <summary>
        /// Set the value of the "bgcolor" attribute on the document's <body> element
        ///
        /// @param aColor  The HTML color string, such as "#ffccff" or "yellow"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBackgroundColor([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aColor);
		
		/// <summary>
        /// Set an attribute on the document's <body> element
        /// such as text, link, background colors
        ///
        /// 8/31/00 THIS ISN'T BEING USED? SHOULD WE DROP IT?
        ///
        /// @param aAttr   The attribute to be set
        /// @param aValue  The value of the attribute
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBodyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAttr, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		/// <summary>
        /// Find all the nodes in the document which contain references
        /// to outside URIs (e.g. a href, img src, script src, etc.)
        /// The objects in the array will be type nsIURIRefObject.
        ///
        /// @return aNodeList    the linked nodes found
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupportsArray GetLinkedObjects();
		
		/// <summary>
        /// A boolean which is true is the HTMLEditor has been instantiated
        /// with CSS knowledge and if the CSS pref is currently checked
        ///
        /// @return    true if CSS handled and enabled
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsCSSEnabledAttribute();
		
		/// <summary>
        /// A boolean which is true is the HTMLEditor has been instantiated
        /// with CSS knowledge and if the CSS pref is currently checked
        ///
        /// @return    true if CSS handled and enabled
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsCSSEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aIsCSSEnabled);
		
		/// <summary>
        /// Add listener for insertion override
        /// @param inFilter  function which callers want called during insertion
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddInsertionListener(System.IntPtr inFilter);
		
		/// <summary>
        /// Remove listener for insertion override
        /// @param inFilter  function which callers do not want called during insertion
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveInsertionListener(System.IntPtr inFilter);
		
		/// <summary>
        /// Returns an anonymous nsDOMElement of type aTag,
        /// child of aParentNode. If aIsCreatedHidden is true, the class
        /// "hidden" is added to the created element. If aAnonClass is not
        /// the empty string, it becomes the value of the attribute "_moz_anonclass"
        /// @return a DOM Element
        /// @param aTag             [IN] a string representing the desired type of
        /// the element to create
        /// @param aParentNode      [IN] the parent node of the created anonymous
        /// element
        /// @param aAnonClass       [IN] contents of the _moz_anonclass attribute
        /// @param aIsCreatedHidden [IN] a boolean specifying if the class "hidden"
        /// is to be added to the created anonymous
        /// element
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement CreateAnonymousElement([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTag, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aParentNode, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAnonClass, [MarshalAs(UnmanagedType.U1)] bool aIsCreatedHidden);
		
		/// <summary>
        /// returns the deepest container of the selection
        /// @return a DOM Element
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetSelectionContainer();
		
		/// <summary>
        /// Checks if the anonymous nodes created by the HTML editor have to be
        /// refreshed or hidden depending on a possible new state of the selection
        /// @param aSelection [IN] a selection
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckSelectionStateForAnonymousButtons([MarshalAs(UnmanagedType.Interface)] nsISelection aSelection);
		
		/// <summary>Member IsAnonymousElement </summary>
		/// <param name='aElement'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsAnonymousElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>
        /// A boolean indicating if a return key pressed in a paragraph creates
        /// another paragraph or just inserts a <br> at the caret
        ///
        /// @return    true if CR in a paragraph creates a new paragraph
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetReturnInParagraphCreatesNewParagraphAttribute();
		
		/// <summary>
        /// A boolean indicating if a return key pressed in a paragraph creates
        /// another paragraph or just inserts a <br> at the caret
        ///
        /// @return    true if CR in a paragraph creates a new paragraph
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReturnInParagraphCreatesNewParagraphAttribute([MarshalAs(UnmanagedType.U1)] bool aReturnInParagraphCreatesNewParagraph);
		
		/// <summary>
        /// Checks whether a BR node is visible to the user.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool BreakIsVisible([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);
		
		/// <summary>
        /// Get an active editor's editing host in DOM window.  If this editor isn't
        /// active in the DOM window, this returns NULL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetActiveEditingHost();
	}
	
	/// <summary>nsIHTMLEditorConsts </summary>
	public class nsIHTMLEditorConsts
	{
		
		// <summary>
        // used by GetAlignment()
        // </summary>
		public const int eLeft = 0;
		
		// 
		public const int eCenter = 1;
		
		// 
		public const int eRight = 2;
		
		// 
		public const int eJustify = 3;
	}
}
