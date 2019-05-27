using Krryp.Models;
using Krryp.Modelss;
using Krryp.Vievs;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Krryp.Data;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Krryp.Vievs
{
    [DesignTimeVisible(true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public static bool isAdmin;
       

        public LoginPage()
        {

            InitializeComponent();

            Init();


            st1.FadeTo(1, 3000, Easing.Linear);




        }

        void Init()
        {
            ActivitySpinner.IsVisible = false;

            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => LogButton_Clicked(s, e);
            Constants.BackgroundColorB = Color.FromRgb(43, 75, 111);
            BackgroundColor = Constants.BackgroundColorB;
            st1.Opacity = 0;
            App.UserDatabase.GetUser();
            var properties = App.Current.Properties;
            if (properties.ContainsKey("username"))
            {
                Entry_Username.Text = (string)properties["username"];
            }


        }

        private async void LogButton_Clicked(object sender, EventArgs e)
        {

            var query = GetConnection().Table<User>();
            var properties = App.Current.Properties;
            if (!properties.ContainsKey("username")) 
{
                properties.Add("username", Entry_Username.Text);
            }
            else
            {
                properties["username"] = Entry_Username.Text;
            }

            if (Entry_Username.Text == "" || Entry_Password.Text == "")
            {
                await DisplayAlert("Logowanie", "Logowanie nie powiodło się, pusty login lub hasło", "OK");
            }
            else
            {

                foreach (var usr in query)
                {

                    if (Entry_Username.Text == usr.Username && Entry_Password.Text == usr.Password)
                    {
                        if (Entry_Username.Text == "admin" && Entry_Password.Text == "admin")
                        {
                            isAdmin = true;
                        }
                        else
                            isAdmin = false;
                        ActivitySpinner.IsRunning = true;
                        ActivitySpinner.IsVisible = true;
                        await st1.FadeTo(0, 2000, Easing.Linear);

                        await Navigation.PushModalAsync(new MainPage1());

                        ActivitySpinner.IsVisible = false;
                        ActivitySpinner.IsRunning = false;
                        await st1.FadeTo(1, 1, Easing.Linear);

                    }
                }
            }
            
           
                    

             

            
        }
        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            User userr = new User(Entry_Username.Text, Entry_Password.Text);
            ActivitySpinner.IsRunning = true;
            ActivitySpinner.IsVisible = true;
            if (userr.CheckInfo())
            {
                App.UserDatabase.SaveUser(userr);
                await DisplayAlert("Rejestracja", "Zarejestrowano użytkownika !", "OK");

            }
            else
            {
                await DisplayAlert("Rejestracja", "Rejestracja nie powiodła się, pusty login lub hasło", "OK");
            }
            ActivitySpinner.IsVisible = false;
            ActivitySpinner.IsRunning = false;
            await st1.FadeTo(1, 1, Easing.Linear);



        }

        private async void GuestButton_Clicked(object sender, EventArgs e)
        {
            ActivitySpinner.IsRunning = true;
            ActivitySpinner.IsVisible = true;
            await st1.FadeTo(0, 2000, Easing.Linear);

            await Navigation.PushModalAsync(new MainPage());

            ActivitySpinner.IsVisible = false;
            ActivitySpinner.IsRunning = false;
            await st1.FadeTo(1, 1, Easing.Linear);



        }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFileName = "UserDB.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }


    }
}