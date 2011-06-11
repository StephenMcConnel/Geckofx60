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
// Generated by IDLImporter from file rdfISerializer.idl
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
    /// Interface used to serialize RDF.
    ///
    /// @status PLASMA
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f0edfcdd-8bca-4d32-9226-7421001396a4")]
	public interface rdfISerializer
	{
		
		/// <summary>
        /// Synchronously serialize the given datasource to the outputstream.
        ///
        /// Implementations are not required to implement any buffering or
        /// other stream-based optimizations.
        ///
        /// @param aDataSource The RDF data source to be serialized.
        /// @param aOut The output stream to use.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Serialize(rdfIDataSource  aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIOutputStream  aOut);
	}
}
