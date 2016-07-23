using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace MemoryGame
{
    public partial class GameController : UIViewController
    {
		Game Memory;
		List<UIImageView> Spaces;

        public GameController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

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

			// Hide all images from player vieww
			HideSpaces(); // Comment out for debugging

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void touchIcon(UIButton sender)
		{
			if (sender == btn01)
				Spaces[0].Image = new UIImage(Memory.Grid[0].Icon);
			else if (sender == btn02)
				Spaces[1].Image = new UIImage(Memory.Grid[1].Icon);
			else if (sender == btn03)
				Spaces[2].Image = new UIImage(Memory.Grid[2].Icon);
			else if (sender == btn04)
				Spaces[3].Image = new UIImage(Memory.Grid[3].Icon);
			else if (sender == btn05)
				Spaces[4].Image = new UIImage(Memory.Grid[4].Icon);
			else if (sender == btn06)
				Spaces[5].Image = new UIImage(Memory.Grid[5].Icon);
			else if (sender == btn07)
				Spaces[6].Image = new UIImage(Memory.Grid[6].Icon);
			else if (sender == btn08)
				Spaces[7].Image = new UIImage(Memory.Grid[7].Icon);
			else if (sender == btn09)
				Spaces[8].Image = new UIImage(Memory.Grid[8].Icon);
			else if (sender == btn10)
				Spaces[9].Image = new UIImage(Memory.Grid[9].Icon);
			else if (sender == btn11)
				Spaces[10].Image = new UIImage(Memory.Grid[10].Icon);
			else if (sender == btn12)
				Spaces[11].Image = new UIImage(Memory.Grid[11].Icon);
		}

		public void HideSpaces()
		{
			for (int x = 0; x < Spaces.Count; x++)
				if (Memory.Grid[x].Revealed == false)
					Spaces[x].Image = new UIImage(Memory.Grid[x].Blank);
		}
    }
}