using NavigationMVVM.Services;
using NavigationMVVM.Stores;
using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace NavigationMVVM.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly LoginViewModel _viewModel;
        private readonly NavigationService<AccountViewModel> _navigationService;

        public LoginCommand(LoginViewModel viewModel, NavigationService<AccountViewModel> navigationService)
        {
            _viewModel = viewModel;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            /*тут можно реализовать логику для автаризации*/

            MessageBox.Show($"Logging in {_viewModel.Username}...");

            _navigationService

            //Преход на страницу учетной записи
            _navigationStore.CurrentViewModel = new AccountViewModel(_navigationStore);
        }
    }
}
