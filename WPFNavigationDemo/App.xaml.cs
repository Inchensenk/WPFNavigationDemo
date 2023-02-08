using MVVMEssentials.Services;
using MVVMEssentials.Stores;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFNavigationDemo.ViewModels;

namespace WPFNavigationDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public App()
        {
            _navigationStore= new NavigationStore();
            _modalNavigationStore= new ModalNavigationStore();

        }


        /// <summary>
        /// Переопределяем запуск приложения
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            INavigationService navigationService = CreateHomeNavigationService();
            navigationService.Navigate();

            //Модель основного вида
            MainWindow = new MainWindow()
            {
                DataContext=new MainViewModel(_navigationStore, _modalNavigationStore)            
            };

            MainWindow.Show();

            base.OnStartup(e);

        }

        private INavigationService CreateHomeNavigationService()
        {
            return new NavigationService<HomeViewModel>(_navigationStore, CreateHomeVievModel);
        }

        private HomeViewModel CreateHomeVievModel()
        {
            return new HomeViewModel(CreateAccountNavigationServise());
        }



        private INavigationService CreateAccountNavigationServise()
        {
            return new NavigationService<AccountViewModel>(_navigationStore, CreateAccountViewModel);
        }

        private AccountViewModel CreateAccountViewModel()
        {
            return new AccountViewModel(CreateHomeNavigationService());
        }
    }
}
