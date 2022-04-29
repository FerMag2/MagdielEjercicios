using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Correcto : ContentPage
    {
        public Correcto(string user)
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenido: " + user;
        }
    }
}