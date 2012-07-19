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
// Generated by IDLImporter from file nsIProgrammingLanguage.idl
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
    /// Enumeration of Programming Languages
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ea604e90-40ba-11d5-90bb-0010a4e73d9a")]
	public interface nsIProgrammingLanguage
	{
	}
	
	/// <summary>nsIProgrammingLanguageConsts </summary>
	public class nsIProgrammingLanguageConsts
	{
		
		// <summary>
        // Identifiers for programming languages.
        // </summary>
		public const long UNKNOWN = 0;
		
		// 
		public const long CPLUSPLUS = 1;
		
		// 
		public const long JAVASCRIPT = 2;
		
		// 
		public const long PYTHON = 3;
		
		// 
		public const long PERL = 4;
		
		// 
		public const long JAVA = 5;
		
		// 
		public const long ZX81_BASIC = 6;
		
		// <summary>
        // it could happen :)
        // </summary>
		public const long JAVASCRIPT2 = 7;
		
		// 
		public const long RUBY = 8;
		
		// 
		public const long PHP = 9;
		
		// 
		public const long TCL = 10;
		
		// <summary>
        // This list can grow indefinitely. Just don't ever change an existing item.
        // </summary>
		public const long MAX = 10;
	}
}
