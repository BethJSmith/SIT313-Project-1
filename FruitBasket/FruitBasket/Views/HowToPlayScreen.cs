using Foundation;
using System;
using System.IO;
using UIKit;

namespace FruitBasket
{
    public partial class HowToPlayScreen : UIViewController
    {
        public HowToPlayScreen (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			// Read instructions from file
			string instructions = File.ReadAllText(Constants.HOW_TO_PLAY_FILE);

			// Show instructions on screen
			lblInstructions.Text = instructions;
		}
    }
}