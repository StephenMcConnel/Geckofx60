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
// Generated by IDLImporter from file nsIHttpChannel.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// nsIHttpChannel
    ///
    /// This interface allows for the modification of HTTP request parameters and
    /// the inspection of the resulting HTTP response status and headers when they
    /// become available.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9277fe09-f0cc-4cd9-bbce-581dd94b0260")]
	public interface nsIHttpChannel : nsIChannel
	{
		
		/// <summary>
        /// The name of the request.  Often this is the URI of the request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// Indicates whether the request is pending. nsIRequest::isPending is
        /// true when there is an outstanding asynchronous event that will make
        /// the request no longer be pending.  Requests do not necessarily start
        /// out pending; in some cases, requests have to be explicitly initiated
        /// (e.g. nsIChannel implementations are only pending once asyncOpen
        /// returns successfully).
        ///
        /// Requests can become pending multiple times during their lifetime.
        ///
        /// @return TRUE if the request has yet to reach completion.
        /// @return FALSE if the request has reached completion (e.g., after
        /// OnStopRequest has fired).
        /// @note Suspended requests are still considered pending.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsPending();
		
		/// <summary>
        /// The error status associated with the request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetStatusAttribute();
		
		/// <summary>
        /// Cancels the current request.  This will close any open input or
        /// output streams and terminate any async requests.  Users should
        /// normally pass NS_BINDING_ABORTED, although other errors may also
        /// be passed.  The error passed in will become the value of the
        /// status attribute.
        ///
        /// Implementations must not send any notifications (e.g. via
        /// nsIRequestObserver) synchronously from this function. Similarly,
        /// removal from the load group (if any) must also happen asynchronously.
        ///
        /// Requests that use nsIStreamListener must not call onDataAvailable
        /// anymore after cancel has been called.
        ///
        /// @param aStatus the reason for canceling this request.
        ///
        /// NOTE: most nsIRequest implementations expect aStatus to be a
        /// failure code; however, some implementations may allow aStatus to
        /// be a success code such as NS_OK.  In general, aStatus should be
        /// a failure code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Cancel(int aStatus);
		
		/// <summary>
        /// Suspends the current request.  This may have the effect of closing
        /// any underlying transport (in order to free up resources), although
        /// any open streams remain logically opened and will continue delivering
        /// data when the transport is resumed.
        ///
        /// Calling cancel() on a suspended request must not send any
        /// notifications (such as onstopRequest) until the request is resumed.
        ///
        /// NOTE: some implementations are unable to immediately suspend, and
        /// may continue to deliver events already posted to an event queue. In
        /// general, callers should be capable of handling events even after
        /// suspending a request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Suspend();
		
		/// <summary>
        /// Resumes the current request.  This may have the effect of re-opening
        /// any underlying transport and will resume the delivery of data to
        /// any open streams.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Resume();
		
		/// <summary>
        /// The load group of this request.  While pending, the request is a
        /// member of the load group.  It is the responsibility of the request
        /// to implement this policy.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsILoadGroup GetLoadGroupAttribute();
		
		/// <summary>
        /// The load group of this request.  While pending, the request is a
        /// member of the load group.  It is the responsibility of the request
        /// to implement this policy.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup);
		
		/// <summary>
        /// The load flags of this request.  Bits 0-15 are reserved.
        ///
        /// When added to a load group, this request's load flags are merged with
        /// the load flags of the load group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetLoadFlagsAttribute();
		
		/// <summary>
        /// The load flags of this request.  Bits 0-15 are reserved.
        ///
        /// When added to a load group, this request's load flags are merged with
        /// the load flags of the load group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLoadFlagsAttribute(uint aLoadFlags);
		
		/// <summary>
        /// The original URI used to construct the channel. This is used in
        /// the case of a redirect or URI "resolution" (e.g. resolving a
        /// resource: URI to a file: URI) so that the original pre-redirect
        /// URI can still be obtained.  This is never null.  Attempts to
        /// set it to null must throw.
        ///
        /// NOTE: this is distinctly different from the http Referer (referring URI),
        /// which is typically the page that contained the original URI (accessible
        /// from nsIHttpChannel).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI GetOriginalURIAttribute();
		
		/// <summary>
        /// The original URI used to construct the channel. This is used in
        /// the case of a redirect or URI "resolution" (e.g. resolving a
        /// resource: URI to a file: URI) so that the original pre-redirect
        /// URI can still be obtained.  This is never null.  Attempts to
        /// set it to null must throw.
        ///
        /// NOTE: this is distinctly different from the http Referer (referring URI),
        /// which is typically the page that contained the original URI (accessible
        /// from nsIHttpChannel).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOriginalURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aOriginalURI);
		
		/// <summary>
        /// The URI corresponding to the channel.  Its value is immutable.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI GetURIAttribute();
		
		/// <summary>
        /// The owner, corresponding to the entity that is responsible for this
        /// channel.  Used by the security manager to grant or deny privileges to
        /// mobile code loaded from this channel.
        ///
        /// NOTE: this is a strong reference to the owner, so if the owner is also
        /// holding a strong reference to the channel, care must be taken to
        /// explicitly drop its reference to the channel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISupports GetOwnerAttribute();
		
		/// <summary>
        /// The owner, corresponding to the entity that is responsible for this
        /// channel.  Used by the security manager to grant or deny privileges to
        /// mobile code loaded from this channel.
        ///
        /// NOTE: this is a strong reference to the owner, so if the owner is also
        /// holding a strong reference to the channel, care must be taken to
        /// explicitly drop its reference to the channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aOwner);
		
		/// <summary>
        /// The notification callbacks for the channel.  This is set by clients, who
        /// wish to provide a means to receive progress, status and protocol-specific
        /// notifications.  If this value is NULL, the channel implementation may use
        /// the notification callbacks from its load group.  The channel may also
        /// query the notification callbacks from its load group if its notification
        /// callbacks do not supply the requested interface.
        ///
        /// Interfaces commonly requested include: nsIProgressEventSink, nsIPrompt,
        /// and nsIAuthPrompt/nsIAuthPrompt2.
        ///
        /// When the channel is done, it must not continue holding references to
        /// this object.
        ///
        /// NOTE: A channel implementation should take care when "caching" an
        /// interface pointer queried from its notification callbacks.  If the
        /// notification callbacks are changed, then a cached interface pointer may
        /// become invalid and may therefore need to be re-queried.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInterfaceRequestor GetNotificationCallbacksAttribute();
		
		/// <summary>
        /// The notification callbacks for the channel.  This is set by clients, who
        /// wish to provide a means to receive progress, status and protocol-specific
        /// notifications.  If this value is NULL, the channel implementation may use
        /// the notification callbacks from its load group.  The channel may also
        /// query the notification callbacks from its load group if its notification
        /// callbacks do not supply the requested interface.
        ///
        /// Interfaces commonly requested include: nsIProgressEventSink, nsIPrompt,
        /// and nsIAuthPrompt/nsIAuthPrompt2.
        ///
        /// When the channel is done, it must not continue holding references to
        /// this object.
        ///
        /// NOTE: A channel implementation should take care when "caching" an
        /// interface pointer queried from its notification callbacks.  If the
        /// notification callbacks are changed, then a cached interface pointer may
        /// become invalid and may therefore need to be re-queried.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNotificationCallbacksAttribute([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aNotificationCallbacks);
		
		/// <summary>
        /// Transport-level security information (if any) corresponding to the channel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISupports GetSecurityInfoAttribute();
		
		/// <summary>
        /// The MIME type of the channel's content if available.
        ///
        /// NOTE: the content type can often be wrongly specified (e.g., wrong file
        /// extension, wrong MIME type, wrong document type stored on a server, etc.),
        /// and the caller most likely wants to verify with the actual data.
        ///
        /// Setting contentType before the channel has been opened provides a hint
        /// to the channel as to what the MIME type is.  The channel may ignore this
        /// hint in deciding on the actual MIME type that it will report.
        ///
        /// Setting contentType after onStartRequest has been fired or after open()
        /// is called will override the type determined by the channel.
        ///
        /// Setting contentType between the time that asyncOpen() is called and the
        /// time when onStartRequest is fired has undefined behavior at this time.
        ///
        /// The value of the contentType attribute is a lowercase string.  A value
        /// assigned to this attribute will be parsed and normalized as follows:
        /// 1- any parameters (delimited with a ';') will be stripped.
        /// 2- if a charset parameter is given, then its value will replace the
        /// the contentCharset attribute of the channel.
        /// 3- the stripped contentType will be lowercased.
        /// Any implementation of nsIChannel must follow these rules.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentType);
		
		/// <summary>
        /// The MIME type of the channel's content if available.
        ///
        /// NOTE: the content type can often be wrongly specified (e.g., wrong file
        /// extension, wrong MIME type, wrong document type stored on a server, etc.),
        /// and the caller most likely wants to verify with the actual data.
        ///
        /// Setting contentType before the channel has been opened provides a hint
        /// to the channel as to what the MIME type is.  The channel may ignore this
        /// hint in deciding on the actual MIME type that it will report.
        ///
        /// Setting contentType after onStartRequest has been fired or after open()
        /// is called will override the type determined by the channel.
        ///
        /// Setting contentType between the time that asyncOpen() is called and the
        /// time when onStartRequest is fired has undefined behavior at this time.
        ///
        /// The value of the contentType attribute is a lowercase string.  A value
        /// assigned to this attribute will be parsed and normalized as follows:
        /// 1- any parameters (delimited with a ';') will be stripped.
        /// 2- if a charset parameter is given, then its value will replace the
        /// the contentCharset attribute of the channel.
        /// 3- the stripped contentType will be lowercased.
        /// Any implementation of nsIChannel must follow these rules.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentType);
		
		/// <summary>
        /// The character set of the channel's content if available and if applicable.
        /// This attribute only applies to textual data.
        ///
        /// The value of the contentCharset attribute is a mixedcase string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetContentCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentCharset);
		
		/// <summary>
        /// The character set of the channel's content if available and if applicable.
        /// This attribute only applies to textual data.
        ///
        /// The value of the contentCharset attribute is a mixedcase string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetContentCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentCharset);
		
		/// <summary>
        /// The length of the data associated with the channel if available.  A value
        /// of -1 indicates that the content length is unknown.
        ///
        /// Callers should prefer getting the "content-length" property
        /// as 64-bit value by QIing the channel to nsIPropertyBag2,
        /// if that interface is exposed by the channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetContentLengthAttribute();
		
		/// <summary>
        /// The length of the data associated with the channel if available.  A value
        /// of -1 indicates that the content length is unknown.
        ///
        /// Callers should prefer getting the "content-length" property
        /// as 64-bit value by QIing the channel to nsIPropertyBag2,
        /// if that interface is exposed by the channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetContentLengthAttribute(int aContentLength);
		
		/// <summary>
        /// Synchronously open the channel.
        ///
        /// @return blocking input stream to the channel's data.
        ///
        /// NOTE: nsIChannel implementations are not required to implement this
        /// method.  Moreover, since this method may block the calling thread, it
        /// should not be called on a thread that processes UI events.  Like any
        /// other nsIChannel method it must not be called on any thread other
        /// than the XPCOM main thread.
        ///
        /// NOTE: Implementations should throw NS_ERROR_IN_PROGRESS if the channel
        /// is reopened.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInputStream Open();
		
		/// <summary>
        /// Asynchronously open this channel.  Data is fed to the specified stream
        /// listener as it becomes available.  The stream listener's methods are
        /// called on the thread that calls asyncOpen and are not called until
        /// after asyncOpen returns.  If asyncOpen returns successfully, the
        /// channel promises to call at least onStartRequest and onStopRequest.
        ///
        /// If the nsIRequest object passed to the stream listener's methods is not
        /// this channel, an appropriate onChannelRedirect notification needs to be
        /// sent to the notification callbacks before onStartRequest is called.
        /// Once onStartRequest is called, all following method calls on aListener
        /// will get the request that was passed to onStartRequest.
        ///
        /// If the channel's and loadgroup's notification callbacks do not provide
        /// an nsIChannelEventSink when onChannelRedirect would be called, that's
        /// equivalent to having called onChannelRedirect.
        ///
        /// If asyncOpen returns successfully, the channel is responsible for
        /// keeping itself alive until it has called onStopRequest on aListener or
        /// called onChannelRedirect.
        ///
        /// Implementations are allowed to synchronously add themselves to the
        /// associated load group (if any).
        ///
        /// NOTE: Implementations should throw NS_ERROR_ALREADY_OPENED if the
        /// channel is reopened.
        ///
        /// @param aListener the nsIStreamListener implementation
        /// @param aContext an opaque parameter forwarded to aListener's methods
        /// @see nsIChannelEventSink for onChannelRedirect
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AsyncOpen([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Set/get the HTTP request method (default is "GET").  Setter is case
        /// insensitive; getter returns an uppercase string.
        ///
        /// This attribute may only be set before the channel is opened.
        ///
        /// NOTE: The data for a "POST" or "PUT" request can be configured via
        /// nsIUploadChannel; however, after setting the upload data, it may be
        /// necessary to set the request method explicitly.  The documentation
        /// for nsIUploadChannel has further details.
        ///
        /// @throws NS_ERROR_IN_PROGRESS if set after the channel has been opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRequestMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRequestMethod);
		
		/// <summary>
        /// Set/get the HTTP request method (default is "GET").  Setter is case
        /// insensitive; getter returns an uppercase string.
        ///
        /// This attribute may only be set before the channel is opened.
        ///
        /// NOTE: The data for a "POST" or "PUT" request can be configured via
        /// nsIUploadChannel; however, after setting the upload data, it may be
        /// necessary to set the request method explicitly.  The documentation
        /// for nsIUploadChannel has further details.
        ///
        /// @throws NS_ERROR_IN_PROGRESS if set after the channel has been opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRequestMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRequestMethod);
		
		/// <summary>
        /// Get/set the HTTP referrer URI.  This is the address (URI) of the
        /// resource from which this channel's URI was obtained (see RFC2616 section
        /// 14.36).
        ///
        /// This attribute may only be set before the channel is opened.
        ///
        /// NOTE: The channel may silently refuse to set the Referer header if the
        /// URI does not pass certain security checks (e.g., a "https://" URL will
        /// never be sent as the referrer for a plaintext HTTP request).  The
        /// implementation is not required to throw an exception when the referrer
        /// URI is rejected.
        ///
        /// @throws NS_ERROR_IN_PROGRESS if set after the channel has been opened.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetReferrerAttribute();
		
		/// <summary>
        /// Get/set the HTTP referrer URI.  This is the address (URI) of the
        /// resource from which this channel's URI was obtained (see RFC2616 section
        /// 14.36).
        ///
        /// This attribute may only be set before the channel is opened.
        ///
        /// NOTE: The channel may silently refuse to set the Referer header if the
        /// URI does not pass certain security checks (e.g., a "https://" URL will
        /// never be sent as the referrer for a plaintext HTTP request).  The
        /// implementation is not required to throw an exception when the referrer
        /// URI is rejected.
        ///
        /// @throws NS_ERROR_IN_PROGRESS if set after the channel has been opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReferrerAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer);
		
		/// <summary>
        /// Get the value of a particular request header.
        ///
        /// @param aHeader
        /// The case-insensitive name of the request header to query (e.g.,
        /// "Cache-Control").
        ///
        /// @return the value of the request header.
        /// @throws NS_ERROR_NOT_AVAILABLE if the header is not set.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetRequestHeader([MarshalAs(UnmanagedType.LPStruct)] nsAString aHeader);
		
		/// <summary>
        /// Set the value of a particular request header.
        ///
        /// This method allows, for example, the cookies module to add "Cookie"
        /// headers to the outgoing HTTP request.
        ///
        /// This method may only be called before the channel is opened.
        ///
        /// @param aHeader
        /// The case-insensitive name of the request header to set (e.g.,
        /// "Cookie").
        /// @param aValue
        /// The request header value to set (e.g., "X=1").
        /// @param aMerge
        /// If true, the new header value will be merged with any existing
        /// values for the specified header.  This flag is ignored if the
        /// specified header does not support merging (e.g., the "Content-
        /// Type" header can only have one value).  The list of headers for
        /// which this flag is ignored is an implementation detail.  If this
        /// flag is false, then the header value will be replaced with the
        /// contents of |aValue|.
        ///
        /// If aValue is empty and aMerge is false, the header will be cleared.
        ///
        /// @throws NS_ERROR_IN_PROGRESS if called after the channel has been
        /// opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRequestHeader([MarshalAs(UnmanagedType.LPStruct)] nsAString aHeader, [MarshalAs(UnmanagedType.LPStruct)] nsAString aValue, bool aMerge);
		
		/// <summary>
        /// Call this method to visit all request headers.  Calling setRequestHeader
        /// while visiting request headers has undefined behavior.  Don't do it!
        ///
        /// @param aVisitor
        /// the header visitor instance.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VisitRequestHeaders([MarshalAs(UnmanagedType.Interface)] nsIHttpHeaderVisitor aVisitor);
		
		/// <summary>
        /// This attribute is a hint to the channel to indicate whether or not
        /// the underlying HTTP transaction should be allowed to be pipelined
        /// with other transactions.  This should be set to FALSE, for example,
        /// if the application knows that the corresponding document is likely
        /// to be very large.
        ///
        /// This attribute is true by default, though other factors may prevent
        /// pipelining.
        ///
        /// This attribute may only be set before the channel is opened.
        ///
        /// @throws NS_ERROR_FAILURE if set after the channel has been opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowPipeliningAttribute();
		
		/// <summary>
        /// This attribute is a hint to the channel to indicate whether or not
        /// the underlying HTTP transaction should be allowed to be pipelined
        /// with other transactions.  This should be set to FALSE, for example,
        /// if the application knows that the corresponding document is likely
        /// to be very large.
        ///
        /// This attribute is true by default, though other factors may prevent
        /// pipelining.
        ///
        /// This attribute may only be set before the channel is opened.
        ///
        /// @throws NS_ERROR_FAILURE if set after the channel has been opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowPipeliningAttribute(bool aAllowPipelining);
		
		/// <summary>
        /// This attribute specifies the number of redirects this channel is allowed
        /// to make.  If zero, the channel will fail to redirect and will generate
        /// a NS_ERROR_REDIRECT_LOOP failure status.
        ///
        /// NOTE: An HTTP redirect results in a new channel being created.  If the
        /// new channel supports nsIHttpChannel, then it will be assigned a value
        /// to its |redirectionLimit| attribute one less than the value of the
        /// redirected channel's |redirectionLimit| attribute.  The initial value
        /// for this attribute may be a configurable preference (depending on the
        /// implementation).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRedirectionLimitAttribute();
		
		/// <summary>
        /// This attribute specifies the number of redirects this channel is allowed
        /// to make.  If zero, the channel will fail to redirect and will generate
        /// a NS_ERROR_REDIRECT_LOOP failure status.
        ///
        /// NOTE: An HTTP redirect results in a new channel being created.  If the
        /// new channel supports nsIHttpChannel, then it will be assigned a value
        /// to its |redirectionLimit| attribute one less than the value of the
        /// redirected channel's |redirectionLimit| attribute.  The initial value
        /// for this attribute may be a configurable preference (depending on the
        /// implementation).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRedirectionLimitAttribute(uint aRedirectionLimit);
		
		/// <summary>
        /// Get the HTTP response code (e.g., 200).
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE if called before the response
        /// has been received (before onStartRequest).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetResponseStatusAttribute();
		
		/// <summary>
        /// Get the HTTP response status text (e.g., "OK").
        ///
        /// NOTE: This returns the raw (possibly 8-bit) text from the server.  There
        /// are no assumptions made about the charset of the returned text.  You
        /// have been warned!
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE if called before the response
        /// has been received (before onStartRequest).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetResponseStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aResponseStatusText);
		
		/// <summary>
        /// Returns true if the HTTP response code indicates success.  The value of
        /// nsIRequest::status will be NS_OK even when processing a 404 response
        /// because a 404 response may include a message body that (in some cases)
        /// should be shown to the user.
        ///
        /// Use this attribute to distinguish server error pages from normal pages,
        /// instead of comparing the response status manually against the set of
        /// valid response codes, if that is required by your application.
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE if called before the response
        /// has been received (before onStartRequest).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRequestSucceededAttribute();
		
		/// <summary>
        /// Get the value of a particular response header.
        ///
        /// @param aHeader
        /// The case-insensitive name of the response header to query (e.g.,
        /// "Set-Cookie").
        ///
        /// @return the value of the response header.
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE if called before the response
        /// has been received (before onStartRequest) or if the header is
        /// not set in the response.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetResponseHeader([MarshalAs(UnmanagedType.LPStruct)] nsAString header);
		
		/// <summary>
        /// Set the value of a particular response header.
        ///
        /// This method allows, for example, the HTML content sink to inform the HTTP
        /// channel about HTTP-EQUIV headers found in HTML <META> tags.
        ///
        /// @param aHeader
        /// The case-insensitive name of the response header to set (e.g.,
        /// "Cache-control").
        /// @param aValue
        /// The response header value to set (e.g., "no-cache").
        /// @param aMerge
        /// If true, the new header value will be merged with any existing
        /// values for the specified header.  This flag is ignored if the
        /// specified header does not support merging (e.g., the "Content-
        /// Type" header can only have one value).  The list of headers for
        /// which this flag is ignored is an implementation detail.  If this
        /// flag is false, then the header value will be replaced with the
        /// contents of |aValue|.
        ///
        /// If aValue is empty and aMerge is false, the header will be cleared.
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE if called before the response
        /// has been received (before onStartRequest).
        /// @throws NS_ERROR_ILLEGAL_VALUE if changing the value of this response
        /// header is not allowed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetResponseHeader([MarshalAs(UnmanagedType.LPStruct)] nsAString header, [MarshalAs(UnmanagedType.LPStruct)] nsAString value, bool merge);
		
		/// <summary>
        /// Call this method to visit all response headers.  Calling
        /// setResponseHeader while visiting response headers has undefined
        /// behavior.  Don't do it!
        ///
        /// @param aVisitor
        /// the header visitor instance.
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE if called before the response
        /// has been received (before onStartRequest).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VisitResponseHeaders([MarshalAs(UnmanagedType.Interface)] nsIHttpHeaderVisitor aVisitor);
		
		/// <summary>
        /// Returns true if the server sent a "Cache-Control: no-store" response
        /// header.
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE if called before the response
        /// has been received (before onStartRequest).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsNoStoreResponse();
		
		/// <summary>
        /// Returns true if the server sent the equivalent of a "Cache-control:
        /// no-cache" response header.  Equivalent response headers include:
        /// "Pragma: no-cache", "Expires: 0", and "Expires" with a date value
        /// in the past relative to the value of the "Date" header.
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE if called before the response
        /// has been received (before onStartRequest).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsNoCacheResponse();
	}
}
