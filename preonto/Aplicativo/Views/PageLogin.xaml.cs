using Aplicativo.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicativo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLogin : ContentPage
    {
        public PageLogin()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDataBase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<Usuario>().Where(u => u.Email.Equals(EntryEmail.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if (myquery != null)
            {
                App.Current.MainPage = new NavigationPage(new PageAbout());

            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("error", "coloque seu email e senha", "yes", "cancel");

                    if (result)
                        await Navigation.PushAsync(new PageLogin());
                    else
                    {
                        await Navigation.PushAsync(new PageLogin());
                    }
                });
            }

          
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new PageCadastro());
        }
    }
}