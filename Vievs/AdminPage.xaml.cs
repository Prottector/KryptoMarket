
using Krryp.Models;
using Krryp.Modelss;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Krryp.Vievs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminPage : ContentPage
    {
        string cryptoname;
        CrypCalcViewmodel vm;
        List<string> named = new List<string> { "Bitcoin", "Litecoin", "Ethereum", "Zcash", "Dash", "XRP" };
        private ObservableCollection<User> items = new ObservableCollection<User>();
       
      
        public AdminPage()
        {
            InitializeComponent();
            Init();
            BackgroundColor = Constants.BackgroundColorB;
            this.BindingContext = vm = new CrypCalcViewmodel()
            {
                NamesList = named
            };
            ListViewItems.RefreshCommand = new Command(() => {
                
                RefreshData();
                ListViewItems.IsRefreshing = false;
            });
            fade();
        }

      public void Init()
        {
            var enumerator = App.UserDatabase.GetUser();
            if (enumerator == null)
            {
                App.UserDatabase.SaveUser(new User { Id = 0, Username = "Andrzej", Password = "Andrzej" });
                enumerator = App.UserDatabase.GetUser();
            }

           
            while (enumerator.MoveNext())
            {
               
                if(!this.items.Contains(enumerator.Current))
                    this.items.Add(enumerator.Current);
            }
            ListViewItems.ItemsSource = this.items;
        }

        public void RefreshData()
        {
            var enumerator = App.UserDatabase.GetUser();
            this.items = new ObservableCollection<User>();
            while (enumerator.MoveNext())
            {

                if (!this.items.Contains(enumerator.Current))
                    this.items.Add(enumerator.Current);
            }
            ListViewItems.ItemsSource = null;
            ListViewItems.ItemsSource = this.items;

        }
        private void OnDelete(object sender, System.EventArgs e)
        {
            var item = (MenuItem)sender;
            var model = (User)item.CommandParameter;
            this.items.Remove(model);
            App.UserDatabase.DeleteUser(model.Id);
        }
        private void OnMore(object sender, System.EventArgs e)
        {
            var item = (MenuItem)sender;
            var model = (User)item.CommandParameter;
            App.UserDatabase.DeleteUser(model.Id);
        }
        void Maino_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Picker picker = (Picker)sender;
            if (picker.SelectedItem != null && !string.IsNullOrWhiteSpace(picker.SelectedItem.ToString()))
            {
                cryptoname = Maino.SelectedItem.ToString();
            }
        }
        void SecondPicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Picker picker = (Picker)sender;
            if (picker.SelectedItem != null && !string.IsNullOrWhiteSpace(picker.SelectedItem.ToString()))
            {
             
            }
        }
        private void EdyButton_Clicked(object sender, EventArgs e)
        {
        }
        private void DodButton_Clicked(object sender, EventArgs e)
        {
            App.UserDatabase.SaveUser(new User { Username = EditUsername.Text, Password = EditPassword.Text });
            DisplayAlert("Rejestracja", "Zarejestrowano użytkownika !", "OK");
            

        }
       
        
        private async void fade()
        {
            await Task.Delay(10);
            await st.FadeTo(1, 1200, Easing.Linear);
        }

    }
}