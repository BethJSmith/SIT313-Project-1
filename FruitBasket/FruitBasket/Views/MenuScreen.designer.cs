// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FruitBasket
{
    [Register ("MenuScreen")]
    partial class MenuScreen
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnHighScores { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnHowToPlay { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnNewGame { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnHighScores != null) {
                btnHighScores.Dispose ();
                btnHighScores = null;
            }

            if (btnHowToPlay != null) {
                btnHowToPlay.Dispose ();
                btnHowToPlay = null;
            }

            if (btnNewGame != null) {
                btnNewGame.Dispose ();
                btnNewGame = null;
            }
        }
    }
}