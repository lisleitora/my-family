using Foundation;
using System;
using UIKit;
using System.Linq;
using System.Collections.Generic;

namespace Lis1
{
    public partial class Page2ViewController : UIViewController
    {
        public string Name { get; set; }

        public Page2ViewController()
        {
        }

        public Page2ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NameLabel.Text = Name;
            List<string> names = new List<string>
            {
                "Lis", "Pablo", "Daniela", "Cake", "Luna"
            };

            table1.Source = new NamesSource(names);

        }
    }
}