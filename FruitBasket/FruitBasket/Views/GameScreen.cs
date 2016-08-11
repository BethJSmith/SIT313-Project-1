using Foundation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UIKit;
using AudioToolbox;

namespace FruitBasket
{
    public partial class GameScreen : UIViewController
    {
		
		Game Memory;
		List<UIImageView> Spaces;
		Leaderboard Leaderboard;

		// Move number, whether user selects first tile or second
		int move;

		// First tile pickedd
		string firstTile;
		int firstSelection;

		// Sound effects
		NSUrl url;
		SystemSound sound;

		// Stopwatch used to time player
		Stopwatch stopwatch = new Stopwatch();

        public GameScreen (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Load sound effects
			url = NSUrl.FromFilename("Sounds/success.mp3");
			sound = new SystemSound(url);

			// Load leaderboard
			Leaderboard = new Leaderboard("Data/HighScores.txt");

			// Set move to first
			move = 1;
			firstTile = "";
			firstSelection = -1;

			// Create new game (generates a new random grid)
			Memory = new Game();

			// List of all images on screen
			Spaces = new List<UIImageView>()
			{
				img01, img02, img03,
				img04, img05, img06,
				img07, img08, img09,
				img10, img11, img12
			};

			// Set all images to their icons
			for (int x = 0; x < Spaces.Count; x++)
			{
				Spaces[x].Image = new UIImage(Memory.Grid[x].Icon);
			}

			// Hide all images from player view
			HideSpaces(); // Comment out for debugging

			// Start stopwatch
			stopwatch.Start();

			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void pickFruit(UIButton sender)
		{
			int selection = -1;

			// Determine what has been clickedd
			if (sender == btn00)
				selection = 0;
			else if (sender == btn01)
				selection = 1;
			else if (sender == btn02)
				selection = 2;
			else if (sender == btn03)
				selection = 3;
			else if (sender == btn04)
				selection = 4;
			else if (sender == btn05)
				selection = 5;
			else if (sender == btn06)
				selection = 6;
			else if (sender == btn07)
				selection = 7;
			else if (sender == btn08)
				selection = 8;
			else if (sender == btn09)
				selection = 9;
			else if (sender == btn10)
				selection = 10;
			else if (sender == btn11)
				selection = 11;

			// Show the tile pickedd
			ShowImage(selection);

			if (move == 1 && selection >= 0) // First tile is pickedd
			{
				firstTile = Memory.Grid[selection].Icon;
				firstSelection = selection;
				move = 2; // Now the move becomes the 2ndn
			}
			else if (move == 2 && selection >= 0 && firstSelection != selection) // Picks the second tile, checks that it's not the first againi
			{
				if (firstTile == Memory.Grid[selection].Icon) // Match found
				{
					// Save tilee
					Memory.Grid[selection].Revealed = true;
					Memory.Grid[firstSelection].Revealed = true;

					// Play soundn
					sound.PlayAlertSound();

					// Reset movee
					move = 1;
					firstTile = "";
					firstSelection = -1;

				}
				else // No match
				{
					// Change movee
					move = 3;
					firstTile = "";
					firstSelection = -1;
				}
			}
			else if (move == 3)
			{
				// Hide tilee
				HideSpaces();

				// Change movee
				move = 1;
			}

			// Check for winn
			if (move != 0 && CheckWin())
			{
				move = 0;

				// Stop the stopwatch
				stopwatch.Stop();
				double time = double.Parse(string.Format(stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds));

				// https://developer.xamarin.com/recipes/ios/standard_controls/alertcontroller/

				string message = "You completed the game in " + time + " seconds.";
				message += "\n\nEnter your name to add it to the high scores table.";

				// Create Alert
				var getName = UIAlertController.Create("You win!", message, UIAlertControllerStyle.Alert);

				// Add text inputt
				getName.AddTextField(UITextField => { });

				// Add skip buttonn
				getName.AddAction(UIAlertAction.Create("Skip", UIAlertActionStyle.Cancel,
								   alert => EnterName("", time)));

				// Add continue button
				getName.AddAction(UIAlertAction.Create("Continue", UIAlertActionStyle.Default, 
				                   alert => EnterName(getName.TextFields[0].Text, time)));

				// Present Alert
				PresentViewController(getName, true, null);

				// Win stuff here...
			}
		}

		// Shows the image of a given tile
		public void ShowImage(int number)
		{
			if (number >= 0)
				Spaces[number].Image = new UIImage(Memory.Grid[number].Icon);
		}

		// Hides all spaces that haven't been revealed
		public void HideSpaces()
		{
			for (int x = 0; x < Spaces.Count; x++)
				if (Memory.Grid[x].Revealed == false)
					Spaces[x].Image = new UIImage(Memory.Grid[x].Blank);
		}

		// Checks if win conditions are met
		public bool CheckWin()
		{
			for (int x = 0; x < Spaces.Count; x++)
				if (Memory.Grid[x].Revealed == false)
					return false;
			return true;
		}

		// Name is entered
		public void EnterName(string name, double time)
		{
			if (name != "")
			{
				// Save name to score table
				Leaderboard.AddScore(name, time);

			}

			// Show exit button
			btnContinue.SetTitle("Continue", UIControlState.Normal);
			btnContinue.Enabled = true;

		}


    }
}