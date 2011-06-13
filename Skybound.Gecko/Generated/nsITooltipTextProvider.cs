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
// Generated by IDLImporter from file nsITooltipTextProvider.idl
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
    /// An interface implemented by a tooltip text provider service. This
    /// service is called to discover what tooltip text is associated
    /// with the node that the pointer is positioned over.
    ///
    /// Embedders may implement and register their own tooltip text provider
    /// service if they wish to provide different tooltip text.
    ///
    /// The default service returns the text stored in the TITLE
    /// attribute of the node or a containing parent.
    ///
    /// @note
    /// The tooltip text provider service is registered with the contract
    /// defined in NS_TOOLTIPTEXTPROVIDER_CONTRACTID.
    ///
    /// @see nsITooltipListener
    /// @see nsIComponentManager
    /// @see nsIDOMNode
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b128a1e6-44f3-4331-8fbe-5af360ff21ee")]
	public interface nsITooltipTextProvider
	{
		
		/// <summary>
        /// Called to obtain the tooltip text for a node.
        ///
        /// @arg aNode The node to obtain the text from.
        /// @arg aText The tooltip text.
        ///
        /// @return <CODE>PR_TRUE</CODE> if tooltip text is associated
        /// with the node and was returned in the aText argument;
        /// <CODE>PR_FALSE</CODE> otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetNodeText([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] out string aText);
	}
}
