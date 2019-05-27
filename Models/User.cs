using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Data.SQLite;
using SQLite;

namespace Krryp.Modelss
{
    public class User
    {

         [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
       public string Username { get; set; }
       public string Password { get; set; }

       

        public User() { }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }


        public bool CheckInfo()
        {
            if (Username != null && Password != null && !this.Username.Equals("") && !this.Password.Equals(""))
            {
                return true;
            }
            else
                return false;
        }

        public bool CheckAdmin()
        {
            if (Username == "admin" && Password == "admin")
            {
                return true;
            }
            else
                return false;
        }

        
    }

}
