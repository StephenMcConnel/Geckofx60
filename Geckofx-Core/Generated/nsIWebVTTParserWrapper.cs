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
// Generated by IDLImporter from file nsIWebVTTParserWrapper.idl
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
    /// Interface for a wrapper of a JS WebVTT parser (vtt.js).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8dfe016e-1701-4618-9f5e-9a6154e853f0")]
	public interface nsIWebVTTParserWrapper
	{
		
		/// <summary>
        /// Loads the JS WebVTTParser and sets it to use the passed window to create
        /// VTTRegions and VTTCues. This function must be called before calling
        /// parse, flush, or watch.
        ///
        /// @param window The window that the parser will use to create VTTCues and
        /// VTTRegions.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadParser(mozIDOMWindow window);
		
		/// <summary>
        /// Attempts to parse the stream's data as WebVTT format. When it successfully
        /// parses a WebVTT region or WebVTT cue it will create a VTTRegion or VTTCue
        /// object and pass it back to the callee through its callbacks.
        ///
        /// @param data   The buffer that contains the WebVTT data received by the
        /// Necko consumer so far.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Parse([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase data);
		
		/// <summary>
        /// Flush indicates that no more data is expected from the stream. As such the
        /// parser should try to parse any kind of partial data it has.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Flush();
		
		/// <summary>
        /// Set this parser object to use an nsIWebVTTListener object for its onCue
        /// and onRegion callbacks.
        ///
        /// @param callback The nsIWebVTTListener object that exposes onCue and
        /// onRegion callbacks for the parser.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Watch([MarshalAs(UnmanagedType.Interface)] nsIWebVTTListener callback);
		
		/// <summary>
        /// Convert the text content of a WebVTT cue to a document fragment so that
        /// we can display it on the page.
        ///
        /// @param window A window object with which the document fragment will be
        /// created.
        /// @param cue    The cue whose content will be converted to a document
        /// fragment.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocumentFragment ConvertCueToDOMTree(mozIDOMWindow window, [MarshalAs(UnmanagedType.Interface)] nsISupports cue);
		
		/// <summary>
        /// Compute the display state of the VTTCues in cues along with any VTTRegions
        /// that they might be in. First, it computes the positioning and styling of
        /// the cues and regions passed and converts them into a DOM tree rooted at
        /// a containing HTMLDivElement. It then adjusts those computed divs for
        /// overlap avoidance using the dimensions of 'overlay'. Finally, it adds the
        /// computed divs to the VTTCues display state property for use later.
        ///
        /// @param window  A window object with which it will create the DOM tree
        /// and containing div element.
        /// @param cues    An array of VTTCues who need there display state to be
        /// computed.
        /// @param overlay The HTMLElement that the cues will be displayed within.
        /// @param controls The video control element that will affect cues position.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ProcessCues(mozIDOMWindow window, [MarshalAs(UnmanagedType.Interface)] nsIVariant cues, [MarshalAs(UnmanagedType.Interface)] nsISupports overlay, [MarshalAs(UnmanagedType.Interface)] nsISupports controls);
	}
}
