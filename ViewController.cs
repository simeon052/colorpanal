using System;

using AppKit;
using Foundation;

namespace MacDemo
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void ClickedButton(Foundation.NSObject sender)
        {

            var colorPanel = NSColorPanel.SharedColorPanel;

            Show(colorPanel, false);

        }

        private NSWindow window;
        public void Show(NSWindow window, bool releasedWhenClosed = true)
        {
            if (window == null)
            {
                // TODO: Log
                return;
            }

            this.window = window;
            window.ReleasedWhenClosed = releasedWhenClosed;
            NSApplication.SharedApplication.RunModalForWindow(window);
        }
    }
}
