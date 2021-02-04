using System;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace Lis1
{
    internal class NamesSource : UITableViewSource
    {
        List<string> names;

        public NamesSource(List<string> names)
        {
            this.names = names;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (PageCell) tableView.DequeueReusableCell("cell_id", indexPath);
            cell.UpdateCell(names[indexPath.Row]);
            //var cell = new UITableViewCell(UITableViewCellStyle.Default, "");
            //cell.TextLabel.Text = names[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return names.Count;
            //throw new NotImplementedException();
        }
    }
}