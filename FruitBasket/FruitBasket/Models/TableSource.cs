using System;
using UIKit;
namespace FruitBasket
{
	public class TableSource : UITableViewSource
	{
		// GK Micro Studios, Xamarin iOS Tutorial 2.1 - How to Create and Populate a tableview (UITableView) - Part 1, retrieved 11 August 2016,
		// https://www.youtube.com/watch?v=6iqRqZys5mk

		string[] tableItems;
		string cellIdentifier = "TableCell";

		public TableSource(string[] items)
		{
			tableItems = items;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
			cell.TextLabel.Text = tableItems[indexPath.Row];
			return cell;
		}
	}
}

