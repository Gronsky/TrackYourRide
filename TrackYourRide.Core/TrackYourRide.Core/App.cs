using MvvmCross;
using MvvmCross.ViewModels;
using TrackYourRide.Core.Services;
using TrackYourRide.Core.ViewModels;

namespace TrackYourRide.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ITrackService, TrackService>();

            RegisterAppStart<StartViewModel>();
        }
    }
}
