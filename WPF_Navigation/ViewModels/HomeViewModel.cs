using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Navigation.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public string Title
        {
            get
            {
                return "Accueil";
            }
        }

        public string Content
        {
            get
            {
                return "Bienvenue dans l'application Artichaut !";
            }
        }
    }
}
