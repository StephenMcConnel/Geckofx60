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
// Generated by IDLImporter from file xpctest_returncode.idl
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
    /// Test the use of Components.returnCode
    ///
    /// This ("parent") interface defines a method that in-turn calls another
    /// ("child") interface implemented in JS, and returns the nsresult from that
    /// child interface.  The child interface manages the return code by way of
    /// Components.returnCode.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("479e4532-95cf-48b8-a99b-8a5881e47138")]
	public interface nsIXPCTestReturnCodeParent
	{
		
		/// <summary>
        /// the NSRESULT from the child interface.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CallChild(int childBehavior);
	}
	
	/// <summary>nsIXPCTestReturnCodeChild </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("672cfd34-1fd1-455d-9901-d879fa6fdb95")]
	public interface nsIXPCTestReturnCodeChild
	{
		
		/// <summary>Member DoIt </summary>
		/// <param name='behavior'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoIt(int behavior);
	}
	
	/// <summary>nsIXPCTestReturnCodeChildConsts </summary>
	public class nsIXPCTestReturnCodeChildConsts
	{
		
		// <summary>
        // child will throw a JS exception
        // </summary>
		public const long CHILD_SHOULD_THROW = 0;
		
		// <summary>
        // child will just return normally
        // </summary>
		public const long CHILD_SHOULD_RETURN_SUCCESS = 1;
		
		// <summary>
        // child will return after setting Components.returnCode to NS_ERROR_FAILURE
        // </summary>
		public const long CHILD_SHOULD_RETURN_RESULTCODE = 2;
		
		// <summary>
        // value set later by the "inner" child.
        // </summary>
		public const long CHILD_SHOULD_NEST_RESULTCODES = 3;
	}
}