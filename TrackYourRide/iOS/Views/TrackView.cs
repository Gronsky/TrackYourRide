using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using TrackYourRide.Core.ViewModels;
using UIKit;

namespace TrackYourRide.iOS.Views
{
    public partial class TrackView : MvxViewController<TrackViewModel>
    {
        public TrackView() : base("TrackView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<TrackView, TrackViewModel>();

            set.Bind(TimeLabel).To(vm => vm.Time);
            set.Bind(AvgSpeedLabel).To(vm => vm.AvgSpeed);
            set.Bind(DistanceLabel).To(vm => vm.Distance);
            set.Bind(StartButton).To(vm => vm.StartCommand);

            set.Apply();
        }
    }
}

