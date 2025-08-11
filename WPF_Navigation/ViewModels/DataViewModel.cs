using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Navigation.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            Items = new ObservableCollection<string>
            {
                "Élément 1", "Élément 2", "Élément 3"
            };
        }

        public string Title 
        {
            get 
            {
                return "Données"; 
            } 
        }

        public ObservableCollection<string> Items { get; }
    }
}
