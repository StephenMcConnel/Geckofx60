Geckofx is licensed under the Mozilla Public License Version.

== Changelog ==

== v18.0-0.2 ==

1. Small bug fix release.

== v18.0-0.1 ==

1. Initial version supporting firefox/xulrunner v18.0

== v16.0-0.2 ==

1. New ReadyStateChanged event. Usefull for telling when a document has completly loaded.
2. Memory leak fixes.

== v16.0-0.1 ==

1. Initial version supporting firefox/xulrunner v16.0

== v15.0-0.2 ==

1. Fix #1 : HTML5 video and audio still non-functional - https://bitbucket.org/geckofx/geckofx-15.0/issue/1
2. Fix #4 - CreateJSContext puts an error in the console
3. Fix #7 - GeckoWebBrowser.GetMarkupDocumentViewer() throws Access Violation on subsequent calls

== v15.0-0.1 ==

1. Initial version supporting firefox/xulrunner v15.0

== v14.0-0.2 ==

1. Numerious bug fixes.
2. Lots of improvements to the Linux build, including 64bit Linux.

== v14.0-0.1 ==

1. Initial version supporting firefox/xulrunner v14.0
2. Geckofx has been split into two dlls.
* Geckofx-Core.dll 
* Geckofx-Winfoms.dll 
3. Improvements to the Linux build process.
4. Enhance GeckoHtmlElement wrapper.
5. GeckoWebBrowser Naviagate method now automatically creates initlaizes Geckofx if needed.

== v13.0-0.1 ==

1. Initial version supporting firefox/xulrunner v13.0

== v12.0-0.3 ==

1. Improve WindowWatcher service
2. Rename missnamed propertie from Frames to Forms.
3. Improve GeckoTextAreaElement wrapper.
4. Added Request Data (for POST/PUT) to GeckoObserveHttpModifyRequestEvent
5. Renamed GeckoNode.Type to GeckoNode.NodeType
6. Fix GeckoWebBrowser memory leak.
7. Rename GetElementById to GetHtmlElementById
8. Add GetElementById that returns a GeckoDomElement
9. Remove version from ProfileDirectory default path and make path cross platform.

== v12.0-0.2 ==

1. Added Cryptography classes.
2. Calling Convention fixes. (stops .net 4.0 error messages)
3. Added wrappers for HttpActivityDistributor,ImgContainer,DomNavigator.
4. Fixed release builds.
5. Added WindowWatcher service wrapper.
6. Add WindowUtils wrapper for nsIDOMWindowUtils
7. Generated interfaces now contain numeric constants defintions. 
8. Added Head Property to GeckoDocument.
9. Added OnRedirecting event to GeckoWebBrowser.
10. Changed AppShellService visibilty to public.
11. Fixed Dispose crash when disposing non shown GeckoWebBrowser instances.

== v12.0-0.1 ==

1. Initial version supporting firefox/xulrunner v12.0
2. Improved JsVal support.

== v11.0-0.3 ==

1. Some work to make geckofx more stable.
2. Fixes crashes on mono caused by broken Marshal.GetObjectForUInknown on mono.
3. Add SelectionStart and Selection End Properties to GeckoInputElement
4. Make GeckoDocument.Body return GeckoElement type not GeckoBodyElement type.

== v11.0-0.2 ==

1. changes from v10.0-0.4 + v10.0-0.5 imported into v11 repo.

== v11.0-0.1 ==

1. Initial version supporting firefox/xulrunner v11.0

== v10.0-0.6 ==

1. More fixes to improve GeckoFx stability.

== v10.0-0.5 ==

1. Numerious fixes to improve Geckofx stability.
2. Added wrappers for XulRuntime WindowMediator WiFiMonitor ExceptionService ScreenManager RandomGenerator

== v10.0-0.4 ==

1. Fix infrequent Linux seg fault when calling SetInputFocus()
2. wrappers for nsIPipe, nsIObserverService, nsIStreamListenerTee, nsIRequestObserver, nsIStorageStream, nsIInputStreamTee, nsIVersionComparer, nsIConsoleService. provided by zloyprotoss
3. Add some aditional stream implementations.  provided by zloyprotoss
4. public Event delegates renamed:
  GeckoNavigatedEventHandler  -> EventHandler<GeckoNavigatedEventArgs>
  GeckoNavigatingEventHandler -> EventHandler<GeckoNavigatingEventArgs>

== v10.0-0.3 ==

1. Make Custom Prompts Service runtime switchable. (currently defaulting to off)
2. Allow Custom Prompt Service to be customized, with out modifiying geckofx.
3. Lots more wrappers provided by zloyprotoss

== v10.0-0.2 ==

1. Memory corruption fixes when ns*String class was used in callbacks.
2. Optional HttpActivityOberver provided by Romi Kuntsman
3. Added DomBlur event handler
4. basic plugin control + PrivateBrowsingService  provided by zloyprotoss
5. GetPngImage method provided by zloyprotoss
6. Linux fixes.

== v10.0-0.1 ==

1. Initial version supporting firefox/xulrunner v10.0

Note: Applications using geckofx must now include the following in there app.manifest
to prevent R6034 errors:

<dependency>
    <dependentAssembly>
      <assemblyIdentity type="win32" name="Microsoft.VC80.CRT" version="8.0.50727.762" processorArchitecture="x86" publicKeyToken="1fc8b3b9a1e18e3b"></assemblyIdentity>
    </dependentAssembly>
  </dependency>

== v9.0-0.5 ==

Linux only release.
1. Add geckofx config files to deal firefox platform differences.
2. Change X11 to libX11 pinvoke dll name match mono.
3. Make NAvigateFinishedNotifier more robust.

== v9.0-0.4 ==

zloyprotoss:
1. fixed  default prompt service. 
2. Added Cache related wrappers.
3. Added CategoryManager wrapper.
4. Added nsURI.Create(string) method.
5. Added Certificates related wrappers.

== V9.0-0.3 ==

Bug fixes

1. Fix bug in method GeckoWebBrowser.GetBitmap.
2. Various Linux improvements.

== v9.0-0.2 ==

Bug fixes

1. Make NaviagateFinshedNotifier disposable.
2. Setting GeckoElement.Id and GeckoElement.ClassName to String.Empty 
or null should now remove the attribute.

Added Features

1. Add GeckoSelection.ScrollIntoView method
2. Add AutoJSContext.EvaluateScript method which allows executing of 
javascript without using Navigate("javascript:").

== v9.0-0.1 ==

1. Initial version supporting firefox/xulrunner v9.0
2. Namespaces renamed from Skybound.Gecko to Gecko.
3. GeckoFx Dll renamed to include Major version number. 
	Skybound.Gecko.dll  -> geckofx-9.dll
4. Generated interfaces now correctly handle implicit_jscontext attribute.

== v8.0-0.9 ==

Bug fixes

1. Only enable Console Message notification when an event handler is attached.

Added Features

1. Added nsIEditor property to GeckoWebbrowser
2. Added StartBatchChanges +  EndBatchChanges to GeckoSelection.

== v8.0-0.8 ==

Bug fixes

1. Make SaveDocument more robust.
2. Only enable Javascript debugger if event handler is attached to the relevant event.

Added Features
1. new GeckoWebBrowser.AddMessageEventListener allows listening for custom javascript MessageEvents.
2. Add "Open In System Browser" option to the default context menu.

== v8.0-0.7 ==

Bug fixes

1. GeckoElement.OuterHtml property, was quoting attributes.
3. GetBitmap using wrong width when not using origin.
4. Fix some issues with flash plugings. (Thanks shcherba)
5. Loading pages without a body, could throw exception.

Added Features

1. Added DomContentChanged event.
2. Addws JavascriptError event
3. Addws ConsoleMessage event.

== v8.0-0.6 ==

1. Fix GetBitmap method to work with Invisiable windows.
2. Add PrintSettings class which implements nsIPrintSettings.

== v8.0-0.5 ==

1. Add a GetBitmap method to GeckoWebBrowser which replaces the Control.DrawToBitmap method that used to work in old versions of gecko.

== v8.0-0.4 ==

1. Added NavigateFinishedNotifier.NavigateFinished so that its easy to tell when a Navigation has completely finished.

== v8.0-0.3 ==

1. Add MarkupDocumentViewer wrapper (allows setting FullZoom + lots of other options)

== v8.0-0.2 ==

1. Add DomDoubleClick + GetData Extenstion method (Sent by Salaros)
2. Improve Generated files to handle array better. Fixes bug https://bitbucket.org/geckofx/geckofx-7.0/issue/7
3. Disable GeckoWrapperCache by default.

== v8.0-0.1 ==

1. Initial version supporting xulrunner v8.0

== v7.0-0.1 ==

1. Initial version supporting xulrunner v7.0

== v6.0-0.3 ==

1. Fix bug https://bitbucket.org/geckofx/geckofx-6.0/issue/4 by changing
idl out params to ref (from out).

== v6.0-0.2 ==

Include changes from geckofx-5.0:
1. Add Axis property to GeckoDomMouseEventArgs. (Thanks Priyank)
2. Add GeckoComment class.
3. Add NodeType Enum.
4. Fix mapping of ACString in Generated interfaces.
5. Lots of Optimizations including weakreferences caching. This is enabled by default, to disable: GeckoWrapperCache.Enabled = false;
6. Fix some bugs displaying the default context menu.
7. Add methods ScrollTo, ScrollBy, ScrollByLines, ScrollByPages, and SizeToContent to GeckoWindow.


== v6.0-0.1 ==

1. Initial version supporting xulrunner v6.0

== v5.0-0.5 ==

Bug fixes
=========

1. Fix bugs in GeckoSelection
2. fix bug in GeckoWebBrowser nsIEmbeddingSiteWindow2.SetDimensions (Thanks zloyprotoss)
3. Fix bug in generated xulrunner interfaces where double was being used instead of float. (Thanks Priyank)

Added Features
=============

1. Expose GeckoSelection.RemoveAllRanges and GeckoSelection.DeleteFromDocument
2. GeckoNode got the new properties: Type, ParentNode, ParentElement
3. GeckoSelection got the new properties: BoundingClientRect, ClientRects
4. GeckoElement got the new property: BoundingClientRect
5. GeckoDocument got the new property: CreateTextNode
6. GeckoWebBrowser got the new event: Load

== v5.0-0.4 ==

1. Improve OuterHtml values.
2. Performance optimization.
3. Fix GeckoRange.ToString method.
4. Add ContentEditable, Blur, Focus and Click to GeckoElement
5. Add PreventDefault and StopPropagation to GeckoDomEventsArgs
6. Found and deleted some remaining handwritten Xulrunner interfaces.
7. Add LoadHtml(string) function that loads page based upon a string.
8. Fix bug where InvalidCastException was being thrown when clicking on certain links.
9. Disallow GeckoSelection represting a null selection.

== v5.0-0.3 ==

Import changes from geckofx-2.0:

Patch from zloyprotoss that:

1. Optimizes WStringMarshaler
2. Makes DOM GeckoElements actually be their Gecko DOM type.

== v5.0-0.2 ==

Import changes from geckofx-2.0:

1. Add GetNodes(xpath), GetElements(xpath) to GeckoDom.
2. Fix Bug where GeckoSelection object was not being updated.
3. Improved Naviagte support specifying for POST headers.
4. Exposed NS_ShutdownXPCOM.
5. Rewrite much of AutoJSContext to prevent crashing with FF 4 and newer.
6. Add HasAttribute method to GeckoElement.
7. Add very basic OuterHtml property to GeckoElement.
8. Fix bug which was causing Links to have wrong cursor.

== v5.0-0.1 ==

1. Initial version supporting xulrunner v5.0

== v2.0.1-0.10 ==

Patch from zloyprotoss that:

1. Optimizes WStringMarshaler
2. Makes DOM GeckoElements actually be their Gecko DOM type.

== v2.0.1-0.9 ==

1. Fix bug which was causing Links to have wrong cursor.

== v2.0.1-0.8 ==

1. Rewrite much of AutoJSContext to prevent crashing with FF 4 and newer.
2. Add HasAttribute method to GeckoElement.
3. Add very basic OuterHtml property to GeckoElement.

== v2.0.1-0.7 ==

1. Add GetNodes(xpath), GetElements(xpath) to GeckoDom.
2. Fix Bug where GeckoSelection object was not being updated.
3. Improved Naviagte support specifying for POST headers.
4. Exposed NS_ShutdownXPCOM.

== v2.0.1-0.6 ==

1. Fix issue with LPStruct marshaled nsAString return types. Fixes https://bitbucket.org/geckofx/geckofx-2.0/issue/15

== v2.0.1-0.5 ==

1. Rename namespace Skybound.Gecko.XpCom to Skybound.Gecko.CustomMarshalers to prevent VB name clash.

== v2.0.1-0.4 ==

1. bool types, in Generated Files, now have the MarshalAs(UnmanagedType.Bool) attribute applied.

== v2.0.1-0.3 ==

1. Generated Files now contain correct License block.
2. Generated Files now contain method and interface comments imported directly from 
   the IDL files.
3. Fix bug where some return parameter types were missing there Marshing attributes.

== v2.0.1-0.2 ==

1. Fix bug where some UTF8 strings were being treated as UTF16.

== v2.0.1-0.1 ==

1. Initial version supporting xulrunner v2.0.1.
2. All interfaces are direcly generated from the xulrunner idl files.

