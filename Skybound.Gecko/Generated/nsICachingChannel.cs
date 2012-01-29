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
// Generated by IDLImporter from file nsICachingChannel.idl
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
	
	
	/// <summary>
    /// A channel may optionally implement this interface to allow clients
    /// to affect its behavior with respect to how it uses the cache service.
    ///
    /// This interface provides:
    /// 1) Support for "stream as file" semantics (for JAR and plugins).
    /// 2) Support for "pinning" cached data in the cache (for printing and save-as).
    /// 3) Support for uniquely identifying cached data in cases when the URL
    /// is insufficient (e.g., HTTP form submission).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("830D4BCB-3E46-4011-9BDA-51A5D1AF891F")]
	public interface nsICachingChannel : nsICacheInfoChannel
	{
		
		/// <summary>
        /// Get expiration time from cache token. This attribute is equivalent to
        /// nsICachingChannel.cacheToken.expirationTime.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetCacheTokenExpirationTimeAttribute();
		
		/// <summary>
        /// Set/get charset of cache entry. Accessing this attribute is equivalent to
        /// calling nsICachingChannel.cacheToken.getMetaDataElement("charset") and
        /// nsICachingChannel.cacheToken.setMetaDataElement("charset").
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetCacheTokenCachedCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aCacheTokenCachedCharset);
		
		/// <summary>
        /// Set/get charset of cache entry. Accessing this attribute is equivalent to
        /// calling nsICachingChannel.cacheToken.getMetaDataElement("charset") and
        /// nsICachingChannel.cacheToken.setMetaDataElement("charset").
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCacheTokenCachedCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aCacheTokenCachedCharset);
		
		/// <summary>
        /// TRUE if this channel's data is being loaded from the cache.  This value
        /// is undefined before the channel fires its OnStartRequest notification
        /// and after the channel fires its OnStopRequest notification.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsFromCache();
		
		/// <summary>
        /// Set/get the cache token... uniquely identifies the data in the cache.
        /// Holding a reference to this token prevents the cached data from being
        /// removed.
        ///
        /// A cache token retrieved from a particular instance of nsICachingChannel
        /// could be set on another instance of nsICachingChannel provided the
        /// underlying implementations are compatible.  The implementation of
        /// nsICachingChannel would be expected to only read from the cache entry
        /// identified by the cache token and not try to validate it.
        ///
        /// The cache token can be QI'd to a nsICacheEntryInfo if more detail
        /// about the cache entry is needed (e.g., expiration time).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetCacheTokenAttribute();
		
		/// <summary>
        /// Set/get the cache token... uniquely identifies the data in the cache.
        /// Holding a reference to this token prevents the cached data from being
        /// removed.
        ///
        /// A cache token retrieved from a particular instance of nsICachingChannel
        /// could be set on another instance of nsICachingChannel provided the
        /// underlying implementations are compatible.  The implementation of
        /// nsICachingChannel would be expected to only read from the cache entry
        /// identified by the cache token and not try to validate it.
        ///
        /// The cache token can be QI'd to a nsICacheEntryInfo if more detail
        /// about the cache entry is needed (e.g., expiration time).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCacheTokenAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aCacheToken);
		
		/// <summary>
        /// The same as above but accessing the offline app cache token if there
        /// is any.
        ///
        /// @throws
        /// NS_ERROR_NOT_AVAILABLE when there is not offline cache token
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetOfflineCacheTokenAttribute();
		
		/// <summary>
        /// The same as above but accessing the offline app cache token if there
        /// is any.
        ///
        /// @throws
        /// NS_ERROR_NOT_AVAILABLE when there is not offline cache token
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOfflineCacheTokenAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aOfflineCacheToken);
		
		/// <summary>
        /// Set/get the cache key... uniquely identifies the data in the cache
        /// for this channel.  Holding a reference to this key does NOT prevent
        /// the cached data from being removed.
        ///
        /// A cache key retrieved from a particular instance of nsICachingChannel
        /// could be set on another instance of nsICachingChannel provided the
        /// underlying implementations are compatible and provided the new
        /// channel instance was created with the same URI.  The implementation of
        /// nsICachingChannel would be expected to use the cache entry identified
        /// by the cache token.  Depending on the value of nsIRequest::loadFlags,
        /// the cache entry may be validated, overwritten, or simply read.
        ///
        /// The cache key may be NULL indicating that the URI of the channel is
        /// sufficient to locate the same cache entry.  Setting a NULL cache key
        /// is likewise valid.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetCacheKeyAttribute();
		
		/// <summary>
        /// Set/get the cache key... uniquely identifies the data in the cache
        /// for this channel.  Holding a reference to this key does NOT prevent
        /// the cached data from being removed.
        ///
        /// A cache key retrieved from a particular instance of nsICachingChannel
        /// could be set on another instance of nsICachingChannel provided the
        /// underlying implementations are compatible and provided the new
        /// channel instance was created with the same URI.  The implementation of
        /// nsICachingChannel would be expected to use the cache entry identified
        /// by the cache token.  Depending on the value of nsIRequest::loadFlags,
        /// the cache entry may be validated, overwritten, or simply read.
        ///
        /// The cache key may be NULL indicating that the URI of the channel is
        /// sufficient to locate the same cache entry.  Setting a NULL cache key
        /// is likewise valid.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCacheKeyAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aCacheKey);
		
		/// <summary>
        /// Specifies whether or not the data should be cached to a file.  This
        /// may fail if the disk cache is not present.  The value of this attribute
        /// is usually only settable during the processing of a channel's
        /// OnStartRequest.  The default value of this attribute depends on the
        /// particular implementation of nsICachingChannel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCacheAsFileAttribute();
		
		/// <summary>
        /// Specifies whether or not the data should be cached to a file.  This
        /// may fail if the disk cache is not present.  The value of this attribute
        /// is usually only settable during the processing of a channel's
        /// OnStartRequest.  The default value of this attribute depends on the
        /// particular implementation of nsICachingChannel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCacheAsFileAttribute([MarshalAs(UnmanagedType.U1)] bool aCacheAsFile);
		
		/// <summary>
        /// Specifies whether or not the data should be placed in the offline cache,
        /// in addition to normal memory/disk caching.  This may fail if the offline
        /// cache is not present.  The value of this attribute should be set before
        /// opening the channel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCacheForOfflineUseAttribute();
		
		/// <summary>
        /// Specifies whether or not the data should be placed in the offline cache,
        /// in addition to normal memory/disk caching.  This may fail if the offline
        /// cache is not present.  The value of this attribute should be set before
        /// opening the channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCacheForOfflineUseAttribute([MarshalAs(UnmanagedType.U1)] bool aCacheForOfflineUse);
		
		/// <summary>
        /// The session into which to cache offline data.  If not specified,
        /// data will be placed in "HTTP-offline"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOfflineCacheClientIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aOfflineCacheClientID);
		
		/// <summary>
        /// The session into which to cache offline data.  If not specified,
        /// data will be placed in "HTTP-offline"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOfflineCacheClientIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aOfflineCacheClientID);
		
		/// <summary>
        /// Get the "file" where the cached data can be found.  This is valid for
        /// as long as a reference to the cache token is held.  This may return
        /// an error if cacheAsFile is false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetCacheFileAttribute();
	}
}
