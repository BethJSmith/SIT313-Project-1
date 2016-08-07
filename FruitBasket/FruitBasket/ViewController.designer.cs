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
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnStart { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgFruitBasket { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgLogo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTapToStart { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnStart != null) {
                btnStart.Dispose ();
                btnStart = null;
            }

            if (imgFruitBasket != null) {
                imgFruitBasket.Dispose ();
                imgFruitBasket = null;
            }

            if (imgLogo != null) {
                imgLogo.Dispose ();
                imgLogo = null;
            }

            if (lblTapToStart != null) {
                lblTapToStart.Dispose ();
                lblTapToStart = null;
            }
        }
    }
}