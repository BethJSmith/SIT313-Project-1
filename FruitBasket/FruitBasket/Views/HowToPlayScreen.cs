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
			string instructions = File.ReadAllText("Data/HowToPlay.txt");

			// Show instructions on screen
			lblInstructions.Text = instructions;
		}
    }
}