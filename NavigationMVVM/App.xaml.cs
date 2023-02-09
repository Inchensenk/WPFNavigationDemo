using NavigationMVVM.Stores;
using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NavigationMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            
            NavigationStore navigationStore = new NavigationStore();/*создаем экземпляр класса хранящии текущую модель представления*/

            navigationStore.CurrentViewModel = new HomeViewModel(navigationStore);/*устанавливаем текущую модель просмотра в начале приложения на модель просмотра учетной записи*/
            
            MainWindow = new MainWindow()/*Главное окно*/
            { 
                //Контекст данных для главного окна, основная модель просмотра
                DataContext= new MainViewModel(navigationStore)
            };
            //Показываем главное окно
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
