using System;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace TrackYourRide.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public IMvxCommand ToLoginCommand { get; private set; }
        public IMvxCommand ToRegisterCommand { get; private set; }

        public StartViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            ToLoginCommand = new MvxCommand(ToLoginPage);
            ToRegisterCommand = new MvxCommand(ToRegisterPage);
        }  

        private void ToLoginPage()
        {
            _navigationService.Navigate<LoginViewModel>();
        }

        private void ToRegisterPage()
        {
            _navigationService.Navigate<RegisterViewModel>();
        }
    }
}
