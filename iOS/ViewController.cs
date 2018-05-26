using System;

using UIKit;

using XamarinOpenCV;

using XamarinOpenCV.Bindings;

namespace XamarinOpenCV.iOS
{
    public partial class ViewController : UIViewController
    {
        int count = 1;

        private OpenCV OpenCV = new OpenCV();

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            Button.TouchUpInside += delegate
            {
                var title = string.Format("{0} clicks!", count++);
                Button.SetTitle(title, UIControlState.Normal);
            };

            Console.WriteLine(OpenCV.Version());

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
