using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using TrackYourRide.Core.ViewModels;
using UIKit;

namespace TrackYourRide.iOS.Views
{
    public partial class RegisterView : MvxViewController<RegisterViewModel>
    {
        public RegisterView() : base("RegisterView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<RegisterView, RegisterViewModel>();

            set.Bind(RegisterButton)
               .To(vm => vm.RegisterCommand);

            set.Apply();
        }
    }
}

