using NavigationMVVM.Stores;
using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace NavigationMVVM.Commands
{
    /// <summary>
    /// Универсальная команда для навигации
    /// </summary>
    /// <typeparam name="TViewModel">Обобщенный тип для модели представления на которую нужно будет перейти</typeparam>
    class NavigateCommand<TViewModel> : CommandBase
        where TViewModel : ViewModelBase/*Ограничение для обобщенного типа, принимаемое значение должно быть классом наследуемым от Базовой модели представления*/
    {
        

        private readonly NavigationService<TViewModel> _navigationService;

        public NavigateCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {

        }
    }
}
