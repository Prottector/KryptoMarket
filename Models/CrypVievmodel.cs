using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Krryp.Models
{
	public class CrypVievmodel : ContentPage
	{
		
		public List<CrypTypes> Cryptyp { get; set; }

        public CrypVievmodel()
        {
            Cryptyp = new CrypTypes().GetCrypTypes();
        }
		
	}
}