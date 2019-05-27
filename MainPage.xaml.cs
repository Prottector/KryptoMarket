using Krryp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Krryp
{
    public partial class MainPage : ContentPage
    {
    
        public MainPage()
        {


            
            InitializeComponent();
            GetJs();


            button.Clicked += Button_Clicked;
            Init();



            fade();

        }



        void Init()
        {
            
            BackgroundColor = Constants.BackgroundColorB;
            st1.Opacity = 0;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            
            await DisplayAlert("Odświeżanie", "Odświeżono", "OK");
            GetJs();
            


        }

        public async void GetJs()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://min-api.cryptocompare.com/data/pricemulti?fsyms=BTC,ETH,LTC,ZEC,DASH,XRP,BNB,BCH,XMR,BSV&tsyms=USD,EUR&api_key={f4bd34b64d1ca588c159394ef77160ff2cc42c22b6a5be899e0d89e2de768917}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            CrypValues cryp = JsonConvert.DeserializeObject<CrypValues>(responseBody);
            JObject s = JObject.Parse(responseBody);
            CrypValues.BitcoinDolc = (string)s["BTC"]["USD"];
            CrypValues.BitcoinEur = (string)s["BTC"]["EUR"];

            CrypValues.EthereumDolc = (string)s["ETH"]["USD"];
            CrypValues.EthereumEur = (string)s["ETH"]["EUR"];

            CrypValues.LitecoinDolc = (string)s["LTC"]["USD"];
            CrypValues.LitecoinEur = (string)s["LTC"]["EUR"];

            CrypValues.ZcashDolc = (string)s["ZEC"]["USD"];
            CrypValues.ZcashEur = (string)s["ZEC"]["EUR"];

            CrypValues.DashDolc = (string)s["DASH"]["USD"];
            CrypValues.DashEur = (string)s["DASH"]["EUR"];

            CrypValues.XrpDolc = (string)s["XRP"]["USD"];
            CrypValues.XrpEur = (string)s["XRP"]["EUR"];

            CrypValues.BnbDolc = (string)s["BNB"]["USD"];
            CrypValues.BnbEur = (string)s["BNB"]["EUR"];

            CrypValues.BchDolc = (string)s["BCH"]["USD"];
            CrypValues.BchEur = (string)s["BCH"]["EUR"];

            CrypValues.XmrDolc = (string)s["XMR"]["USD"];
            CrypValues.XmrEur = (string)s["XMR"]["EUR"];

            CrypValues.BsvDolc = (string)s["BSV"]["USD"];
            CrypValues.BsvEur = (string)s["BSV"]["EUR"];


            Ex1.Text = "Bitcoin " + Environment.NewLine + "\t \t \t \t \t Wartość $:  " + CrypValues.BitcoinDolc + "$"
                + Environment.NewLine + "\t \t \t \t \t Wartość \u20AC:  " + CrypValues.BitcoinEur + "\u20AC";

            Ex2.Text = "Litecoin " + Environment.NewLine + "\t \t \t \t \t Wartość $:  " + CrypValues.LitecoinDolc + "$"
                + Environment.NewLine + "\t \t \t \t \t Wartość \u20AC:  " + CrypValues.LitecoinEur + "\u20AC";

            Ex3.Text = "Ethereum " + Environment.NewLine + "\t \t \t \t \t Wartość $:  " + CrypValues.EthereumDolc + "$"
                + Environment.NewLine + "\t \t \t \t \t Wartość \u20AC  " + CrypValues.EthereumEur + "\u20AC";

            Ex4.Text = "Zcash " + Environment.NewLine + "\t \t \t \t \t Wartość $:  " + CrypValues.ZcashDolc + "$"
                + Environment.NewLine + "\t \t \t \t \t Wartość \u20AC:  " + CrypValues.ZcashEur + "\u20AC";

            Ex5.Text = "Dash " + Environment.NewLine + "\t \t \t \t \t Wartość $:  " + CrypValues.DashDolc + "$"
                + Environment.NewLine + "\t \t \t \t \t Wartość \u20AC:  " + CrypValues.DashEur + "\u20AC";

            Ex6.Text = "XRP " + Environment.NewLine + "\t \t \t \t \t Wartość $:  " + CrypValues.XrpDolc + "$"
                + Environment.NewLine + "\t \t \t \t \t Wartość \u20AC:  " + CrypValues.XrpEur + "\u20AC";

            Ex7.Text = "BNB " + Environment.NewLine + "\t \t \t \t \t Wartość $:  " + CrypValues.BnbDolc + "$"
                + Environment.NewLine + "\t \t \t \t \t Wartość \u20AC:  " + CrypValues.BnbEur + "\u20AC";

            Ex8.Text = "BCH " + Environment.NewLine + "\t \t \t \t \t Wartość $:  " + CrypValues.BchDolc + "$"
                + Environment.NewLine + "\t \t \t \t \t Wartość \u20AC:  " + CrypValues.BchEur + "\u20AC";

            Ex9.Text = "XMR " + Environment.NewLine + "\t \t \t \t \t Wartość $:  " + CrypValues.XmrDolc + "$"
                + Environment.NewLine + "\t \t \t \t \t Wartość \u20AC:  " + CrypValues.XmrEur + "\u20AC";

            Ex10.Text = "BSV " + Environment.NewLine + "\t \t \t \t \t Wartość $:  " + CrypValues.BsvDolc + "$"
                + Environment.NewLine + "\t \t \t \t \t Wartość \u20AC:  " + CrypValues.BsvEur + "\u20AC";
        }

        private async void fade()
        {
            await Task.Delay(10);
            await st1.FadeTo(1, 1200, Easing.Linear);
        }

        

       
        
    }
}
