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
    public class AccountViewModel : ViewModelBase
    {
        /// <summary>
        /// Команда для перехода на домашнюю модель представления
        /// </summary>
        public ICommand NavigateHomeCommand { get; }

        public AccountViewModel(INavigationService homeNavigationService)
        {
            NavigateHomeCommand = new NavigateCommand(homeNavigationService);
        }
    }
}

