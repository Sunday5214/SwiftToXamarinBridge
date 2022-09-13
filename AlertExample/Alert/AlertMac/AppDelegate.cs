using Alert;
using AppKit;
using Foundation;
using SwiftToSharpBinding;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

namespace AlertMac
{
	[Register ("AppDelegate")]
	public class AppDelegate : FormsApplicationDelegate
    { 
        NSWindow window;
        private AlertTesterProxy _proxy;

        public AppDelegate ()
		{
            var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

            var rect = new CoreGraphics.CGRect(200, 1000, 1024, 768);
            window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
            window.Title = "Xamarin.Forms on Mac!"; // choose your own Title here
            window.TitleVisibility = NSWindowTitleVisibility.Hidden;
        }

        public override NSWindow MainWindow
        {
            get { return window; }
        }

        public override void DidFinishLaunching (NSNotification notification)
		{
            // Insert code here to initialize your application
            Forms.Init();
            LoadApplication(new App());

            _proxy = new AlertTesterProxy();
            var result = _proxy.ErrorReadingResultsWithQuestion("Hello", "World");
          //  ErrorReadingResult

            base.DidFinishLaunching(notification);
        }

		public override void WillTerminate (NSNotification notification)
		{
			// Insert code here to tear down your application
		}
	}
}

