using NavigationMVVM.Stores;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationMVVM.ViewModels
{
    /// <summary>
    /// Основная модель представления
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;

        /// <summary>
        /// Получаем текущую модель представления из хранилища навигации
        /// </summary>
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;/*Текущее свойство вью модел в основной модели просмотра, которое определяет представление для приложения*/

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}

/*2 и наша основная модель просмотра прослушивает это событие. Мы вызываем его OnPropertyChanged(nameof(CurrentViewModel)); 
 * при изменении свойства для текущей модели просмотра CurrentViewModel => _navigationStore.CurrentViewModel; а затем наше представление меняется*/
