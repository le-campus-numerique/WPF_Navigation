using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Navigation.Commands;

namespace WPF_Navigation.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {       
        public MainViewModel()
        {
            // Initialisation des ViewModels
            HomeViewModel = new HomeViewModel();
            SettingsViewModel = new SettingsViewModel();
            DataViewModel = new DataViewModel();

            // Initialisation des commands
            NavigateToHomeCommand = new RelayCommand(() => CurrentViewModel = HomeViewModel);
            NavigateToSettingsCommand = new RelayCommand(() => CurrentViewModel = SettingsViewModel);
            NavigateToDataCommand = new RelayCommand(() => CurrentViewModel = DataViewModel);

            // Vue settée par défaut
            CurrentViewModel = HomeViewModel;
        }

        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                SetProperty(ref _currentViewModel, value);
            }
        }

        public HomeViewModel HomeViewModel { get; }
        public SettingsViewModel SettingsViewModel { get; }
        public DataViewModel DataViewModel { get; }

        public ICommand NavigateToHomeCommand { get; }
        public ICommand NavigateToSettingsCommand { get; }
        public ICommand NavigateToDataCommand { get; }
    }
}
