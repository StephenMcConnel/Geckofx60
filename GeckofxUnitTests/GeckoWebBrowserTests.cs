using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Gecko.DOM;
using Gecko.Events;
using Gecko.JQuery;
using GeckofxUnitTests.ExtensionMethods;

namespace GeckofxUnitTests
{
    [TestFixture]
    internal class GeckoWebBrowserTests
    {
        private GeckoWebBrowser _browser;
        private Form _form;

        [SetUp]
        public void BeforeEachTestSetup()
        {
            Xpcom.Initialize(XpComTests.XulRunnerLocation);
            //affecting browser.Realod()/GoForward()/GoBackward() of error page
            GeckoPreferences.User["browser.xul.error_pages.enabled"] = true;
            _form = new Form();
            
            _browser = new GeckoWebBrowser();
            _browser.Dock = DockStyle.Fill;
            _form.Controls.Add(_browser);
            _form.Show();
        }

        [TearDown]
        public void AfterEachTestTearDown()
        {
            _browser.Dispose();
        }


        public static string errorMessage = null;

        private class TestGeckoWebBrowser : GeckoWebBrowser
        {
            protected override void Dispose(bool disposing)
            {
                if (disposing == false)
                {
                    var currentThread = System.Threading.Thread.CurrentThread;
                    errorMessage = String.Format("Disposed called by GC {0} {1}", currentThread.ManagedThreadId, currentThread.ApartmentState);
                    Console.WriteLine(errorMessage);
                }

                base.Dispose(disposing);
            }
        }

        [Test]
        public void MissingDisposeTest_ControlIsNotYetCreated_DoesNotThrowExceptions()
        {
            WeakReference reference = null;
            new Action(() =>
            {
                var nonDisposedBrowser = new TestGeckoWebBrowser();

                reference = new WeakReference(nonDisposedBrowser, true);
            })();

            for (var i = 5; i >= 0; i--)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            Assert.IsNull(reference.Target, "Weak ref hasn't been released rendering this test meaningless");
            Assert.IsTrue(errorMessage.Contains("Disposed called by"));
        }

        [Test]
        public void LoadHtml_SomeSimpleHtml_HtmlIsLoadedAndAccessableAfterNavigationFinished()
        {
            string innerHtml = "<div id=\"_lv5\">old value</div>";

            _browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

                             + "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

                             + "<body>" + innerHtml + "</body></html>");

            _browser.NavigateFinishedNotifier.NavigateFinished += (sender, e) =>
                                                                     {
                                                                         Assert.AreEqual(innerHtml, _browser.Document.Body.InnerHtml);
                                                                     };

            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();


            Assert.AreEqual(innerHtml, _browser.Document.Body.InnerHtml);
        }

        [Test]
        public void LoadHtmlInUrl_SomeSimpleHtml_HtmlIsLoadedAndAccessableAfterNavigationFinished()
        {
            string innerHtml = "<div id=\"_lv5\">old value</div>";
            string url = "http://mydomain.myzone/";

            _browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

                             + "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

                             + "<body>" + innerHtml + "</body></html>", url);

            _browser.NavigateFinishedNotifier.NavigateFinished += (sender, e) =>
            {
                Assert.AreEqual(innerHtml, _browser.Document.Body.InnerHtml);
            };

            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.AreEqual(innerHtml, _browser.Document.Body.InnerHtml);

            Assert.AreEqual(url, _browser.Url.AbsoluteUri);
        }

        public class TestCallback : nsITextInputProcessorCallback
        {
            public bool OnNotify(nsITextInputProcessor aTextInputProcessor, nsITextInputProcessorNotification aNotification)
            {
                Console.WriteLine("TestCallback:OnNotify");
                return true;
            }
        }

        [Test]
        public void DomContentChanged_ChangeContentOfTextInputWithKeyPressAndMoveToSecondInput_DomContentChangedShouldFire()
        {
            string html = "<input id=\"one\" type=\"text\" value=\"hello\" /><input id=\"two\" type=\"text\"  value=\"world\" />";
            _browser.TestLoadHtml(html);

            // Place browser on a form and show it. This is need to make the gecko accept the key press.
            Form f = new Form();
            f.Controls.Add(_browser);
            _browser.Visible = true;
            f.Show();

            // Focus first input box
            _browser.Document.GetHtmlElementById("one").Focus();
            GeckoRange range = _browser.Document.CreateRange();
            range.SelectNode(_browser.Document.GetHtmlElementById("one"));
            _browser.Window.Selection.AddRange(range);

            // record if DomContentChanged event happened.
            bool contentChangedEventReceived = false;
            _browser.DomContentChanged += (sender, e) => contentChangedEventReceived = true;


            // Modify first input by sending a keypress.
            // This could be refactored but at least it shows how to invoke a keypress using nsITextInputProcessor
            var instance = Xpcom.CreateInstance<nsITextInputProcessor>("@mozilla.org/text-input-processor;1");
            using (var context = new AutoJSContext(_browser.Window))
            {
                var result = context.EvaluateScript(
                    @"new KeyboardEvent('', { key: 'a', code: 'KeyA', keyCode: KeyboardEvent.DOM_VK_A });");
                instance.BeginInputTransaction((mozIDOMWindow) _browser.Document.DefaultView.DomWindow, new TestCallback());
                nsString.Set(instance.SetPendingCompositionString, "hi");
                instance.Keyup((nsIDOMEvent)result.ToComObject(context.ContextPointer), 0, 1);
                result = context.EvaluateScript(
                    @"new KeyboardEvent('', { key: 'Enter', code: 'Enter' });");
                instance.FlushPendingComposition(null, 0, 2);
                instance.CommitComposition((nsIDOMEvent)result.ToComObject(context.ContextPointer), 0, 2);
            }

            // DomContentChanged Event should fire when we move we move to next element.
            _browser.Document.GetHtmlElementById("two").Focus();
            range.SelectNode(_browser.Document.GetHtmlElementById("two"));
            _browser.Window.Selection.RemoveAllRanges();
            _browser.Window.Selection.AddRange(range);

            Assert.IsTrue(contentChangedEventReceived);
        }

        [Test]
        public void LoadFrameset_RegressionTest_ShouldNotThrowException()
        {
            string innerHtml = "<frame src=\"www.google.com\">";
            _browser.TestLoadFrameset(innerHtml);
            var frame = _browser.Document.GetElementsByTagName("frame")[0] as GeckoFrameElement;
            Assert.NotNull(frame);
            Assert.NotNull(frame.ContentWindow);
        }

        [Test]
        public void Editor_LoadedReadonlyocument_ReturnsNull()
        {
            _browser.TestLoadHtml("hello world.");
            Assert.Null(_browser.Editor);
        }

        [Test]
        public void Editor_LoadedEditableDocument_ReturnsNonNull()
        {
            _browser.TestLoadEditableHtml("hello world.");
            Assert.NotNull(_browser.Editor);
        }

        [Ignore("JavascriptError need refactoring to the new system (in gecko 33+)")]
        [Platform("Win")]
        [Test]
        public void JavascriptError_NaviagateWithSomeJavascriptThatThrowsException_AttachedEventHandlerShouldExecute()
        {
            List<JavascriptErrorEventArgs> errorEventArgs = new List<JavascriptErrorEventArgs>();

#if PORT
			browser.JavascriptError += (object sender, JavascriptErrorEventArgs e) => errorEventArgs.Add(e);
#endif

            _browser.Navigate("javascript:someRandomFunctionNameThatDoesNotExist(\"2\");");

            Application.DoEvents();

            Assert.AreEqual(2, errorEventArgs.Count);
            Assert.AreEqual("someRandomFunctionNameThatDoesNotExist is not defined", errorEventArgs[0].Message);
            Assert.AreEqual("ReferenceError: someRandomFunctionNameThatDoesNotExist is not defined", errorEventArgs[1].Message);

            Assert.AreEqual(1, errorEventArgs[0].ErrorNumber);
            Assert.AreEqual(1, errorEventArgs[1].ErrorNumber);

            Assert.AreEqual(1, errorEventArgs[0].Line);
            Assert.AreEqual(1, errorEventArgs[1].Line);

            Assert.AreEqual("javascript:someRandomFunctionNameThatDoesNotExist(\"2\");", errorEventArgs[0].Filename);
            Assert.AreEqual("javascript:someRandomFunctionNameThatDoesNotExist(\"2\");", errorEventArgs[1].Filename);

            Assert.AreEqual(ErrorFlags.REPORT_EXCEPTION, errorEventArgs[0].Flags);
            Assert.AreEqual(ErrorFlags.REPORT_EXCEPTION, errorEventArgs[1].Flags);

            Assert.AreEqual(0, errorEventArgs[0].Pos);
            Assert.AreEqual(0, errorEventArgs[1].Pos);
        }

        [Test]
        public void ConsoleMessage_NavigateWithSomeInvalidCss_AttachedEventHandlerShouldExecute()
        {
            ConsoleMessageEventArgs eventArgs = null;

            EventHandler<ConsoleMessageEventArgs> eventHandler = (object sender, ConsoleMessageEventArgs e) => eventArgs = e;
            _browser.ConsoleMessage += eventHandler;

            string html = "<p style=\"background: bluse; color: white;\">hello</p>";
            _browser.TestLoadHtml(html);

            _browser.ConsoleMessage -= eventHandler;

            Assert.NotNull(eventArgs);
            Assert.IsNotEmpty(eventArgs.Message);
            // Error messages changes based upon locale. (color/colour)
            Assert.IsTrue(eventArgs.Message.Contains(@"JavaScript Warning: ""Error in parsing value for ‘background’.  Declaration dropped."), eventArgs.Message);
        }

        [Test]
        public void AddMessageEventListener_JScriptFiresEvent_ListenerIsCalledWithMessage()
        {
            string payload = null;

            _browser.AddMessageEventListener("callMe", p => payload = p);

            _browser.LoadHtml(
                @"<!DOCTYPE html>
			                 <html><head>
			                 <script type='text/javascript'>
								window.onload= function() {
									var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent (event);
									document.dispatchEvent (event);
								}
							</script>
							</head><body></body></html>");

            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual("some data", payload);
        }

        [Test]
        public void AddMessageEventListener_CalledTwice_LatestListenerIsCalledWithMessage()
        {
            string payload = null;

            _browser.AddMessageEventListener("callMe", p => payload = p);
            _browser.AddMessageEventListener("callMe", p => payload = "newone " + p);

            _browser.LoadHtml(
                @"<!DOCTYPE html>
			                 <html><head>
			                 <script type='text/javascript'>
								window.onload= function() {
									var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent (event);
									document.dispatchEvent (event);
								}
							</script>
							</head><body></body></html>");

            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual("newone some data", payload);
        }

        [Test]
        public void RemoveMessageEventListener_JScriptFiresEvent_ListenerIsNotCalled()
        {
            string payload = null;

            _browser.AddMessageEventListener("callMe", p => payload = p);
            _browser.RemoveMessageEventListener("callMe");

            _browser.LoadHtml(
                @"<!DOCTYPE html>
			                 <html><head>
			                 <script type='text/javascript'>
								window.onload= function() {
									var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent (event);
									document.dispatchEvent (event);
								}
							</script>
							</head><body></body></html>");

            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.AreEqual(null, payload);
        }

        [Test]
        public void AddMessageEventListener_JScriptFiresEventUsingJQueryExecutor_ListenerIsCalledWithMessage()
        {
            string payload = null;

            _browser.AddMessageEventListener("callMe", p => payload = p);

            _browser.LoadHtml(
                @"<!DOCTYPE html>
			                 <html><head>No Content
			                
							</head><body></body></html>");

            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            var javaScript = @"var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent(event);";
            var executor = new JQueryExecutor(_browser.Window);

            executor.ExecuteJQuery(javaScript);

            Assert.AreEqual("some data", payload);
        }

        [Test]
        public void AddMessageEventListener_JScriptFiresEventAfterNavigatedToAnotherPage_ListenerIsCalledWithMessage()
        {
            string payload = null;

            _browser.LoadHtml(
                @"<!DOCTYPE html>
			                 <html><head>No Content
			                
							</head><body></body></html>");



            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            _browser.AddMessageEventListener("callMe", p => payload = p);
            _browser.Navigate("about:blank");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            var javaScript = @"var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent(event);";
            var executor = new JQueryExecutor(_browser.Window);

            executor.ExecuteJQuery(javaScript);

            Assert.AreEqual("some data", payload);
        }

        [Test]
        public void AddMessageEventListener_NavigatingToSeveralPages_ListenerIsReattachedAndCalledWithMessage()
        {
            string payload = null;

            var document = @"<!DOCTYPE html><html><head>No Content</head><body></body></html>";

            _browser.AddMessageEventListener("callMe", p => payload = p);
            _browser.LoadHtml(document);
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            _browser.LoadHtml(document);
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            var javaScript = @"var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent(event);";
            var executor = new JQueryExecutor(_browser.Window);

            executor.ExecuteJQuery(javaScript);

            Assert.AreEqual("some data", payload);
        }

        [Test]
        public void EvaluateScript_SimpleJavascript_ScriptExecutesAndReturnsExpectedResult()
        {
            _browser.TestLoadHtml("");

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                Assert.IsTrue(context.EvaluateScript("3 + 2;", out result));
                Assert.AreEqual(5, int.Parse(result));

                Assert.IsTrue(context.EvaluateScript("'hello' + ' ' + 'world';", out result));
                Assert.AreEqual("hello world", result);
            }
        }

        [Test]
        public void EvaluateScript_UnicodeJavascript_ScriptExecutesAndReturnsExpectedResult()
        {
            _browser.TestLoadHtml("");

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;

                Assert.IsTrue(context.EvaluateScript("'文';", out result));
                Assert.AreEqual("文"[0], result[0]);

                Assert.IsTrue(context.EvaluateScript("'a\0a';", out result));
                Assert.AreEqual("a", result);

                Assert.IsTrue(context.EvaluateScript("'hello' + ' ' + '中\0文';", out result));
                Assert.AreEqual("hello 中", result);

            }
        }

        [Test]
        public void EvaluateScript_SimpleJavascriptWithoutNormalDocumentSetup_ScriptExecutesAndReturnsExpectedResult()
        {
            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                Assert.IsTrue(context.EvaluateScript("3 + 2;", out result));
                Assert.AreEqual(5, Int32.Parse(result));

                Assert.IsTrue(context.EvaluateScript("'hello' + ' ' + 'world';", out result));
                Assert.AreEqual("hello world", result);
            }
        }

        [Test]
        public void EvaluateScript_JavascriptAccessExistingGlobalObjects_ScriptExecutesAndReturnsExpectedResult()
        {
            _browser.TestLoadHtml("hello world");

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                Assert.IsTrue(context.EvaluateScript("this", (nsISupports)_browser.Window.DomWindow, out result));
                Assert.AreEqual("[object Window]", result);

                Assert.IsTrue(context.EvaluateScript("this", (nsISupports)_browser.Document.DomObject, out result));
                Assert.AreEqual("[object HTMLDocument]", result);

                Assert.IsTrue(context.EvaluateScript("this.defaultView", (nsISupports)_browser.Document.DomObject, out result));
                Assert.AreEqual("[object Window]", result);

                Assert.IsTrue(context.EvaluateScript("this.body.innerHTML;", (nsISupports)_browser.Document.DomObject, out result));
                Assert.AreEqual("hello world", result);

                Assert.IsTrue(context.EvaluateScript("this.body.innerHTML = 'hi';", (nsISupports)_browser.Document.DomObject, out result));
                Assert.IsTrue(context.EvaluateScript("this.body.innerHTML;", (nsISupports)_browser.Document.DomObject, out result));
                Assert.AreEqual("hi", result);

                Assert.IsTrue(context.EvaluateScript("x=10;y=20;x*y;", out result));
                Assert.AreEqual("200", result);
            }
        }

        [Test]
        public void EvaluateScript_JavascriptAccessExistingGlobalObjectsWithoutNormalDocumentSetup_ScriptExecutesAndReturnsExpectedResult()
        {
            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                var ret = context.EvaluateScript("this", _browser.Window.DomWindow);
                Assert.IsFalse(ret.IsUndefined);
                Assert.AreEqual("[object Window]", ret.ToString());

                var execption = Assert.Throws<GeckoJavaScriptException>(() => context.EvaluateScript("body.innerHTML;", _browser.Window.DomWindow));
                Assert.AreEqual("JSError : ReferenceError: body is not defined StackTrace: @script:1:1\n", execption.Message);

                Assert.IsTrue(context.EvaluateScript("x=10;y=20;x*y;", out result));
                Assert.AreEqual("200", result);
            }
        }

        [Test]
        public void EvaluateScript_PassBodyasThis_ThisEqualsBodyObject()
        {
            _browser.TestLoadHtml("hello world");

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                context.EvaluateScript("this;", (nsISupports)_browser.Document.Body.DomObject, out result);

                Assert.AreEqual("[object HTMLBodyElement]", result);
            }
        }

        [Test]
        public void EvaluateScript_PassBodysFirstChildAndPassToAInlineFunction_FunctionReturnsExpectedResults()
        {
            _browser.TestLoadHtml("hello <span>world</span>");

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                context.EvaluateScript("function dosomthing(node) { return node.textContent; } dosomthing(this);", (nsISupports)_browser.Document.Body.FirstChild.DomObject, out result);

                Assert.AreEqual("hello ", result);
            }
        }

        [Test]
        public void EvaluateScript_Run500Times_DoesNotCrash()
        {
            _browser.TestLoadHtml("");

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                for (int i = 0; i < 500; i++)
                {
                    string result;
                    context.EvaluateScript("2+3;", out result);
                    Assert.AreEqual("5", result);
                }
            }
        }

        [Test]
        public void EvaluateScript_Run500TimesCreatingNewAutoJSContextEachTime_DoesNotCrash()
        {
            _browser.TestLoadHtml("");

            for (int i = 0; i < 500; i++)
            {
                using (AutoJSContext context = new AutoJSContext(_browser.Window))
                {
                    string result;
                    context.EvaluateScript("2+3;", out result);
                    Assert.AreEqual("5", result);
                }
            }
        }

        [Test]
        public void EvaluateScript_Run500Times_CreatingNewSafeAutoJSContextEachTime_DoesNotCrash()
        {
            for (int i = 0; i < 500; i++)
            {
                using (var safeContext = new AutoJSContext(_browser.Window))
                {
                    string result;
                    safeContext.EvaluateScript("2+3;", out result);
                    Assert.AreEqual("5", result);
                }
            }
        }

        [Test]
        public void EvaluateScript_Run500TimesNavigatingToANewDocumentEachTime_DoesNotCrash()
        {
            for (int i = 0; i < 500; i++)
            {
                _browser.TestLoadHtml(String.Format("{0}", i));

                using (AutoJSContext context = new AutoJSContext(_browser.Window))
                {
                    string result;
                    context.EvaluateScript("2+3;", out result);
                    Assert.AreEqual("5", result);
                }
            }
        }
        
        [Test]
        public void LoadHtml_Run500TimesNavigatingToANewDocumentEachTime_DoesNotCrash()
        {
            for (int i = 0; i < 500; i++)
            {
                _browser.TestLoadHtml(String.Format("{0}", i));              
            }
        }

        [Test]
        public void EvaluateScript_ReturingJsVal_ScriptExecutesAndReturnsJsValOfExpectedTypeAndContainingExpectedResult()
        {
            using (var context = new AutoJSContext(_browser.Window))
            {
                var jsVal = context.EvaluateScript("3 + 2;");
                Assert.IsTrue(jsVal.IsInt);
                Assert.AreEqual(5, jsVal.ToInteger());
            }
        }

        [Test]
        public void EvaluateScript_SyntacticallyInvalidJavascript_GeckoExceptionIsThrown()
        {
            using (var context = new AutoJSContext(_browser.Window))
            {
                var exception = Assert.Throws<GeckoException>(() => context.EvaluateScript("2 + _---;"));
                Assert.AreEqual("Failed to compile script.", exception.Message);
            }
        }

        [Test]
        public void EvaluateScript_JavascriptThatCallsMethodThatDoesNotExist_GeckoExceptionIsThrown()
        {
            using (var context = new AutoJSContext(_browser.Window))
            {
                var exception = Assert.Throws<GeckoJavaScriptException>(() => context.EvaluateScript("this.mymethodthatdontexist(3);"));
                Assert.AreEqual("JSError : TypeError: this.mymethodthatdontexist is not a function StackTrace: @script:1:1\n", exception.Message);
            }
        }


        [Test]
        public void Navigating_FrameDocumentLoaded_NavigatigAndFrameNavigatingEventIsCalled()
        {
            int navigatingCounter = 0;
            int frameNavigatingCounter = 0;
            _browser.Navigating += (sender, args) => navigatingCounter++;
            _browser.FrameNavigating += (sender, args) => frameNavigatingCounter++;

            _browser.TestLoadHtml(@"<html><body><iframe src='data:text/html,hello world'></iframe></body></html>'");

            Assert.AreEqual(1, navigatingCounter, "Navigating");
            Assert.AreEqual(1, frameNavigatingCounter, "FrameNavigating");
        }

        [Test]
        public void Navigating_JSCreatedFrameDocumentLoaded_NavigatigAndFrameNavigatingEventIsCalled()
        {
            int navigatingCounter = 0;
            int frameNavigatingCounter = 0;
            _browser.Navigating += (sender, args) => navigatingCounter++;
            _browser.FrameNavigating += (sender, args) => frameNavigatingCounter++;

            _browser.TestLoadHtml(@"
<html>
	<body>
		<script type='text/javascript'>
setTimeout(function(){
			var iframe = document.createElement('iframe');
			iframe.src = 'data:text/html,hello world';
			document.body.appendChild(iframe);
}, 1000);
		</script>
	</body>
</html>");
            DateTime expire = DateTime.Now.AddSeconds(5);
            while (DateTime.Now < expire)
                Application.DoEvents();


            Assert.AreEqual(1, navigatingCounter, "Navigating");
            Assert.AreEqual(1, frameNavigatingCounter, "FrameNavigating");
        }

        [Test]
        public void Navigating_IntialDocumentLoad_NavigatigEventIsCalled()
        {
            int counter = 0;
            _browser.Navigating += (sender, args) => counter++;

            _browser.TestLoadHtml("hello world");

            Assert.AreEqual(1, counter);
        }

        [Test]
        public void Navigating_TwoDocumentsLoaded_NavigatigEventIsCalledTwice()
        {
            int counter = 0;
            _browser.Navigating += (sender, args) => counter++;

            _browser.TestLoadHtml("hello world");
            _browser.TestLoadHtml("hello world");

            Assert.AreEqual(2, counter);
        }

        [Test]
        public void Navigating_UseJavaScriptToChangeDocument_NavigatigEventIsCalledWhenJavascriptChangesDocument()
        {
            int counter = 0;
            _browser.Navigating += (sender, args) => counter++;

            _browser.TestLoadHtml("hello world");
            _browser.Navigate("javascript:location.href='http://www.google.com';");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.AreEqual(2, counter);
        }

        [Platform("Win")]
        [Test]
        public void Navigating_UseJavaScriptToChangeDocumentToAUrlTheDoesNotExist_NavigatigEventIsCalled()
        {
            int counter = 0;
            int shouldNotChangeCounter = 0;

            _browser.TestLoadHtml("hello world");
            _browser.Navigating += (sender, args) => { counter++; args.Cancel = true; };
            _browser.Navigated += (sender, args) => shouldNotChangeCounter++;

            _browser.Navigate("javascript:location.href='http://www.domaindoesnNotExitqwertyuuiasdf.com?helloworld';");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.AreEqual(1, counter);
            Assert.AreEqual(0, shouldNotChangeCounter);
        }

        [Platform("Win")]
        [Test]
        public void Navigating_NavigatingIsCanceled_NavigateDoesNotComplete()
        {
            _browser.TestLoadHtml("hello world");
            bool navigatingCalled = false;
            bool navigatedCalled = false;

            _browser.Navigated += (sender, args) => navigatedCalled = true;
            _browser.Navigating += (sender, args) =>
                                      {
                                          args.Cancel = true;
                                          navigatingCalled = true;
                                      };
            _browser.Navigate("www.google.com");

            while (!navigatingCalled)
                Application.DoEvents();

            Assert.False(navigatedCalled);
            Assert.AreEqual("hello world", _browser.Document.Body.InnerHtml);

            navigatingCalled = false;
            _browser.Navigate("javascript:location.href='http://www.google.co.uk';");

            while (!navigatingCalled)
                Application.DoEvents();

            Assert.False(navigatedCalled);
            Assert.AreEqual("hello world", _browser.Document.Body.InnerHtml);
        }

        [Test]
        [Ignore("Navigate doesn't behave how describe in this unittest on my Windows 7 64bit machine.")]
        public void Navigating_NavigationError_Http()
        {
            int errorCount = 0, completeCount = 0;
            _browser.DocumentCompleted += (sender, e) => ++completeCount;
            _browser.NavigationError += (sender, e) => ++errorCount;

            _browser.Navigate("http://localhost:63333");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0, "localhost:63333 should have failed.");
            errorCount = completeCount = 0;

            _browser.Navigate("http://localhost:25");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0, "(1) localhost:25 should have failed.");
            errorCount = completeCount = 0;

            _browser.Reload();
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0, "(2) localhost:25 should have failed.");
            errorCount = completeCount = 0;
        }

        [Test]
        public void Navigating_NavigationError_Chrome()
        {
            int errorCount = 0, completeCount = 0;
            _browser.DocumentCompleted += (sender, e) => ++completeCount;
            _browser.NavigationError += (sender, e) => ++errorCount;

            _browser.Navigate("chrome://global/content/bindings/general.xml"); //good url
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 0 && completeCount == 1);
            errorCount = completeCount = 0;

            _browser.Navigate("chrome://global/content/aaaa"); //not found
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0);
            errorCount = completeCount = 0;

            Assert.True(_browser.CanGoBack);
            _browser.GoBack();
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 0 && completeCount == 1);
            errorCount = completeCount = 0;

            Assert.True(_browser.CanGoForward);
            _browser.GoForward();
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0);
            errorCount = completeCount = 0;

            _browser.Navigate("chrome://global/bindings/general.xml"); //missing 'content' part
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0);
            errorCount = completeCount = 0;

            _browser.Navigate("chrome://global/content/bindings/general.xml");
            _browser.Stop();
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0);
            errorCount = completeCount = 0;

            _browser.Navigate("chrome://global/content/bindings/general.xml");
            _browser.Navigating += (sender, e) => e.Cancel = true;
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0);
            errorCount = completeCount = 0;
        }

        [Test]
        public void Navigating_NavigationError_History()
        {
            string errorUrl = null;
            _browser.NavigationError += (sender, e) => errorUrl = e.Uri;

            _browser.Navigate("chrome://global/content/bindings/general.xml"); //good url
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            _browser.Navigate("chrome://global/content/aaaa"); //not found
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.True(_browser.CanGoBack);
            _browser.GoBack();
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.True(_browser.CanGoForward);
            _browser.GoForward();
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual(errorUrl, "chrome://global/content/aaaa");

            _browser.Navigate("chrome://global/bindings/general.xml"); //missing 'content' part
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual(errorUrl, "chrome://global/bindings/general.xml");
        }

        [Test]
        [Ignore("Expected fail.")]
        public void Navigating_NavigationError_History2()
        {
            string errorUrl = null;
            _browser.NavigationError += (sender, e) => errorUrl = e.Uri;

            _browser.Navigate("chrome://global/content/bindings/general.xml"); //good url
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            _browser.Navigate("chrome://global/bindings/general.xml"); //missing 'content' part
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            // TODO Navigate("chrome://global/bindings/general.xml") failed and the url was not pushed into history stack,
            // so the assertion failed. may be a mozilla's bug
            Assert.True(_browser.GoBack());
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(_browser.GoForward());
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual(errorUrl, "chrome://global/bindings/general.xml");
        }

        [Test]
        public void Navigating_Retarget()
        {
            int errorCount = 0, completeCount = 0, retargetCount = 0;
            string url = "data:application/zip,xyzuvw";
            GeckoRetargetedEventArgs rte = null;
            string contentType = null;
            _browser.DocumentCompleted += (sender, e) => ++completeCount;
            _browser.NavigationError += (sender, e) => ++errorCount;
            _browser.Retargeted += (sender, e) =>
            {
                ++retargetCount;
                rte = e;
                contentType = (rte.Request as Gecko.Net.Channel).ContentType;
            };

            _browser.Navigate(url);
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 0 && completeCount == 0 && retargetCount == 1, "Unexpected event counts");
            Assert.AreEqual(url, rte.Uri.ToString());
            Assert.AreEqual("application/zip", contentType);
        }

        [Test]
        public void LoadContent_ControlHandleCreated_DocumentIsInitalizedWithSpecifiedContent()
        {
            Assert.AreEqual(true, _browser.IsHandleCreated);
            _browser.LoadContent("<body><div id='main'>hello world</div></body>", "http://www.earth.com", "text/html");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual(_browser.Document.GetElementById("main").TextContent, "hello world");
        }

        [Test]
        public void LoadContent_ControlHandleNotCreated_DocumentIsInitalizedWithContentAndHandleCreationisForced()
        {
            using (var browser = new GeckoWebBrowser())
            {
                Assert.AreEqual(false, browser.IsHandleCreated);
                browser.LoadContent("<body><div id='main'>hello world</div></body>", "http://www.earth.com", "text/html");
                Assert.AreEqual(true, browser.IsHandleCreated);
                browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
                Assert.AreEqual(browser.Document.GetElementById("main").TextContent, "hello world");
            }
        }

        /// <summary>
        /// UKAC unit test for CreateWindow
        /// </summary>        
        [Test]
        public void CreateWindow_OnloadCallsWindowOpenToCheckCreateWindowSuccess_ShouldReturnWindowObject()
        {
            using (var newWindow = new GeckoWebBrowser())
            {
                _browser.CreateWindow += (m, e) =>
                {
                    // ReSharper disable once AccessToDisposedClosure
                    e.WebBrowser = newWindow;
                    var h = e.WebBrowser.Handle;
                };

                _browser.LoadHtml("<body onload=\"name=window.open('about:blank')\"></body>");
                _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
                Assert.AreEqual("[object Window]", _browser.Window.Name);
            }
        }

		/// <summary>
		/// UKAC unit test for SetWindowBounds
		/// </summary>
		[Test]
		public void SetWindowBounds_OnloadCallsWindowOpenToCheckWindowBounds_ShouldBeSame()
		{
		    using (var newWindow = new GeckoWebBrowser())
		    {
		        _browser.CreateWindow += (m, e) =>
		        {
		            // ReSharper disable once AccessToDisposedClosure
		            e.WebBrowser = newWindow;
                    e.WebBrowser.WindowSetBounds += (s, v) =>
		            {
		                //e.WebBrowser.FindForm().Bounds = v.Bounds;
		                Assert.AreEqual(254, v.Bounds.Top, "Bounds.Top");
		                Assert.AreEqual(254, v.Bounds.Left, "Bounds.Left");
		            };
		            var h = e.WebBrowser.Handle;
		        };

		        _browser.LoadHtml(
		            "<body onload=\"name=window.open('about:blank','test','top=254,left=254,width=400,height=300')\"></body>");
		        _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
		    }
		}

        [Test]
        public void CycleCollectorLeakingTest_NavigateShouldNotHoldOnToPreviousObjects()
        {
            bool done = false;
            _browser.DocumentCompleted += (sender, args) => done = true;

            MemoryService.MinimizeHeap(true);

            for (int i = 0; i < 40; i++)
            {
                done = false;
                using (var testFile = new HtmlTestFile(@"<div>hello world</div>"))
                {
                    _browser.Navigate(testFile.FileName);
                    while (!done)
                    {
                        Application.DoEvents();
                        Application.RaiseIdle(EventArgs.Empty);
                    }

                    var doc = _browser.Document;
                    Console.WriteLine(doc);
                    var v = doc.Doc.Value;
                    Console.WriteLine(v.GetProperty<string>("characterSet"));
                    Console.WriteLine(_browser.Document.Body);
                    Console.WriteLine(_browser.Document.Body.FirstChild);

                    DateTime b = DateTime.Now;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    MemoryService.MinimizeHeap(true);
                    DateTime a = DateTime.Now;
                    Console.WriteLine($"mh took {((a - b).TotalMilliseconds)}ms");
                    Assert.True((a - b) < TimeSpan.FromSeconds(1), "MinimizeHeap should be quick!");
                }
            }
        }

        [Test]
        public void CycleCollectorLeakingTest_LoadContentShouldNotHoldOntoPreviousContent()
        {
            bool done = false;
            _browser.DocumentCompleted += (sender, args) => done = true;

            MemoryService.MinimizeHeap(true);

            try
            {
                for (int i = 0; i < 40; i++)
                {
                    done = false;
                    using (var testFile = new HtmlTestFile(@"<div>hello world</div>"))
                    {
                        _browser.LoadContent(File.ReadAllText(testFile.FileName), "file://" + testFile.FileName, "text/html");
                        while (!done)
                        {
                            Application.DoEvents();
                            Application.RaiseIdle(EventArgs.Empty);
                        }
                        var doc = _browser.Document;

                        var v = doc.Doc.Value;
                        Console.WriteLine(v.GetProperty<nsISupports>("body", true));
                        Console.WriteLine(doc.Doc.Value.DocumentElement);

                        DateTime b = DateTime.Now;
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        MemoryService.MinimizeHeap(true);
                        DateTime a = DateTime.Now;
                        Console.WriteLine($"mh took {((a - b).TotalMilliseconds)}ms");
                        Assert.True((a - b) < TimeSpan.FromSeconds(1), "MinimizeHeap should be quick!");
                    }
                }
            }
            catch (AccessViolationException ex)
            {
                Assert.Fail($"Exception: {ex}");
            }
        }

        [Test]
        public void CycleCollectorLeakingTest_TwoBrowsers_LoadContentShouldNotHoldOntoPreviousContent()
        {

            var browser2 = new GeckoWebBrowser();
            browser2.Dock = DockStyle.Fill;
            _form.Controls.Add(browser2);
            _form.Show();

            MemoryService.MinimizeHeap(true);

            PerformTest(_browser, browser2);

            browser2.Dispose();
        }

        private void PerformTest(GeckoWebBrowser first, GeckoWebBrowser second)
        {
            bool done = false;
            first.DocumentCompleted += (sender, args) => done = true;
            second.DocumentCompleted += (sender, args) => done = true;
            try
            {
                for (int i = 0; i < 40; i++)
                {
                    var aBrowser = i % 2 == 0 ? first : second;
                    done = false;
                    using (var testFile = new HtmlTestFile(@"<div>hello world</div>"))
                    {
                        aBrowser.LoadContent(File.ReadAllText(testFile.FileName), "file://" + testFile.FileName,
                            "text/html");
                        while (!done)
                        {
                            Application.DoEvents();
                            Application.RaiseIdle(EventArgs.Empty);
                        }
                        var doc = aBrowser.Document;

                        var v = doc.Doc.Value;
                        Console.WriteLine(v.GetProperty<nsISupports>("body", true));
                        Console.WriteLine(doc.Doc.Value.DocumentElement);

                        DateTime b = DateTime.Now;
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        MemoryService.MinimizeHeap(true);
                        DateTime a = DateTime.Now;
                        Console.WriteLine($"mh took {((a - b).TotalMilliseconds)}ms");
                        Assert.True((a - b) < TimeSpan.FromSeconds(1), "MinimizeHeap should be quick!");
                    }
                }
            }
            catch (AccessViolationException ex)
            {
                Assert.Fail($"Exception: {ex}");
            }
        }


        [Ignore("Test runner is running Explicit tests")]
        [Explicit("Test shows modal dialog")]
        [Test]
        public void NavigateMemoryTests_SingleBrowserMultipleNavigations_DoesNotHoldOnToLotsOfPages()
        {
            for (int i = 0; i < 50; i++)
            {
                _browser.Navigate($"http://pastebin.com/{Guid.NewGuid()}");

                _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

                // Without doing these 3 things - about:memory shows lots of pastebin pages. (and consumes lots of memory)
                GC.Collect();
                GC.WaitForPendingFinalizers();
                MemoryService.MinimizeHeap(true);
            }

            _browser.Navigate("about:memory");

            _form.Visible = false;
            _form.ShowDialog();
        }

        [Ignore("Test runner is running Explicit tests")]
        [Explicit("Test shows modal dialog")]
        [Test]
        public void NavigateMemoryTests_SingleBrowserMultipleNavigations_DoesNotHoldOnToLotsOfPages2()
        {
            var filesToDelete = new List<HtmlTestFile>();
            try
            {
                SetBloomPreferences();
                _form.Size = new Size(600, 600);
                for (int i = 0; i < 50; i++)
                {
                    var filename = CreateTestHtmlFile();
                    _browser.Navigate($"file://{filename.FileName}");

                    _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

                    // Without doing these 3 things - about:memory shows lots of "active" pages. (which consume lots of memory)
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    MemoryService.MinimizeHeap(true);

                    System.Threading.Thread.Sleep(500);
                    filesToDelete.Add(filename);
                }

                var form2 = new Form();
                var browser2 = new GeckoWebBrowser {Dock = DockStyle.Fill};
                form2.Controls.Add(browser2);
                browser2.Navigate("about:memory");
                form2.ShowDialog();
            }
            finally
            {
                foreach (var testFile in filesToDelete)
                    testFile.Dispose();
            }
        }

        private bool _browserDone;

        [Ignore("Test runner is running Explicit tests")]
        [Explicit("Test shows modal dialog")]
        [Test]
        public void NavigateMemoryTests_SingleBrowserMultipleNavigations_DoesNotHoldOnToLotsOfPages3()
        {
            var filesToDelete = new List<HtmlTestFile>();
            try
            {
                SetBloomPreferences();
                _form.Size = new Size(600, 600);
                for (int i = 0; i < 50; i++)
                {
                    _browserDone = false;
                    var filename = CreateTestHtmlFile();
                    _browser.DocumentCompleted += WebBrowser_ReadyStateChanged;
                    _browser.ReadyStateChange += WebBrowser_ReadyStateChanged;
                    _browser.Navigate($"file://{filename.FileName}");

                    while (!_browserDone)
                    {
                        Application.DoEvents();
                        Application.RaiseIdle(EventArgs.Empty);
                    }
                    System.Threading.Thread.Sleep(500);
                    filesToDelete.Add(filename);
                }

                var form2 = new Form();
                var browser2 = new GeckoWebBrowser {Dock = DockStyle.Fill};
                form2.Controls.Add(browser2);
                browser2.Navigate("about:memory");
                form2.ShowDialog();
            }
            finally
            {
                foreach (var testfile in filesToDelete)
                    testfile.Dispose();
            }
        }

        private static void SetBloomPreferences()
        {
            GeckoPreferences.User["network.proxy.http"] = string.Empty;
            GeckoPreferences.User["network.proxy.http_port"] = 80;
            GeckoPreferences.User["network.proxy.type"] =
                1; // 0 = direct (uses system settings on Windows), 1 = manual configuration
            GeckoPreferences.User["memory.free_dirty_pages"] = true;
            // Do NOT set this to zero. Somehow that disables following hyperlinks within a document
            GeckoPreferences.User["browser.sessionhistory.max_entries"] = 1;
            GeckoPreferences.User["browser.sessionhistory.max_total_viewers"] = 0;
            GeckoPreferences.User["browser.cache.memory.enable"] = false;
            GeckoPreferences.User["image.mem.max_decoded_image_kb"] = 40960; // 40MB (default = 256000 == 250MB)
            GeckoPreferences.User["javascript.options.mem.max"] = 40960; // 40MB (default = -1 == automatic)
            GeckoPreferences.User["javascript.options.mem.high_water_mark"] = 20; // 20MB (default = 128 == 128MB)
            GeckoPreferences.User["image.mem.surfacecache.max_size_kb"] = 40960; // 40MB
            GeckoPreferences.User["image.mem.surfacecache.min_expiration_ms"] = 500; // 500ms (default = 60000 == 60sec)
            GeckoPreferences.User["browser.cache.memory.capacity"] = 0; // 0 disables feature
            GeckoPreferences.User["network.http.max-persistent-connections-per-server"] = 200;
            GeckoPreferences.User["network.http.pipelining.maxrequests"] = 200;
            GeckoPreferences.User["network.http.pipelining.max-optimistic-requests"] = 200;
            GeckoPreferences.User["gfx.font_rendering.graphite.enabled"] = true;
            GeckoPreferences.User["mousewheel.with_control.action"] = 0;
            GeckoPreferences.User["media.navigator.enabled"] = true;
            GeckoPreferences.User["media.navigator.permission.disabled"] = true;
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                GeckoPreferences.User["layers.acceleration.force-enabled"] = true;
            GeckoPreferences.User["browser.zoom.full"] = true;
            GeckoPreferences.User["layout.spellcheckDefault"] = 0;
        }

        private HtmlTestFile CreateTestHtmlFile()
        {
            var ret = new HtmlTestFile();
                ret.Write(
                @"<html>
<head>
<meta charset=""utf-8""></meta>
</head>
<body>
<h1>This is a test!</h1>
<p class=""greenText"">of course it is...</p>
<p id=""demo"" class=""redText"">The file is " + ret.FileName + @"</p>
</body>
</html>");

            return ret;
        }

        void WebBrowser_ReadyStateChanged(object sender, EventArgs e)
        {
            if (_browser.Document.ReadyState != "complete")
                return; // Keep receiving until it is complete.
            _browser.ReadyStateChange -= WebBrowser_ReadyStateChanged; // just do this once per navigation
            _browser.DocumentCompleted -= WebBrowser_ReadyStateChanged;

            // These don't seem to have any effect at all.
            GC.Collect();
            GC.WaitForPendingFinalizers();
            MemoryService.MinimizeHeap(true);
            _browserDone = true;
        }

        [Ignore("Test runner is running Explicit tests")]
        [Explicit("Slow and connects to google")]
        [Test]
        public void EvaluateScript_OnParentLessBrowserIstanceAndApplicationDoEventsBeingCalled_DoesNotCrash()
        {
            for (int i = 0; i < 200; i++)
            {
                var b = new GeckoWebBrowser();
                var h = b.Handle;
                b.Navigate("http://www.google.com");
                //b.WaitUntilNavigatinFinished(); // This uses await Task.Delay and so doesn't crash/
                b.NavigateFinishedNotifier.BlockUntilNavigationFinished(); // This uses Application.DoEvents() and so crashes as it seems to invoke Firefox Idle handler.. (IdleTaskRunner)
                for (int j = 0; j < 100; j++)
                {
                    using (var context = new AutoJSContext(b.Window))
                    {
                        var result = context.EvaluateScript("getComputedStyle(document.body, null).display",
                            (nsISupports) b.Window.DomWindow,
                            (nsISupports) b.Document.DomObject);
                        if (!result.IsString)
                            Console.WriteLine("NotString");
                    }

                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
                b.Dispose();
            }
        }

        [Ignore("Test runner is running Explicit tests")]
        [Explicit("Slow and connects to google")]
        [Test]
        public void EvaluateScript_NavigateToPageThatDoesSamePageNavigations_DoesNotCrash()
        {
            for (int i = 0; i < 80; i++)
            {
                var b = new GeckoWebBrowser();
                var h = b.Handle;
                for (int j = 0; j < 5; j++)
                {
                    b.Navigate("http://www.google.com");
                    b.NavigateFinishedNotifier
                        .BlockUntilNavigationFinished(); // This uses Application.DoEvents() and so crashes as it seems to invoke Firefox Idle handler.. (IdleTaskRunner)
                }
                GC.WaitForPendingFinalizers();
                GC.Collect();
                Console.WriteLine($"{i}");
                b.Dispose();
            }
        }

        /// <summary>
        /// Test Helper method to return the ref count of the ContentDOMWindow
        /// </summary>
        public static int GetContentDomWindowComRefCount(GeckoWebBrowser browser)
        {
            var domWindow = browser.Browser.GetContentDOMWindowAttribute();
            var w = Marshal.GetIUnknownForObject(domWindow);
            return Marshal.Release(w);
        }

        [Test]
        public void AttachEvents_ContentDomRefCountIsNotDecremented()
        {
            using (var testFile = new HtmlTestFile(@"<div>hello world</div>"))
            {
                _browser.Navigate(testFile.FileName);
                _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
                var beforeRef = GetContentDomWindowComRefCount(_browser);
                _browser.DetachEvents(true);
                _browser.AttachEvents();
                var afterRef = GetContentDomWindowComRefCount(_browser);
                Assert.AreEqual(beforeRef, afterRef, "AttachEvents Should not decrement ContentDomWindow");
            }
        }

        [Ignore("Test runner is running Explicit tests")]
        [Explicit("Test shows modal dialog")]
        [Test]
        public void JavascriptBlobTest()
        {
            // Opening the HTML used in this test as a file in Firefox shows the
            // iframe content being updated each time you click the button.  Running
            // this unit test with Geckofx60 in C#, the iframe never gets updated.
            // (In fact, the iframe stays empty from the beginning.)
            string htmlFile = null;
            try
            {
                _form.Close();
                SetBloomPreferences();
                htmlFile = CreateHtmlFileToTestBlobs();
                var form2 = new Form { Size = new Size(600, 600) };
                var browser2 = new GeckoWebBrowser { Dock = DockStyle.Fill };
                form2.Controls.Add(browser2);
                browser2.Navigate($"file://{htmlFile}");
                form2.ShowDialog();
            }
            finally
            {
                if (!String.IsNullOrEmpty(htmlFile) && File.Exists(htmlFile))
                    File.Delete(htmlFile);
            }
        }

        private string CreateHtmlFileToTestBlobs()
        {
            var htmlFile = Guid.NewGuid() + ".html";
            var htmlPath = Path.Combine(Path.GetTempPath(), htmlFile);
            // Note that Firefox doesn't seem to recognize the initial srcdoc content,
            // but does set it and see it properly in the onload handler attached to
            // the body element.  Geckofx60 inside C# doesn't even do that much.
            File.WriteAllText(htmlPath, @"<html>
   <head>
    <meta charset=""UTF-8""/>
    <script type=""text/javascript"">
//<![CDATA[
count = 0;
function loadIframe() {
    var iframe = document.getElementById(""innerTest"");
    var html = ""<html><head><meta charset='UTF-8'/></head><body>"" +
        ""<p>The button has not yet been clicked.</p>"" +
        ""</body></html>"";
    iframe.setAttribute('srcdoc', html);
}
function clickButton() {
    ++count;
    var html = ""<html><head><meta charset='UTF-8'/></head><body>"" +
        ""<p>The button has been clicked "" + count + "" times.</p>"" +
        ""</body></html>"";
    var blob = new Blob([html], {""type"": ""text/html""});
    var uri = window.URL.createObjectURL(blob);
    var iframe = document.getElementById(""innerTest"");
    iframe.removeAttribute('srcdoc');
    iframe.setAttribute('src', uri);
}
//]]>
    </script>
  </head>
  <body onload=""loadIframe()"">
    <div id=""test"" class=""text"">
      <p>This is a test!</p>
    </div>
    <div class=""framing"">
    <iframe id=""innerTest"" srcdoc=""<p>This is a test.</p>"">
      Sorry, iframe doesn't work in this browser!
    </iframe>
    </div>
    <br/>
    <button type=""button"" onclick=""clickButton()"">Click Me!</button> 
  </body>
</html>");
            return htmlPath;
        }

        #region Helper Classes

        class HtmlTestFile : IDisposable
        {
            private readonly string _fileName;

            public string FileName => _fileName;

            public HtmlTestFile(string html) : this()
            {
                Write(html);
            }

            public HtmlTestFile()
            {
                _fileName = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".html");
            }

            public void Write(string html)
            {
                File.WriteAllText(_fileName, html);
            }

            public void Dispose()
            {
                File.Delete(_fileName);
            }
        }

        #endregion
    }
}
