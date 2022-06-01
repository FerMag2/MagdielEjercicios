using Biseccion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Biseccion
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
      
        Examen ex = new Examen();
        public MainPage()
        {
            InitializeComponent();
        }


        Registro miregistro = new Registro();
        public /*async*/ void btnRegistro_Clicked(object Sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
           
        }
        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            List<UsuariosModelos> m = App.Database.validacion(phCorreo.Text, phPassword.Text).Result;

            if (!string.IsNullOrWhiteSpace(phCorreo.Text) && !string.IsNullOrWhiteSpace(phPassword.Text))
            {
                if (m.Count == 0)
                {
                    var message = "Error en usuario y contraseña";
                    DependencyService.Get<IMessage>().ShortTime(message);
                }
                else if(m.Count>0)
                {
                    Navigation.PushAsync(new MenuJuegos());
                }  
            }
            else
            {
                var message = "No deje ningun campo vacio";
                DependencyService.Get<IMessage>().ShortTime(message);
            }
        }

        
    }
}
