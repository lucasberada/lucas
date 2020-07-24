using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicativo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSplash : ContentPage
    {
        public PageSplash()
        {
            InitializeComponent();
            Navegacao();
        }

        private async void Navegacao()
        {
            await Task.Delay(2300);
            App.Current.MainPage = new NavigationPage(new PageLogin());
        }
    }
}