using Foundation;
using System;
using UIKit;

namespace FruitBasket
{
    public partial class HighScoresScreen : UIViewController
    {
		Leaderboard Leaderboard;

        public HighScoresScreen (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			Leaderboard = new Leaderboard("Data/HighScores.txt");

			string highScores = "";

			foreach (HighScore score in Leaderboard.Scores)
			{
				highScores += string.Format("{0} - {1}\n", score.Name, score.Time);
			}

			lblScores.Text = highScores;

		}
    }
}