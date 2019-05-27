using Krryp.MenuItems;
using Krryp.Models;
using Krryp.Modelss;
using Krryp.Vievs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Krryp
{
    
    public partial class MainPage1 : MasterDetailPage
    {

        public List<MasterPageItem> menuList { get; set; }

        public MainPage1()
        {
           
            InitializeComponent();
            

            


            menuList = new List<MasterPageItem>();
            
            var page1 = new MasterPageItem() { Title = "Wartości kryptowalut w realnym czasie", Icon = "icon.png", TargetType = typeof(MainPage) };
            var page2 = new MasterPageItem() { Title = "Kalkulator kryptowalut", Icon = "icon.png", TargetType = typeof(CalcPage) };
            var page3 = new MasterPageItem() { Title = "Informacje o kryptowalutach", Icon = "icon.png", TargetType = typeof(CrypPage) };
            var page4 = new MasterPageItem() { Title = "Ustawienia", Icon = "icon.png", TargetType = typeof(SettingsPage) };
            var page5 = new MasterPageItem() { Title = "Panel Admin", Icon = "icon.png", TargetType = typeof(AdminPage) };

            
  
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            if (LoginPage.isAdmin == true)
            {
                menuList.Add(page5);
            }




            navlist.ItemsSource = menuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage))) { Title = "KryptoMarket", BarBackgroundColor = Color.FromHex("#041D37") };
            this.BindingContext = new
            {
                Header = "Witamy w aplikacji KryptoMarket",
                Image = "https://cdn-images-1.medium.com/max/1600/1*Z4yGrc3ByFgtSfAVFXH7Dw.jpeg",
             
                Footer = "Witamy w aplikacji KryptoMarket"
            };

          
            
        }



        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page)) { Title = "KryptoMarket", BarBackgroundColor = Color.FromHex("#041D37") };
            IsPresented = false;

        }
      
    }
}