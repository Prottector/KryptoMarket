using Krryp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Krryp.Vievs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcPage : ContentPage
    {
        string cv;
        string curr;
        string cryp1;
        string cryp2;
        double bitDolc;
        double ethDolc;
        double ltcDolc;
        double zDolc;
        double dDolc;
        double xDolc;
        double bnbDolc;
        double bchDolc;
        double xmrDolc;
        double bsvDolc;
        double bitEur;
        double ethEur;
        double ltcEur;
        double zEur;
        double dEur;
        double xEur;
        double bnbEur;
        double bchEur;
        double xmrEur;
        double bsvEur;
        
        CrypCalcViewmodel vm;
        List<string> namesss = new List<string> { "Bitcoin", "Litecoin", "Ethereum", "Zcash", "Dash", "XRP","BNB","BCH","XMR","BSV" };
        



        public CalcPage()
        {

            


            InitializeComponent();
            Init();

            this.BindingContext = vm = new CrypCalcViewmodel()
            {
                NamesList = namesss
            };

            MainPickerCurrency.Items.Add("USD");
            MainPickerCurrency.Items.Add("EUR");
            st1.Opacity = 0;

            fade();

        }


        void Init()
        {
            BackgroundColor = Constants.BackgroundColorB;
            Count.Completed += (s, e) => OblButton_Clicked(s, e);
            Countt.Completed += (s, e) => Obl1Button_Clicked(s, e);


        }

        void Handle_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Picker picker = (Picker)sender;
            if (picker.SelectedItem != null)
            {
                cv = picker.SelectedItem.ToString();

            }
        }
        void MainPicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Picker picker = (Picker)sender;
            if (picker.SelectedItem != null && !string.IsNullOrWhiteSpace(picker.SelectedItem.ToString()))
            {
                cv = MainPicker.SelectedItem.ToString();
            }
        }

        void MainPickerCurrency_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Picker picker = (Picker)sender;
            if (picker.SelectedItem != null && !string.IsNullOrWhiteSpace(picker.SelectedItem.ToString()))
            {
                curr = MainPickerCurrency.SelectedItem.ToString();
            }
        }
        void SecondaryFirstPicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Picker picker = (Picker)sender;
            if (picker.SelectedItem != null && !string.IsNullOrWhiteSpace(picker.SelectedItem.ToString()))
            {
                cryp1 = SecondaryFirstPicker.SelectedItem.ToString();
            }
        }

        void SecondarySecondPicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Picker picker = (Picker)sender;
            if (picker.SelectedItem != null && !string.IsNullOrWhiteSpace(picker.SelectedItem.ToString()))
            {
                cryp2 = SecondarySecondPicker.SelectedItem.ToString();
            }
        }
        private void OblButton_Clicked(object sender, EventArgs e)
        {

            parsePrices();

            if (cv == "Bitcoin" && curr == "USD")
            {
                obli.Text = Calculations(bitDolc, 0);
            }

            else if (cv == "Ethereum" && curr == "USD")
            {
                obli.Text = Calculations(ethDolc, 0);
            }

            else if (cv == "Litecoin" && curr == "USD")
            {
                obli.Text = Calculations(ltcDolc, 0);
            }

            else if (cv == "Zcash" && curr == "USD")
            {
                obli.Text = Calculations(zDolc, 0);
            }
            else if (cv == "Dash" && curr == "USD")
            {
                obli.Text = Calculations(dDolc, 0);
            }

            else if (cv == "XRP" && curr == "USD")
            {
                obli.Text = Calculations(xDolc, 0);
            }
            else if (cv == "BNB" && curr == "USD")
            {
                obli.Text = Calculations(bnbDolc, 0);
            }
            else if (cv == "BCH" && curr == "USD")
            {
                obli.Text = Calculations(bchDolc, 0);
            }
            else if (cv == "XMR" && curr == "USD")
            {
                obli.Text = Calculations(xmrDolc, 0);
            }
            else if (cv == "BSV" && curr == "USD")
            {
                obli.Text = Calculations(bsvDolc, 0);
            }
            else if (cv == "Bitcoin" && curr == "EUR")
            {
                obli.Text = Calculations(bitEur, 1);
            }
            else if (cv == "Ethereum" && curr == "EUR")
            {
                obli.Text = Calculations(ethEur, 1);
            }

            else if (cv == "Litecoin" && curr == "EUR")
            {
                obli.Text = Calculations(ltcEur, 1);
            }

            else if (cv == "Zcash" && curr == "EUR")
            {
                obli.Text = Calculations(zEur, 1);
            }

            else if (cv == "Dash" && curr == "EUR")
            {
                obli.Text = Calculations(dEur, 1);
            }

            else if (cv == "XRP" && curr == "EUR")
            {
                obli.Text = Calculations(xEur, 1);
            }
            else if (cv == "BNB" && curr == "EUR")
            {
                obli.Text = Calculations(bnbEur, 1);
            }
            else if (cv == "BCH" && curr == "EUR")
            {
                obli.Text = Calculations(bchEur, 1);
            }
            else if (cv == "XMR" && curr == "EUR")
            {
                obli.Text = Calculations(xmrEur, 1);

            }
            else if (cv == "BSV" && curr == "EUR")
            {
                obli.Text = Calculations(bsvEur, 1);
            }
            else if (cv == null || curr == null)
            {
                DisplayAlert("Błąd", "Nie wybrano jednej z walut !", "OK");
            }




        }

        private void Obl1Button_Clicked(object sender, EventArgs e)
        {
            parsePrices();

            #region Bitcoin
            if (cryp1 == cryp2)
            {
                DisplayAlert("Błąd", "Przeliczanie tej samej waluty", "OK");
            }

            else if (cryp1 == "Bitcoin" && cryp2 == "Litecoin")
            {
                oblii.Text = CalculationsCross(bitDolc, ltcDolc, 1);
            }
            else if (cryp1 == "Bitcoin" && cryp2 == "Ethereum")
            {
                oblii.Text = CalculationsCross(bitDolc, ethDolc, 2);
            }
            else if (cryp1 == "Bitcoin" && cryp2 == "Zcash")
            {
                oblii.Text = CalculationsCross(bitDolc, zDolc, 3);
            }
            else if (cryp1 == "Bitcoin" && cryp2 == "Dash")
            {
                oblii.Text = CalculationsCross(bitDolc, dDolc, 4);
            }
            else if (cryp1 == "Bitcoin" && cryp2 == "XRP")
            {
                oblii.Text = CalculationsCross(bitDolc, xDolc, 5);
            }
            else if (cryp1 == "Bitcoin" && cryp2 == "BNB")
            {
                oblii.Text = CalculationsCross(bitDolc, bnbDolc, 6);
            }
            else if (cryp1 == "Bitcoin" && cryp2 == "BCH")
            {
                oblii.Text = CalculationsCross(bitDolc, bchDolc, 7);
            }
            else if (cryp1 == "Bitcoin" && cryp2 == "XMR")
            {
                oblii.Text = CalculationsCross(bitDolc, xmrDolc, 8);
            }
            else if (cryp1 == "Bitcoin" && cryp2 == "BSV")
            {
                oblii.Text = CalculationsCross(bitDolc, bsvDolc, 9);
            }
            #endregion
            #region Litecoin

            else if (cryp1 == "Litecoin" && cryp2 == "Bitcoin")
            {
                oblii.Text = CalculationsCross(ltcDolc, bitDolc, 0);
            }
            else if (cryp1 == "Litecoin" && cryp2 == "Ethereum")
            {
                oblii.Text = CalculationsCross(ltcDolc, ethDolc, 2);
            }
            else if (cryp1 == "Litecoin" && cryp2 == "Zcash")
            {
                oblii.Text = CalculationsCross(ltcDolc, zDolc, 3);

            }
            else if (cryp1 == "Litecoin" && cryp2 == "Dash")
            {
                oblii.Text = CalculationsCross(ltcDolc, dDolc, 4);

            }
            else if (cryp1 == "Litecoin" && cryp2 == "XRP")
            {
                oblii.Text = CalculationsCross(ltcDolc, xDolc, 5);

            }
            else if (cryp1 == "Litecoin" && cryp2 == "BNB")
            {
                oblii.Text = CalculationsCross(ltcDolc, bnbDolc, 6);

            }
            else if (cryp1 == "Litecoin" && cryp2 == "BCH")
            {
                oblii.Text = CalculationsCross(ltcDolc, bchDolc, 7);

            }
            else if (cryp1 == "Litecoin" && cryp2 == "XMR")
            {
                oblii.Text = CalculationsCross(ltcDolc, xmrDolc, 8);

            }
            else if (cryp1 == "Litecoin" && cryp2 == "BSV")
            {
                oblii.Text = CalculationsCross(ltcDolc, bsvDolc, 9);

            }

            #endregion
            #region ETHEREUM
            else if (cryp1 == "Ethereum" && cryp2 == "Bitcoin")
            {
                oblii.Text = CalculationsCross(ethDolc, bitDolc, 0);

            }
            else if (cryp1 == "Ethereum" && cryp2 == "Litecoin")
            {
                oblii.Text = CalculationsCross(ethDolc, ltcDolc, 1);

            }
            else if (cryp1 == "Ethereum" && cryp2 == "Zcash")
            {
                oblii.Text = CalculationsCross(ethDolc, zDolc, 3);

            }
            else if (cryp1 == "Ethereum" && cryp2 == "Dash")
            {
                oblii.Text = CalculationsCross(ethDolc, dDolc, 4);

            }
            else if (cryp1 == "Ethereum" && cryp2 == "XRP")
            {
                oblii.Text = CalculationsCross(ethDolc, xDolc, 5);

            }
            else if (cryp1 == "Ethereum" && cryp2 == "BNB")
            {
                oblii.Text = CalculationsCross(ethDolc, bnbDolc, 6);

            }
            else if (cryp1 == "Ethereum" && cryp2 == "BCH")
            {
                oblii.Text = CalculationsCross(ethDolc, bchDolc, 7);

            }
            else if (cryp1 == "Ethereum" && cryp2 == "XMR")
            {
                oblii.Text = CalculationsCross(ethDolc, xmrDolc, 8);

            }
            else if (cryp1 == "Ethereum" && cryp2 == "BSV")
            {
                oblii.Text = CalculationsCross(ethDolc, bsvDolc, 9);

            }
            #endregion
            #region ZCASH
            else if (cryp1 == "Zcash" && cryp2 == "Bitcoin")
            {
                oblii.Text = CalculationsCross(zDolc, bitDolc, 0);

            }
            else if (cryp1 == "Zcash" && cryp2 == "Litecoin")
            {
                oblii.Text = CalculationsCross(zDolc, ltcDolc, 1);

            }
            else if (cryp1 == "Zcash" && cryp2 == "Ethereum")
            {
                oblii.Text = CalculationsCross(zDolc, ethDolc, 2);

            }
            else if (cryp1 == "Zcash" && cryp2 == "Dash")
            {
                oblii.Text = CalculationsCross(zDolc, dDolc, 4);

            }
            else if (cryp1 == "Zcash" && cryp2 == "XRP")
            {
                oblii.Text = CalculationsCross(zDolc, xDolc, 5);

            }
            else if (cryp1 == "Zcash" && cryp2 == "BNB")
            {
                oblii.Text = CalculationsCross(zDolc, bnbDolc, 6);

            }
            else if (cryp1 == "Zcash" && cryp2 == "BCH")
            {
                oblii.Text = CalculationsCross(zDolc, bchDolc, 7);

            }
            else if (cryp1 == "Zcash" && cryp2 == "XMR")
            {
                oblii.Text = CalculationsCross(zDolc, xmrDolc, 8);

            }
            else if (cryp1 == "Zcash" && cryp2 == "BSV")
            {
                oblii.Text = CalculationsCross(zDolc, bsvDolc, 9);

            }
            #endregion
            #region DASH
            else if (cryp1 == "Dash" && cryp2 == "Bitcoin")
            {
                oblii.Text = CalculationsCross(dDolc, bitDolc, 0);

            }
            else if (cryp1 == "Dash" && cryp2 == "Litecoin")
            {
                oblii.Text = CalculationsCross(dDolc, ltcDolc, 1);

            }
            else if (cryp1 == "Dash" && cryp2 == "Ethereum")
            {
                oblii.Text = CalculationsCross(dDolc, ethDolc, 2);

            }

            else if (cryp1 == "Dash" && cryp2 == "Zcash")
            {
                oblii.Text = CalculationsCross(dDolc, zDolc, 3);

            }
            else if (cryp1 == "Dash" && cryp2 == "XRP")
            {
                oblii.Text = CalculationsCross(dDolc, xDolc, 5);

            }
            else if (cryp1 == "Dash" && cryp2 == "BNB")
            {
                oblii.Text = CalculationsCross(dDolc, bnbDolc, 6);

            }
            else if (cryp1 == "Dash" && cryp2 == "BCH")
            {
                oblii.Text = CalculationsCross(dDolc, bchDolc, 7);

            }
            else if (cryp1 == "Dash" && cryp2 == "XMR")
            {
                oblii.Text = CalculationsCross(dDolc, xmrDolc, 8);

            }
            else if (cryp1 == "Dash" && cryp2 == "BSV")
            {
                oblii.Text = CalculationsCross(dDolc, bsvDolc, 9);

            }


            #endregion
            #region XRP
            else if (cryp1 == "XRP" && cryp2 == "Bitcoin")
            {
                oblii.Text = CalculationsCross(xDolc, bitDolc, 0);

            }
            else if (cryp1 == "XRP" && cryp2 == "Litecoin")
            {
                oblii.Text = CalculationsCross(xDolc, ltcDolc, 1);

            }
            else if (cryp1 == "XRP" && cryp2 == "Ethereum")
            {
                oblii.Text = CalculationsCross(xDolc, ethDolc, 2);

            }
            else if (cryp1 == "XRP" && cryp2 == "Zcash")
            {
                oblii.Text = CalculationsCross(xDolc, zDolc, 3);

            }
            else if (cryp1 == "XRP" && cryp2 == "Dash")
            {
                oblii.Text = CalculationsCross(xDolc, dDolc, 4);

            }
            else if (cryp1 == "XRP" && cryp2 == "BNB")
            {
                oblii.Text = CalculationsCross(xDolc, bnbDolc, 6);

            }
            else if (cryp1 == "XRP" && cryp2 == "BCH")
            {
                oblii.Text = CalculationsCross(xDolc, bchDolc, 7);

            }
            else if (cryp1 == "XRP" && cryp2 == "XMR")
            {
                oblii.Text = CalculationsCross(xDolc, xmrDolc, 8);

            }
            else if (cryp1 == "XRP" && cryp2 == "BSV")
            {
                oblii.Text = CalculationsCross(xDolc, bsvDolc, 9);

            }
            #endregion
            #region BNB
            else if (cryp1 == "BNB" && cryp2 == "Bitcoin")
            {
                oblii.Text = CalculationsCross(bnbDolc, bitDolc, 0);

            }
            else if (cryp1 == "BNB" && cryp2 == "Litecoin")
            {
                oblii.Text = CalculationsCross(bnbDolc, ltcDolc, 1);

            }
            else if (cryp1 == "BNB" && cryp2 == "Ethereum")
            {
                oblii.Text = CalculationsCross(bnbDolc, ethDolc, 2);

            }
            else if (cryp1 == "BNB" && cryp2 == "Zcash")
            {
                oblii.Text = CalculationsCross(bnbDolc, zDolc, 3);

            }
            else if (cryp1 == "BNB" && cryp2 == "Dash")
            {
                oblii.Text = CalculationsCross(bnbDolc, dDolc, 4);

            }
            else if (cryp1 == "BNB" && cryp2 == "XRP")
            {
                oblii.Text = CalculationsCross(bnbDolc, xDolc, 5);

            }
            else if (cryp1 == "BNB" && cryp2 == "BCH")
            {
                oblii.Text = CalculationsCross(bnbDolc, bchDolc, 7);

            }
            else if (cryp1 == "BNB" && cryp2 == "XMR")
            {
                oblii.Text = CalculationsCross(bnbDolc, xmrDolc, 8);

            }
            else if (cryp1 == "BNB" && cryp2 == "BSV")
            {
                oblii.Text = CalculationsCross(bnbDolc, bsvDolc, 9);

            }



            #endregion
            #region BCH
            else if (cryp1 == "BCH" && cryp2 == "Bitcoin")
            {
                oblii.Text = CalculationsCross(bchDolc, bitDolc, 0);

            }
            else if (cryp1 == "BCH" && cryp2 == "Litecoin")
            {
                oblii.Text = CalculationsCross(bchDolc, ltcDolc, 1);

            }
            else if (cryp1 == "BCH" && cryp2 == "Ethereum")
            {
                oblii.Text = CalculationsCross(bchDolc, ethDolc, 2);

            }
            else if (cryp1 == "BCH" && cryp2 == "Zcash")
            {
                oblii.Text = CalculationsCross(bchDolc, zDolc, 3);

            }
            else if (cryp1 == "BCH" && cryp2 == "Dash")
            {
                oblii.Text = CalculationsCross(bchDolc, dDolc, 4);

            }
            else if (cryp1 == "BCH" && cryp2 == "XRP")
            {
                oblii.Text = CalculationsCross(bchDolc, xDolc, 5);

            }
            else if (cryp1 == "BCH" && cryp2 == "BNB")
            {
                oblii.Text = CalculationsCross(bchDolc, bnbDolc, 6);

            }
            else if (cryp1 == "BCH" && cryp2 == "XMR")
            {
                oblii.Text = CalculationsCross(bchDolc, xmrDolc, 8);

            }
            else if (cryp1 == "BCH" && cryp2 == "BSV")
            {
                oblii.Text = CalculationsCross(bchDolc, bsvDolc, 9);

            }
            #endregion
            #region XMR
            else if (cryp1 == "XMR" && cryp2 == "Bitecoin")
            {
                oblii.Text = CalculationsCross(xmrDolc, bitDolc, 0);

            }
            else if (cryp1 == "XMR" && cryp2 == "Litecoin")
            {
                oblii.Text = CalculationsCross(xmrDolc, ltcDolc, 1);

            }
            else if (cryp1 == "XMR" && cryp2 == "Ethereum")
            {
                oblii.Text = CalculationsCross(xmrDolc, ethDolc, 2);

            }
            else if (cryp1 == "XMR" && cryp2 == "Zcash")
            {
                oblii.Text = CalculationsCross(xmrDolc, zDolc, 3);

            }
            else if (cryp1 == "XMR" && cryp2 == "Dash")
            {
                oblii.Text = CalculationsCross(xmrDolc, dDolc, 4);

            }
            else if (cryp1 == "XMR" && cryp2 == "XRP")
            {
                oblii.Text = CalculationsCross(xmrDolc, xDolc, 5);

            }
            else if (cryp1 == "XMR" && cryp2 == "BNB")
            {
                oblii.Text = CalculationsCross(xmrDolc, bnbDolc, 6);

            }
            else if (cryp1 == "XMR" && cryp2 == "BCH")
            {
                oblii.Text = CalculationsCross(xmrDolc, bchDolc, 7);

            }
            else if (cryp1 == "XMR" && cryp2 == "BSV")
            {
                oblii.Text = CalculationsCross(xmrDolc, bsvDolc, 9);

            }
            #endregion
            #region BSV
            else if (cryp1 == "BSV" && cryp2 == "Bitcoin")
            {
                oblii.Text = CalculationsCross(bsvDolc, bitDolc, 0);

            }
            else if (cryp1 == "BSV" && cryp2 == "Litecoin")
            {
                oblii.Text = CalculationsCross(bsvDolc, ltcDolc, 1);

            }
            else if (cryp1 == "BSV" && cryp2 == "Ethereum")
            {
                oblii.Text = CalculationsCross(bsvDolc, ethDolc, 2);

            }
            else if (cryp1 == "BSV" && cryp2 == "Zcash")
            {
                oblii.Text = CalculationsCross(bsvDolc, zDolc, 3);

            }

            else if (cryp1 == "BSV" && cryp2 == "Dash")
            {
                oblii.Text = CalculationsCross(bsvDolc, dDolc, 4);

            }
            else if (cryp1 == "BSV" && cryp2 == "XRP")
            {
                oblii.Text = CalculationsCross(bsvDolc, xDolc, 5);

            }
            else if (cryp1 == "BSV" && cryp2 == "BNB")
            {
                oblii.Text = CalculationsCross(bsvDolc, bnbDolc, 6);

            }
            else if (cryp1 == "BSV" && cryp2 =="BCH")
            {
                oblii.Text = CalculationsCross(bsvDolc, bchDolc, 7);

            }
            else if (cryp1 == "BSV" && cryp2 == "XMR")
            {
                oblii.Text = CalculationsCross(bsvDolc, xmrDolc, 8);

            }
            #endregion
            else if (cryp1 == null && cryp2 == null)
            {
                DisplayAlert("Błąd", "Nie wybrano jednej z walut !", "OK");

            }

        }

        private string Calculations(double crypToValue,int currencyIndex)
        {
            string result;
            List<string> currencies = new List<string> { "$", "\u20AC" };
            if (Count.Text == null)
            {
                DisplayAlert("Błąd", "Proszę wpisać wartość !", "OK");
                result = "";
                return result;
            }
            else
            {
                result = "Obliczona wartość: " + (crypToValue * double.Parse(Count.Text)).ToString() + currencies.ElementAt(currencyIndex);
            }
                return result;
            



        }

        private string CalculationsCross(double firstCryp, double secCryp, int shortcutIndex)
        {
            string result;
            List<string> shortcuts = new List<string> { " BTC", " LTC", " ETH", " ZC", " DASH", " XRP","BNB","BCH","XMR","BSV" };

            if (Countt.Text == null)
            {
                DisplayAlert("Błąd", "Proszę wpisać wartość !", "OK");
                result = "";
                return result;
            }
            else
            {
                result = "Obliczona wartość: " + Math.Round(((firstCryp * double.Parse(Countt.Text)) / secCryp), 3).ToString() + shortcuts.ElementAt(shortcutIndex);

                return result;
            }


        }

        private void parsePrices()
        {
            bitDolc = double.Parse(CrypValues.BitcoinDolc, CultureInfo.InvariantCulture);
            ethDolc = double.Parse(CrypValues.EthereumDolc, CultureInfo.InvariantCulture);
            ltcDolc = double.Parse(CrypValues.LitecoinDolc, CultureInfo.InvariantCulture);
            zDolc = double.Parse(CrypValues.ZcashDolc, CultureInfo.InvariantCulture);
            dDolc = double.Parse(CrypValues.DashDolc, CultureInfo.InvariantCulture);
            xDolc = double.Parse(CrypValues.XrpDolc, CultureInfo.InvariantCulture);
            bnbDolc = double.Parse(CrypValues.BnbDolc, CultureInfo.InvariantCulture);
            bchDolc = double.Parse(CrypValues.BchDolc, CultureInfo.InvariantCulture);
            xmrDolc = double.Parse(CrypValues.XmrDolc, CultureInfo.InvariantCulture);
            bsvDolc = double.Parse(CrypValues.BsvDolc, CultureInfo.InvariantCulture);

            bitEur = double.Parse(CrypValues.BitcoinEur, CultureInfo.InvariantCulture);
            ethEur = double.Parse(CrypValues.EthereumEur, CultureInfo.InvariantCulture);
            ltcEur = double.Parse(CrypValues.LitecoinEur, CultureInfo.InvariantCulture);
            zEur = double.Parse(CrypValues.ZcashEur, CultureInfo.InvariantCulture);
            dEur = double.Parse(CrypValues.DashEur, CultureInfo.InvariantCulture);
            xEur = double.Parse(CrypValues.XrpEur, CultureInfo.InvariantCulture);
            bnbEur = double.Parse(CrypValues.BnbEur, CultureInfo.InvariantCulture);
            bchEur = double.Parse(CrypValues.BchEur, CultureInfo.InvariantCulture);
            xmrEur = double.Parse(CrypValues.XmrEur, CultureInfo.InvariantCulture);
            bsvEur = double.Parse(CrypValues.BsvEur, CultureInfo.InvariantCulture);
        }

        private async void fade()
        {
            await Task.Delay(10);
            await st1.FadeTo(1, 1200, Easing.Linear);
        }
    }
}