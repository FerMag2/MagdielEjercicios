using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void btnIniciar_Clicked(object Sender, EventArgs e)
        {
            validarUsuario(phUser.Text, phPassword.Text);
        }

        public void validarUsuario(string user, string pass)
        {
            if (user.Equals("Magdiel"))
            {
                if (pass.Equals("123456"))
                {
                    Navigation.PushAsync(new Correcto(phUser.Text));
                }
                else
                {
                    var message = "Usuario y/o contraseña incorrecta";
                    DependencyService.Get<IMessage>().ShortTime(message);
                }
            }
            else
            {
                Navigation.PushAsync(new Error(phUser.Text));
            }
        }

    }


}
