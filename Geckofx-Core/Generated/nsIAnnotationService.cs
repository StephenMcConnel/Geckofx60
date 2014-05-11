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
// Generated by IDLImporter from file nsIAnnotationService.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("63fe98e0-6889-4c2c-ac9f-703e4bc25027")]
	public interface nsIAnnotationObserver
	{
		
		/// <summary>
        /// Called when an annotation value is set. It could be a new annotation,
        /// or it could be a new value for an existing annotation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnPageAnnotationSet([MarshalAs(UnmanagedType.Interface)] nsIURI aPage, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemAnnotationSet(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Called when an annotation is deleted. If aName is empty, then ALL
        /// annotations for the given URI have been deleted. This is not called when
        /// annotations are expired (normally happens when the app exits).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnPageAnnotationRemoved([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemAnnotationRemoved(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
	}
	
	/// <summary>nsIAnnotationService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("D4CDAAB1-8EEC-47A8-B420-AD7CB333056A")]
	public interface nsIAnnotationService
	{
		
		/// <summary>
        /// Sets an annotation, overwriting any previous annotation with the same
        /// URL/name. IT IS YOUR JOB TO NAMESPACE YOUR ANNOTATION NAMES.
        /// Use the form "namespace/value", so your name would be like
        /// "bills_extension/page_state" or "history/thumbnail".
        ///
        /// Do not use characters that are not valid in URLs such as spaces, ":",
        /// commas, or most other symbols. You should stick to ASCII letters and
        /// numbers plus "_", "-", and "/".
        ///
        /// aExpiration is one of EXPIRE_* above. aFlags should be 0 for now, some
        /// flags will be defined in the future.
        ///
        /// NOTE: ALL PAGE ANNOTATIONS WILL GET DELETED WHEN THE PAGE IS REMOVED FROM
        /// HISTORY IF THE PAGE IS NOT BOOKMARKED. This means that if you create an
        /// annotation on an unvisited URI, it will get deleted when the browser
        /// shuts down. Otherwise, URIs can exist in history as annotations but the
        /// user has no way of knowing it, potentially violating their privacy
        /// expectations about actions such as "Clear history".
        /// If there is an important annotation that the user or extension wants to
        /// keep, you should add a bookmark for the page and use an EXPIRE_NEVER
        /// annotation.  This will ensure the annotation exists until the item is
        /// removed by the user.
        /// See EXPIRE_* constants above for further information.
        ///
        /// The annotation "favicon" is special. Favicons are stored in the favicon
        /// service, but are special cased in the protocol handler so they look like
        /// annotations. Do not set favicons using this service, it will not work.
        ///
        /// Only C++ consumers may use the type-specific methods.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE if the page or the bookmark doesn't exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue, int aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotation </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotation(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue, int aFlags, ushort aExpiration);
		
		/// <summary>
        /// @throws NS_ERROR_ILLEGAL_VALUE if the page or the bookmark doesn't exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationString([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase aValue, int aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationString </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationString(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase aValue, int aFlags, ushort aExpiration);
		
		/// <summary>
        /// Sets an annotation just like setAnnotationString, but takes an Int32 as
        /// input.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE if the page or the bookmark doesn't exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationInt32([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, int aValue, int aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationInt32 </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationInt32(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, int aValue, int aFlags, ushort aExpiration);
		
		/// <summary>
        /// Sets an annotation just like setAnnotationString, but takes an Int64 as
        /// input.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE if the page or the bookmark doesn't exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationInt64([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, long aValue, int aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationInt64 </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationInt64(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, long aValue, int aFlags, ushort aExpiration);
		
		/// <summary>
        /// Sets an annotation just like setAnnotationString, but takes a double as
        /// input.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE if the page or the bookmark doesn't exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationDouble([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, double aValue, int aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationDouble </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationDouble(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, double aValue, int aFlags, ushort aExpiration);
		
		/// <summary>
        /// Retrieves the value of a given annotation. Throws an error if the
        /// annotation does not exist. C++ consumers may use the type-specific
        /// methods.
        ///
        /// The type-specific methods throw if the given annotation is set in
        /// a different type.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetPageAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>Member GetItemAnnotation </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A nsIVariant</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetItemAnnotation(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// @see getPageAnnotation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPageAnnotationString([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase retval);
		
		/// <summary>Member GetItemAnnotationString </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetItemAnnotationString(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Gecko.CustomMarshalers.AStringMarshaler))] nsAStringBase retval);
		
		/// <summary>
        /// @see getPageAnnotation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPageAnnotationInt32([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>Member GetItemAnnotationInt32 </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemAnnotationInt32(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// @see getPageAnnotation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPageAnnotationInt64([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>Member GetItemAnnotationInt64 </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemAnnotationInt64(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// @see getPageAnnotation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetPageAnnotationDouble([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>Member GetItemAnnotationDouble </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetItemAnnotationDouble(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Retrieves info about an existing annotation.
        ///
        /// aType will be one of TYPE_* constansts above
        ///
        /// example JS:
        /// var flags = {}, exp = {}, type = {};
        /// annotator.getAnnotationInfo(myURI, "foo", flags, exp, type);
        /// // now you can use 'exp.value' and 'flags.value'
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPageAnnotationInfo([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, ref int aFlags, ref ushort aExpiration, ref ushort aType);
		
		/// <summary>Member GetItemAnnotationInfo </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetItemAnnotationInfo(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, ref int aFlags, ref ushort aExpiration, ref ushort aType);
		
		/// <summary>
        /// Retrieves the type of an existing annotation
        /// Use getAnnotationInfo if you need this along with the mime-type etc.
        ///
        /// @param aURI
        /// the uri on which the annotation is set
        /// @param aName
        /// the annotation name
        /// @return one of the TYPE_* constants above
        /// @throws if the annotation is not set
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetPageAnnotationType([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>Member GetItemAnnotationType </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetItemAnnotationType(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Returns a list of all URIs having a given annotation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPagesWithAnnotation([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase name, ref uint resultCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref nsIURI[] results);
		
		/// <summary>Member GetItemsWithAnnotation </summary>
		/// <param name='name'> </param>
		/// <param name='resultCount'> </param>
		/// <param name='results'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetItemsWithAnnotation([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase name, ref uint resultCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref int[] results);
		
		/// <summary>
        /// Returns a list of mozIAnnotation(s), having a given annotation name.
        ///
        /// @param name
        /// The annotation to search for.
        /// @return list of mozIAnnotation objects.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIAnnotatedResult GetAnnotationsWithName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase name, ref uint count);
		
		/// <summary>
        /// Get the names of all annotations for this URI.
        ///
        /// example JS:
        /// var annotations = annotator.getPageAnnotations(myURI, {});
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPageAnnotationNames([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref nsIVariant[] result);
		
		/// <summary>Member GetItemAnnotationNames </summary>
		/// <param name='aItemId'> </param>
		/// <param name='count'> </param>
		/// <param name='result'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetItemAnnotationNames(long aItemId, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref nsIVariant[] result);
		
		/// <summary>
        /// Test for annotation existence.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PageHasAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>Member ItemHasAnnotation </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ItemHasAnnotation(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Removes a specific annotation. Succeeds even if the annotation is
        /// not found.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePageAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>Member RemoveItemAnnotation </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveItemAnnotation(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Removes all annotations for the given page/item.
        /// We may want some other similar functions to get annotations with given
        /// flags (once we have flags defined).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePageAnnotations([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>Member RemoveItemAnnotations </summary>
		/// <param name='aItemId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveItemAnnotations(long aItemId);
		
		/// <summary>
        /// Copies all annotations from the source to the destination URI/item. If
        /// the destination already has an annotation with the same name as one on
        /// the source, it will be overwritten if aOverwriteDest is set. Otherwise,
        /// the original annotation will be preferred.
        ///
        /// All the source annotations will stay as-is. If you don't want them
        /// any more, use removePageAnnotations on that URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyPageAnnotations([MarshalAs(UnmanagedType.Interface)] nsIURI aSourceURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aDestURI, [MarshalAs(UnmanagedType.U1)] bool aOverwriteDest);
		
		/// <summary>Member CopyItemAnnotations </summary>
		/// <param name='aSourceItemId'> </param>
		/// <param name='aDestItemId'> </param>
		/// <param name='aOverwriteDest'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyItemAnnotations(long aSourceItemId, long aDestItemId, [MarshalAs(UnmanagedType.U1)] bool aOverwriteDest);
		
		/// <summary>
        /// Adds an annotation observer. The annotation service will keep an owning
        /// reference to the observer object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIAnnotationObserver aObserver);
		
		/// <summary>
        /// Removes an annotaton observer previously registered by addObserver.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIAnnotationObserver aObserver);
	}
	
	/// <summary>nsIAnnotationServiceConsts </summary>
	public class nsIAnnotationServiceConsts
	{
		
		// <summary>
        // Removed at application exit.
        // </summary>
		public const ulong EXPIRE_SESSION = 0;
		
		// <summary>
        // Removed at 30 days.
        // </summary>
		public const ulong EXPIRE_WEEKS = 2;
		
		// <summary>
        // Removed at 180 days.
        // </summary>
		public const ulong EXPIRE_MONTHS = 3;
		
		// <summary>
        // An item annotation will expire when the item is deleted.
        // </summary>
		public const ulong EXPIRE_NEVER = 4;
		
		// <summary>
        // Valid only for page annotations.
        // </summary>
		public const ulong EXPIRE_WITH_HISTORY = 5;
		
		// <summary>
        // Removed at 7 days.
        // </summary>
		public const ulong EXPIRE_DAYS = 6;
		
		// <summary>
        // type constants
        // </summary>
		public const ulong TYPE_INT32 = 1;
		
		// 
		public const ulong TYPE_DOUBLE = 2;
		
		// 
		public const ulong TYPE_STRING = 3;
		
		// 
		public const ulong TYPE_INT64 = 5;
	}
	
	/// <summary>
    /// Represents a place annotated with a given annotation.  If a place has
    /// multiple annotations, it can be represented by multiple
    /// mozIAnnotatedResult(s).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("81fd0188-db6a-492e-80b6-f6414913b396")]
	public interface mozIAnnotatedResult
	{
		
		/// <summary>
        /// The globally unique identifier of the place with this annotation.
        ///
        /// @note if itemId is valid this is the guid of the bookmark, otherwise
        /// of the page.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aGuid);
		
		/// <summary>
        /// The URI of the place with this annotation, if available, null otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetUriAttribute();
		
		/// <summary>
        /// The bookmark id of the place with this annotation, if available,
        /// -1 otherwise.
        ///
        /// @note if itemId is -1, it doesn't mean the page is not bookmarked, just
        /// that this annotation is relative to the page, not to the bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetItemIdAttribute();
		
		/// <summary>
        /// Name of the annotation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAnnotationNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aAnnotationName);
		
		/// <summary>
        /// Value of the annotation.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetAnnotationValueAttribute();
	}
}
