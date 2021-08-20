using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica1LoginApp.Droid.Documentos
{
   public class LogMessage
    {
        public int Id { get; set; }
        public string accessfail { get; set; }
        public string errormessage { get; set; }
        public DateTime expired { get; set; }

        public LogMessage() { }
    }
}