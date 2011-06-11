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
// Generated by IDLImporter from file nsIAsyncVerifyRedirectCallback.idl
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
	
	
	/// <summary>nsIAsyncVerifyRedirectCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8d171460-a716-41f1-92be-8c659db39b45")]
	public interface nsIAsyncVerifyRedirectCallback
	{
		
		/// <summary>
        /// Complement to nsIChannelEventSink asynchronous callback. The result of
        /// the redirect decision is passed through this callback.
        ///
        /// @param result
        /// Result of the redirect veto decision. If FAILED the redirect has been
        /// vetoed. If SUCCEEDED the redirect has been allowed by all consumers.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnRedirectVerifyCallback(System.Int32  result);
	}
}
