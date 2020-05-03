using System;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace TrackYourRide.Core.ViewModels
{
    public class RegisterViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public IMvxCommand RegisterCommand { get; private set; }

        public RegisterViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            RegisterCommand = new MvxCommand(Register);
        }

        public void Register()
        {
            _navigationService.Navigate<TrackViewModel>();
        }
    }
}
