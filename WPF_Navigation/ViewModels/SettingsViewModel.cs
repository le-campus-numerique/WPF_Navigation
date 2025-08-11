using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Navigation.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        public string Title => "Paramètres";

        private bool _isDarkMode;
        public bool IsDarkMode
        {
            get => _isDarkMode;
            set => SetProperty(ref _isDarkMode, value);
        }
    }
}
