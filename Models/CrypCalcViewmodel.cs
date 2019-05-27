using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Krryp.Models
{
    class CrypCalcViewmodel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        List<string> namess;
        
        public List<string> NamesList
        {
            get { return namess; }
            set
            {
                if (namess != value)
                {
                    namess = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NamesList"));

                }
            }
        }

        
    }
}
