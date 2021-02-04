using Foundation;
using System;
using UIKit;

namespace Lis1
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            var page2ViewController = segue.DestinationViewController as Page2ViewController;
            page2ViewController.Name = NameTextField.Text;

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton3400_TouchUpInside(UIButton sender)
        {
            //throw new NotImplementedException();
            NavigationController.PushViewController(new Page2ViewController(), true);
        }
    }
}