using MVVMEssentials.Commands;
using MVVMEssentials.Services;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFNavigationDemo.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        /// <summary>
        /// Команда для перехода на модель представления аккаунта
        /// </summary>
        public ICommand NavigateAccountCommand { get; }

        public HomeViewModel(INavigationService accountNavigationService)
        {
            NavigateAccountCommand = new NavigateCommand(accountNavigationService);
        }
    }
}
