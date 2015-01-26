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
// Generated by IDLImporter from file nsIMemoryInfoDumper.idl
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
	[Guid("2dea18fc-fbfa-4bf7-ad45-0efaf5495f5e")]
	public interface nsIFinishDumpingCallback
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Callback([MarshalAs(UnmanagedType.Interface)] nsISupports data);
	}
	
	/// <summary>nsIMemoryInfoDumper </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("815bf31b-f5bd-425d-85c3-4657a7a91dad")]
	public interface nsIMemoryInfoDumper
	{
		
		/// <summary>
        /// This dumps gzipped memory reports for this process and its child
        /// processes.  If a file of the given name exists, it will be overwritten.
        ///
        /// @param aFilename The output file.
        ///
        /// Sample output:
        ///
        /// {
        /// "hasMozMallocUsableSize":true,
        /// "reports": [
        /// {"process":"Main Process (pid 12345)", "path":"explicit/foo/bar",
        /// "kind":1, "units":0, "amount":2000000, "description":"Foo bar."},
        /// {"process":"Main Process (pid 12345)", "path":"heap-allocated",
        /// "kind":1, "units":0, "amount":3000000, "description":"Heap allocated."},
        /// {"process":"Main Process (pid 12345)", "path":"vsize",
        /// "kind":1, "units":0, "amount":10000000, "description":"Vsize."}
        /// ]
        /// }
        ///
        /// JSON schema for the output.
        ///
        /// {
        /// "properties": {
        /// "hasMozMallocUsableSize": {
        /// "type": "boolean",
        /// "description": "nsIMemoryReporterManager::hasMozMallocUsableSize",
        /// "required": true
        /// },
        /// "reports": {
        /// "type": "array",
        /// "description": "The memory reports.",
        /// "required": true
        /// "minItems": 1,
        /// "items": {
        /// "type": "object",
        /// "properties": {
        /// "process": {
        /// "type": "string",
        /// "description": "nsIMemoryReporter::process",
        /// "required": true
        /// },
        /// "path": {
        /// "type": "string",
        /// "description": "nsIMemoryReporter::path",
        /// "required": true,
        /// "minLength": 1
        /// },
        /// "kind": {
        /// "type": "integer",
        /// "description": "nsIMemoryReporter::kind",
        /// "required": true
        /// },
        /// "units": {
        /// "type": "integer",
        /// "description": "nsIMemoryReporter::units",
        /// "required": true
        /// },
        /// "amount": {
        /// "type": "integer",
        /// "description": "nsIMemoryReporter::amount",
        /// "required": true
        /// },
        /// "description": {
        /// "type": "string",
        /// "description": "nsIMemoryReporter::description",
        /// "required": true
        /// }
        /// }
        /// }
        /// }
        /// }
        /// }
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DumpMemoryReportsToNamedFile([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFilename, [MarshalAs(UnmanagedType.Interface)] nsIFinishDumpingCallback aFinishDumping, [MarshalAs(UnmanagedType.Interface)] nsISupports aFinishDumpingData);
		
		/// <summary>
        /// Similar to dumpMemoryReportsToNamedFile, this method dumps gzipped memory
        /// reports for this process and its child processes to files in the tmp
        /// directory called memory-reports-<identifier>-<pid>.json.gz (or something
        /// similar, such as memory-reports-<identifier>-<pid>-1.json.gz; no existing
        /// file will be overwritten).
        ///
        /// If DMD is enabled, this method also dumps gzipped DMD output to a file in
        /// the tmp directory called dmd-<identifier>-<pid>.txt.gz (or something
        /// similar; again, no existing file will be overwritten).
        ///
        /// @param aIdentifier this identifier will appear in the filename of our
        /// about:memory dump and those of our children.
        ///
        /// If the identifier is empty, the implementation may set it arbitrarily
        /// and use that new value for its own dump and the dumps of its child
        /// processes.  For example, the implementation may set |aIdentifier| to the
        /// number of seconds since the epoch.
        ///
        /// @param aMinimizeMemoryUsage indicates whether we should run a series of
        /// gc/cc's in an attempt to reduce our memory usage before collecting our
        /// memory report.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DumpMemoryInfoToTempDir([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIdentifier, [MarshalAs(UnmanagedType.U1)] bool aMinimizeMemoryUsage);
		
		/// <summary>
        /// Dump GC and CC logs to files in the OS's temp directory (or in
        /// $MOZ_CC_LOG_DIRECTORY, if that environment variable is specified).
        ///
        /// @param aIdentifier If aIdentifier is non-empty, this string will appear in
        /// the filenames of the logs we create (both for this process and, if
        /// aDumpChildProcesses is true, for our child processes).
        ///
        /// If aIdentifier is empty, the implementation may set it to an
        /// arbitrary value; for example, it may set aIdentifier to the number
        /// of seconds since the epoch.
        ///
        /// @param aDumpAllTraces indicates whether we should run an all-traces CC
        /// log.  An all-traces log visits all objects currently eligible for cycle
        /// collection, while a non-all-traces log avoids visiting some objects
        /// which we know are reachable.
        ///
        /// All-traces logs are much bigger than the alternative, but they may be
        /// helpful when trying to understand why a particular object is alive.  For
        /// example, a non-traces-log will skip references held by an active
        /// document; if your object is being held alive by such a document, you
        /// probably want to see those references.
        ///
        /// @param aDumpChildProcesses indicates whether we should call
        /// DumpGCAndCCLogsToFile in our child processes.  If so, the child processes
        /// will dump their children, and so on.
        ///
        /// @param aGCLogPath The full path of the file that the GC log was written to.
        ///
        /// @param aCCLogPath The full path of the file that the CC log was written to.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DumpGCAndCCLogsToFile([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIdentifier, [MarshalAs(UnmanagedType.U1)] bool aDumpAllTraces, [MarshalAs(UnmanagedType.U1)] bool aDumpChildProcesses, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aGCLogPath, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCCLogPath);
	}
}
