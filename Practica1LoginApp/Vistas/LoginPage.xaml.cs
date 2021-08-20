using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica1LoginApp.Droid.Documentos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1LoginApp.Droid.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = UserLog.Background;
            Lbl_Username.TextColor = UserLog.MaintTextColor;
            Lbl_Password.TextColor = UserLog.MaintTextColor;
            Mensajes.IsVisible = false;
            Logo.HeightRequest = UserLog.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            //Entry_Password.Completed += (s, e) => SignInProcedure.Focus(s, e);
        }
        void SignInProcedure(object sender, EventArgs e)
        {
            Process user = new Process(Entry_Username.Text, Entry_Password.Text);
            if (user.Check())
            {
                DisplayAlert("Bienvenido", "Hola Juan", "Ingresar");
            }
            else
            {
                DisplayAlert("Error", "Usuario o Contraseña Incorrectos", "Intentar de nuevo");
            }
        }
    }
}