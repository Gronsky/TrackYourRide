using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using TrackYourRide.Core.ViewModels;
using UIKit;

namespace TrackYourRide.iOS.Views
{
    public partial class LoginView : MvxViewController<LoginViewModel>
    {
        public LoginView() : base("LoginView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<LoginView, LoginViewModel>();

            set.Bind(LoginButton)
               .To(vm => vm.LoginCommand);

            set.Apply();
        }
    }
}

