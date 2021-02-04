using Foundation;
using System;
using UIKit;

namespace Lis1
{
    public partial class PageCell : UITableViewCell
    {
        public PageCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(string name)
        {
            nameCell.Text = name;
        }
    }
}