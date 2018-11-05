using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace iOS_Hello
{
    public partial class ViewController : UIViewController
    {
        public NSPropertyListFormat<string> names { get; set; }

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
            txtName.ResignFirstResponder();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}