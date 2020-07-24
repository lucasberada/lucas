using Aplicativo.Models;
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
    public partial class PrincipalView : ContentPage
    {
        public PrincipalView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);

          


        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("PARABENS", "Voce comprou o ingresso.", "ok");
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await DisplayAlert("PARABENS", "Voce comprou o ingresso.", "ok");
        }

        async void Button_Clicked_2(object sender, EventArgs e)
        {
            await DisplayAlert("PARABENS", "Voce comprou o ingresso.", "ok");
        }
    }
}