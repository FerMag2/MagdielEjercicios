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
    public partial class Error : ContentPage
    {
        public Error(string user)
        {
            InitializeComponent();
            lblError.Text = "No existe el usuario " + user;
        }
    }
}