using Aplicativo.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicativo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCadastro : ContentPage
    {
        public PageCadastro()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        void btnLogin_Clicked(object sender, EventArgs args)
        {
            App.Current.MainPage = new NavigationPage(new PageLogin());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDataBase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<Usuario>();

            var item = new Usuario()
            {
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("parabens", "vc se cadastrou", "comfirma", "cancela");

                if (result)
                    await Navigation.PushAsync(new PageLogin());
            });
        }
    }

       
    }
