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
// Generated by IDLImporter from file nsIRDFXMLSink.idl
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
    /// An observer that is notified as progress is made on the load
    /// of an RDF/XML document in an <code>nsIRDFXMLSink</code>.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("EB1A5D30-AB33-11D2-8EC6-00805F29F370")]
	public interface nsIRDFXMLSinkObserver
	{
		
		/// <summary>
        /// Called when the load begins.
        /// @param aSink the RDF/XML sink on which the load is beginning.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnBeginLoad([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSink aSink);
		
		/// <summary>
        /// Called when the load is suspended (e.g., for network quantization).
        /// @param aSink the RDF/XML sink that is being interrupted.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnInterrupt([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSink aSink);
		
		/// <summary>
        /// Called when a suspended load is resuming.
        /// @param aSink the RDF/XML sink that is resuming.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnResume([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSink aSink);
		
		/// <summary>
        /// Called when an RDF/XML load completes successfully.
        /// @param aSink the RDF/XML sink that has finished loading.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnEndLoad([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSink aSink);
		
		/// <summary>
        /// Called when an error occurs during the load
        /// @param aSink the RDF/XML sink in which the error occurred
        /// @param aStatus the networking result code
        /// @param aErrorMsg an error message, if applicable
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnError([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSink aSink, int aStatus, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aErrorMsg);
	}
	
	/// <summary>
    /// A "sink" that receives and processes RDF/XML. This interface is used
    /// by the RDF/XML parser.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("EB1A5D31-AB33-11D2-8EC6-00805F29F370")]
	public interface nsIRDFXMLSink
	{
		
		/// <summary>
        /// Set to <code>true</code> if the sink is read-only and cannot
        /// be modified
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetReadOnlyAttribute();
		
		/// <summary>
        /// Set to <code>true</code> if the sink is read-only and cannot
        /// be modified
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReadOnlyAttribute(bool aReadOnly);
		
		/// <summary>
        /// Initiate the RDF/XML load.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginLoad();
		
		/// <summary>
        /// Suspend the RDF/XML load.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Interrupt();
		
		/// <summary>
        /// Resume the RDF/XML load.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Resume();
		
		/// <summary>
        /// Complete the RDF/XML load.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndLoad();
		
		/// <summary>
        /// Add namespace information to the RDF/XML sink.
        /// @param aPrefix the namespace prefix
        /// @param aURI the namespace URI
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddNameSpace(System.IntPtr aPrefix, System.IntPtr aURI);
		
		/// <summary>
        /// Add an observer that will be notified as the RDF/XML load
        /// progresses.
        /// <p>
        ///
        /// Note that the sink will acquire a strong reference to the
        /// observer, so care should be taken to avoid cyclical references
        /// that cannot be released (i.e., if the observer holds a
        /// reference to the sink, it should be sure that it eventually
        /// clears the reference).
        ///
        /// @param aObserver the observer to add to the sink's set of
        /// load observers.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddXMLSinkObserver([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSinkObserver aObserver);
		
		/// <summary>
        /// Remove an observer from the sink's set of observers.
        /// @param aObserver the observer to remove.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveXMLSinkObserver([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSinkObserver aObserver);
	}
}
