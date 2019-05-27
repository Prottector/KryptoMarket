using Krryp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Krryp.Vievs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            Init();
            ob1.Clicked += ob1_Clicked;
            ob1.Clicked += ob2_Clicked;

        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColorB;
        }
        private  void ob1_Clicked(object sender, EventArgs e)
        {

            Constants.BackgroundColorB = Color.FromRgb(255, 255, 255);
            BackgroundColor = Constants.BackgroundColorB; ;
            DisplayAlert("Zmiana trybu", "Tryb jasny", "OK");
            



        }

        private async void ob2_Clicked(object sender, EventArgs e)
        {

            Constants.BackgroundColorB = Color.FromRgb(43, 75, 111);
            BackgroundColor = Constants.BackgroundColorB;
            await DisplayAlert("Zmiana trybu", "Tryb jasny", "OK");
            




        }
    }
}