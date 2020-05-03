using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace TrackYourRide.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public IMvxCommand LoginCommand { get; private set; }

        public LoginViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            LoginCommand = new MvxCommand(Login);
        }

        private void Login()
        {
            _navigationService.Navigate<TrackViewModel>();
        }
    }
}
