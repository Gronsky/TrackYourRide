using MvvmCross.Binding.BindingContext;
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

            var set = this.CreateBindingSet<StartView, StartViewModel>();

            set.Bind(ToLoginButton).To(vm => vm.ToLoginCommand);

            set.Bind(ToRegisterButton).To(vm => vm.ToRegisterCommand);

            set.Apply();
        }
    }
}

