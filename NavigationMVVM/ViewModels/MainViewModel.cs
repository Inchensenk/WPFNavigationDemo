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
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

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
