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
    [Register ("HighScoresScreen")]
    partial class HighScoresScreen
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHighScores { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblScores { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblHighScores != null) {
                lblHighScores.Dispose ();
                lblHighScores = null;
            }

            if (lblScores != null) {
                lblScores.Dispose ();
                lblScores = null;
            }
        }
    }
}