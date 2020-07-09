using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
            navegacao();


        }

        private async void navegacao()
        {
            await Task.Delay(3000);

            App.Current.MainPage = new NavigationPage(new LoginView());
        }
    }
}
