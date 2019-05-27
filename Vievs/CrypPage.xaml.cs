using Krryp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Krryp.Vievs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrypPage : ContentPage
    {
        CrypVievmodel vm;


        public CrypPage()
        {
            
            InitializeComponent();
            Init();
            vm = new CrypVievmodel();
            BindingContext = vm;
            s1.Opacity = 0;
            fade();
           


        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColorB;
        }

        private async void fade()
        {
            await Task.Delay(10);
            await s1.FadeTo(1, 1200, Easing.Linear);
        }


    }
}








