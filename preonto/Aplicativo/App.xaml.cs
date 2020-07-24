using Aplicativo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicativo
{
    public partial class App : Application
    {
        public static object Database { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new PageSplash();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
