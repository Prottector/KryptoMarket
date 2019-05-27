using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Krryp.Models
{
	public class CrypTypes : ContentPage
	{
		
        public string CrypName { get; set; }
        public string CrypDesc { get; set; }
        public string ImageUrl { get; set; }
        public string Value { get; set; }

        public List<CrypTypes> GetCrypTypes()
        {
            List<CrypTypes> Cryptyp = new List<CrypTypes>()
            {
                new CrypTypes()
                {
                    CrypName = "Bitcoin", CrypDesc="Kryptowaluta wprowadzona w 2009 roku przez osobę (bądź grupę osób) o pseudonimie Satoshi Nakamoto. Nazwa odnosi się także do używającego jej otwartoźródłowego oprogramowania oraz sieci peer-to-peer, którą formuje. Prywatne klucze kryptograficzne których używa się do autoryzowania transakcji, mogą zostać zapisane na komputerze osobistym w stworzonym do tego celu oprogramowaniu, w przeznaczonej do tego aplikacji na smartfonie, lub w tzw. portfelu sprzętowym.",ImageUrl = "https://en.bitcoin.it/w/images/en/2/29/BC_Logo_.png"
                },
                new CrypTypes()
                {
                    CrypName = "Litecoin", CrypDesc="Kryptowaluta, a także otwartoźródłowy projekt na licencji X11. Zainspirowany i niemal identyczny technicznie jak bitcoin, litecoin jest tworzony i przekazywany bez udziału centralnego emitenta. Różni się on od bitcoina trzema podstawowymi cechami:" + Environment.NewLine + "Sieć przetwarza blok co 2,5minuty" + Environment.NewLine + "Sieć wyprodukuje 84 miliony litecoinów czyli 4x tyle co bitcoin" + Environment.NewLine + "Litecoin opiera się na Scrypt jako matematycznym dowodzie wykonywanych działań" ,ImageUrl = "https://atlas.bitmarket.pl/wp-content/uploads/2018/06/ltclogo.jpg"
                },
                new CrypTypes()
                {
                    CrypName = "Ethereum", CrypDesc="Ethereum (ETH) jest zarazem platformą walutową, jak i specyficznym językiem oprogramowania. Łączy w sobie zalety protokółów opartych na oryginalnym bitocoinie oraz innych kryptowalutach, a zarazem oferuje większą dowolność oraz sporo specjalnych funkcjonalności. W założeniach pozwala na budowanie różnego rodzaju aplikacji, a następnie udostępnienie ich. System korzysta z kryptowaluty stanowiącej medium wymiany w rozproszonej sieci potencjalnych odbiorców aplikacji stworzonych całkowicie niezależnie.",ImageUrl = "https://rlv.zcache.com/ethereum_black_logo_sticker-r5bb44ca6704f43128657121253960b0c_v9waf_8byvr_400.jpg"
                },
                 new CrypTypes()
                {
                    CrypName = "Zcash", CrypDesc="w skrócie ZEC powstało jako pierwowzór kryptowalut. Obecnie jest to kryptowaluta o zdecentralizowanym charakterze peer-to-peer, dzięki czemu gwarantuje pełną anonimowość podejmującym transakcje uczestnikom.",ImageUrl = "https://www.servethehome.com/wp-content/uploads/2017/02/Zcash-Logo-for-STH.png"
                },
                  new CrypTypes()
                {
                    CrypName = "Dash", CrypDesc="Dash nazywany Digital Cash, jest kryptowalutą peer-to-peer skoncentrowaną na branży płatności, opierającą się na otwartym kodzie źródłowym. Projekt Dash bazuje na podobnych założeniach jak Bitcoin, ale z bardziej rozbudowaną funkcjonalnością. Kryptowaluta oferuje system płatności natychmiastowych – InstantSend oraz transakcje prywatne – PrivateSend. Dash jest też jedną z pierwszych zdecentralizowanych i autonomicznych organizacji (DAO).",ImageUrl = "https://media.dash.org/wp-content/uploads/dash-D-blue.png"
                },
                   new CrypTypes()
                {
                    CrypName = "XRP", CrypDesc="XRP to system rozliczeń brutto w czasie rzeczywistym (RTGS), sieć wymiany walut i przekazów pieniężnych. Nazywany również Ripple Transaction Protocol ( RTXP ) lub protokołem Ripple. Zbudowany jest na rozproszonym protokole internetowym typu open source. Celem XRP jest zapewnienie bezpiecznych, błyskawicznych i niemal bezpłatnych transakcji o zasięgu globalnym. Projekt skierowany jest głównie do instytucji z sektora bankowego.",ImageUrl = "https://bitbay.net/images/d/8/8/9/3/d8893e93604201b94a782e6d0f0b45f4e707b37d-xrp350.png"
                },
                    new CrypTypes()
                {
                    CrypName = "Binance Coin", CrypDesc="Binance coin jest tokenem stworzonym przez deweloperów jednej z największej giełdy pod względem wolumenu na świecie – Binance. Binance coin jest tokenem w formacie ERC20. Jednak z biegiem czasu stanie się samodzielną kryptowalutą z własnym blockchainem co zdecydowanie pozwoli mu na mocniejszy rozwój i większą niezależność.",ImageUrl = "https://bithub.pl/wp-content/uploads/2018/06/Binance-Coin.png"
                },
                     new CrypTypes()
                {
                    CrypName = "Bitcoin Cash", CrypDesc="kryptowaluta, która powstała 1 sierpnia 2017 roku po rozłamie głównego łańcucha Bitcoina. Rozłam ten nastąpił wskutek braku porozumienia w społeczności odnośnie sposobu skalowania i dalszego rozwoju projektu Bitcoin.Bitcoin Cash (BCH) wykorzystuje technologię blockchain i ten sam algorytm co pierwotny Bitcoin (SHA-256), jednak w odróżnieniu do Bitcoina (BTC) zwiększył rozmiary bloków",ImageUrl = "https://www.bitcoin.com/bitcoin-cash-brand/img/bch-logo-horizontal-primary.jpg"
                },
                      new CrypTypes()
                {
                    CrypName = "Monero", CrypDesc="Monero (XMR) jest otwarto-źródłową kryptowalutą zapewniającą użytkownikom wysoki poziom prywatności. Obecnie jedna z najpopularniejszych kryptowalut. W listopadzie 2017 roku jej kapitalizacja rynkowa wyniosła 1,5 miliarda dolarów. Kryptowaluta XMR jest rozwijana zgodnie z założeniami ruchu Open Source. Oznacza to, że wpływ na budowanie, ulepszanie i testowanie mają użytkownicy.",ImageUrl = "https://www.cryptosaurus.cc/ctrl/wp-content/uploads/MONERO.png"
                },
                       new CrypTypes()
                {
                    CrypName = "Bitcoin SV", CrypDesc="Bitcoin SV - jest nową kryptowalutą powstałą z rozdzielenia blockchain'u Bitcoin Cash w dniu 15 listopada 2018.Cztery fundamenty, które formułują podstawy roadmap'y (mapy drogowej) Bitcoin SV, aby stworzyć jeden blockchain dla świata to: stabilność, skalowalność, bezpieczeństwo, i bezpieczne natychmiastowe transakcje (bez potwierdzeń w sieci).",ImageUrl = "https://assets.coingecko.com/coins/images/6799/large/Satoshivision.png?1547043092"
                }

            };
            return Cryptyp;
        }

        

	}
}