//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica1LoginApp.Droid.Documentos
{
   public class Process
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Process() { }
        public Process(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public bool Check()
        {
            if (!this.Username.Equals("Juan") && !this.Password.Equals("1234"))
                return true;
            else
                return false;
        }
    }
}