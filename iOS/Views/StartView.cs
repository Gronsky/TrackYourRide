using System;
using MvvmCross.Platforms.Ios.Views;
using TrackYourRide.Core.ViewModels;
using UIKit;

namespace TrackYourRide.iOS.Views
{
    public partial class StartView : MvxViewController<StartViewModel>
    {
        public StartView() : base("StartView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}

