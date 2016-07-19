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

			Memory = new Game();
			Spaces = new List<UIImageView>()
			{
				img01, img02, img03,
				img04, img05, img06,
				img07, img08, img09,
				img10, img11, img12
			};

			for (int x = 0; x < Spaces.Count; x++)
			{
				Spaces[x].Image = new UIImage(Memory.grid[x].icon);
			}
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}