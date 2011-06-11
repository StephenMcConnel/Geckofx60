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
// Generated by IDLImporter from file nsIZipReader.idl
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
	
	
	/// <summary>nsIZipEntry </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e1c028bc-c478-11da-95a8-00e08161165f")]
	public interface nsIZipEntry
	{
		
		/// <summary>
        /// The type of compression used for the item.  The possible values and
        /// their meanings are defined in the zip file specification at
        /// http://www.pkware.com/business_and_developers/developer/appnote/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetCompressionAttribute();
		
		/// <summary>
        /// The compressed size of the data in the item.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetSizeAttribute();
		
		/// <summary>
        /// The uncompressed size of the data in the item.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetRealSizeAttribute();
		
		/// <summary>
        /// The CRC-32 hash of the file in the entry.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetCRC32Attribute();
		
		/// <summary>
        /// True if the name of the entry ends with '/' and false otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsDirectoryAttribute();
		
		/// <summary>
        /// The time at which this item was last modified.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetLastModifiedTimeAttribute();
		
		/// <summary>
        /// Use this attribute to determine whether this item is an actual zip entry
        /// or is one synthesized for part of a real entry's path.  A synthesized
        /// entry represents a directory within the zip file which has no
        /// corresponding entry within the zip file.  For example, the entry for the
        /// directory foo/ in a zip containing exactly one entry for foo/bar.txt
        /// is synthetic.  If the zip file contains an actual entry for a directory,
        /// this attribute will be false for the nsIZipEntry for that directory.
        /// It is impossible for a file to be synthetic.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsSyntheticAttribute();
	}
	
	/// <summary>nsIZipReader </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7bb925d6-833a-486c-8ef2-9bc15c670a60")]
	public interface nsIZipReader
	{
		
		/// <summary>
        /// Opens a zip file for reading.
        /// It is allowed to open with another file,
        /// but it needs to be closed first with close().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Open([MarshalAs(UnmanagedType.Interface)] nsIFile  zipFile);
		
		/// <summary>
        /// Opens a zip file inside a zip file for reading.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenInner([MarshalAs(UnmanagedType.Interface)] nsIZipReader  zipReader, [MarshalAs(UnmanagedType.LPStr)] System.String  zipEntry);
		
		/// <summary>
        /// The file that represents the zip with which this zip reader was
        /// initialized.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile  GetFileAttribute();
		
		/// <summary>
        /// Closes a zip reader. Subsequent attempts to extract files or read from
        /// its input stream will result in an error.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		/// <summary>
        /// Tests the integrity of the archive by performing a CRC check
        /// on each item expanded into memory.  If an entry is specified
        /// the integrity of only that item is tested.  If NULL is passed
        /// in the integrity of all items in the archive are tested.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Test([MarshalAs(UnmanagedType.LPStr)] System.String  aEntryName);
		
		/// <summary>
        /// Extracts a zip entry into a local file specified by outFile.
        /// The entry must be stored in the zip in either uncompressed or
        /// DEFLATE-compressed format for the extraction to be successful.
        /// If the entry is a directory, the directory will be extracted
        /// non-recursively.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Extract([MarshalAs(UnmanagedType.LPStr)] System.String  zipEntry, [MarshalAs(UnmanagedType.Interface)] nsIFile  outFile);
		
		/// <summary>
        /// Returns a nsIZipEntry describing a specified zip entry.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIZipEntry GetEntry([MarshalAs(UnmanagedType.LPStr)] System.String  zipEntry);
		
		/// <summary>
        /// Checks whether the zipfile contains an entry specified by entryName.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasEntry([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  zipEntry);
		
		/// <summary>
        /// Returns a string enumerator containing the matching entry names.
        ///
        /// @param aPattern
        /// A regular expression used to find matching entries in the zip file.
        /// Set this parameter to null to get all entries; otherwise, use the
        /// following syntax:
        ///
        /// o * matches anything
        /// o ? matches one character
        /// o $ matches the end of the string
        /// o [abc] matches one occurrence of a, b, or c. The only character that
        /// must be escaped inside the brackets is ].  ^ and - must never
        /// appear in the first and second positions within the brackets,
        /// respectively.  (In the former case, the behavior specified for
        /// '[^az]' will happen.)
        /// o [a-z] matches any character between a and z.  The characters a and z
        /// must either both be letters or both be numbers, with the
        /// character represented by 'a' having a lower ASCII value than
        /// the character represented by 'z'.
        /// o [^az] matches any character except a or z.  If ] is to appear inside
        /// the brackets as a character to not match, it must be escaped.
        /// o pat~pat2 returns matches to the pattern 'pat' which do not also match
        /// the pattern 'pat2'.  This may be used to perform filtering
        /// upon the results of one pattern to remove all matches which
        /// also match another pattern.  For example, because '*'
        /// matches any string and '*z*' matches any string containing a
        /// 'z', '*~*z*' will match all strings except those containing
        /// a 'z'.  Note that a pattern may not use '~' multiple times,
        /// so a string such as '*~*z*~*y*' is not a valid pattern.
        /// o (foo|bar) will match either the pattern foo or the pattern bar.
        /// Neither of the patterns foo or bar may use the 'pat~pat2'
        /// syntax described immediately above.
        /// o \ will escape a special character.  Escaping is required for all
        /// special characters unless otherwise specified.
        /// o All other characters match case-sensitively.
        ///
        /// An aPattern not conforming to this syntax has undefined behavior.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE on many but not all invalid aPattern
        /// values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUTF8StringEnumerator FindEntries([MarshalAs(UnmanagedType.LPStr)] System.String  aPattern);
		
		/// <summary>
        /// Returns an input stream containing the contents of the specified zip
        /// entry.
        /// @param zipEntry the name of the entry to open the stream from
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream GetInputStream([MarshalAs(UnmanagedType.LPStr)] System.String  zipEntry);
		
		/// <summary>
        /// Returns an input stream containing the contents of the specified zip
        /// entry. If the entry refers to a directory (ends with '/'), a directory stream
        /// is opened, otherwise the contents of the file entry is returned.
        /// @param aJarSpec the Spec of the URI for the JAR (only used for directory streams)
        /// @param zipEntry the name of the entry to open the stream from
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream GetInputStreamWithSpec([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aJarSpec, [MarshalAs(UnmanagedType.LPStr)] System.String  zipEntry);
		
		/// <summary>
        /// Returns an object describing the entity which signed
        /// an entry. parseManifest must be called first. If aEntryName is an
        /// entry in the jar, getInputStream must be called after parseManifest.
        /// If aEntryName is an external file which has meta-information
        /// stored in the jar, verifyExternalFile (not yet implemented) must
        /// be called before getPrincipal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetCertificatePrincipal([MarshalAs(UnmanagedType.LPStr)] System.String  aEntryName);
		
		/// <summary>Member GetManifestEntriesCountAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetManifestEntriesCountAttribute();
	}
	
	/// <summary>
    /// nsIZipReaderCache
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("52c45d86-0cc3-11d4-986e-00c04fa0cf4a")]
	public interface nsIZipReaderCache
	{
		
		/// <summary>
        /// Initializes a new zip reader cache.
        /// @param cacheSize - the number of released entries to maintain before
        /// beginning to throw some out (note that the number of outstanding
        /// entries can be much greater than this number -- this is the count
        /// for those otherwise unused entries)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init(System.UInt32  cacheSize);
		
		/// <summary>
        /// Returns a (possibly shared) nsIZipReader for an nsIFile.
        ///
        /// If the zip reader for given file is not in the cache, a new zip reader
        /// is created, initialized, and opened (see nsIZipReader::init and
        /// nsIZipReader::open). Otherwise the previously created zip reader is
        /// returned.
        ///
        /// @note If someone called close() on the shared nsIZipReader, this method
        /// will return the closed zip reader.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIZipReader GetZip([MarshalAs(UnmanagedType.Interface)] nsIFile  zipFile);
		
		/// <summary>
        /// Returns a (possibly shared) nsIZipReader for a zip inside another zip
        ///
        /// See getZip
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIZipReader GetInnerZip([MarshalAs(UnmanagedType.Interface)] nsIFile  zipFile, [MarshalAs(UnmanagedType.LPStr)] System.String  zipEntry);
	}
}
