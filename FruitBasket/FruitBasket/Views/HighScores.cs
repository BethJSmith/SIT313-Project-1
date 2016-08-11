using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace FruitBasket
{
    public partial class HighScores1 : UIViewController
    {
		Leaderboard Leaderboard;

        public HighScores1 (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			Leaderboard = new Leaderboard("Data/HighScores.txt");

			List<string> scores = new List<string>();
			int x = 1;
			foreach (HighScore hs in Leaderboard.Scores)
			{
				scores.Add(string.Format("{2}. {0} - {1} seconds", hs.Name, hs.Time, x));
				x++;
			}

			string[] data = new string[scores.Count];

			for (int i = 0; i < data.Length; i++)
			{
				data[i] = scores[i];
			}

			UITableView scoresTable;

			scoresTable = new UITableView
			{
				Frame = new CoreGraphics.CGRect(0, 90, View.Bounds.Width, View.Bounds.Height - 156),
				Source = new TableSource(data)
			};

			View.AddSubview(scoresTable);

		}
    }
}