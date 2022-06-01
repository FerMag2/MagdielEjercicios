using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biseccion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PuntajeFinal : ContentPage
    {
        public PuntajeFinal(int p)
        {
            InitializeComponent();
            if (p > 5)
            {
                lblPFinal.Text = "Puntaje final: " + p + "/10" +
                    "\nExcelente, sigue así :D eres un guerrero Dragon";
                Felicidades.IsVisible = true;
            }

            else {
                lblPFinal.Text = "Puntaje final: " + p + "/10" +
                    "\nHay que practicar más eres nivel mantis:/";
                Perdedor.IsVisible = true;
            }
            
        }
        public void btnRegresar_Clicked(object Sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuJuegos());
        }
    }
}