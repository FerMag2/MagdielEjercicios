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
    public partial class AreaPerimetro : ContentPage
    {
        public AreaPerimetro()
        {
            InitializeComponent();
        }
        private void btnAnswer1_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ladoA.Text) && !string.IsNullOrWhiteSpace(ladoB.Text))
            {
                int result = Int32.Parse(ladoA.Text);
                int result2 = Int32.Parse(ladoB.Text);
                double ladA = result * 1.0;
                double ladB = result2 * 1.0;
                double area = ladA * ladB;
                double perimetro = (2 * ladA) + 2 * (ladB);
                AreaRec.Text = "Area: " + area;
                PerimetroRec.Text = "Perimetro: " + perimetro;
                ladoA.Text = "";
                ladoB.Text = ""; 
            }
            else
            {
                var message = "No deje ningun campo vacio";
                DependencyService.Get<IMessage>().ShortTime(message);
            }
           
        }

        private void btnAnswer2_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Radio.Text))
            {
                int result = Int32.Parse(Radio.Text);
                double res = result * 1.0;
                double area = 3.1416 * (res * res);
                double perimetro = (2 * res) * 3.1416;
                AreaCir.Text = "Area: " + area;
                PerimetroCir.Text = "Perimetro: " + perimetro;
                Radio.Text = "";
            }
            else{
                var message = "No deje ningun campo vacio";
                DependencyService.Get<IMessage>().ShortTime(message);
            }
               
        }

        private void btnAnswer3_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ladoPrin.Text))
            {
                int result = Int32.Parse(ladoPrin.Text);
                double res = result * 1.0;
                double area = res * res;
                double perimetro = 4 * res;
                AreaCua.Text = "Area: " + area;
                PerimetroCua.Text = "Perimetro" + perimetro;
                ladoPrin.Text = "";
            }
            else
            {
                var message = "No deje ningun campo vacio";
                DependencyService.Get<IMessage>().ShortTime(message);
            }
           
        }

        private void btnAnswer4_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Base.Text) && !string.IsNullOrWhiteSpace(Altura.Text))
            {
                int result = Int32.Parse(Base.Text);
                int result2 = Int32.Parse(Altura.Text);
                double bas = result * 1.0;
                double alt = result2 * 1.0;
                double area = (bas * alt) / 2;
                double perimetro = 3 * bas;
                AreaTrian.Text = "Area: " + area;
                PerimetroTrian.Text = "Perimetro: " + perimetro;
                Base.Text = "";
                Altura.Text = "";
            }
            else
            {
                var message = "No deje ningun campo vacio";
                DependencyService.Get<IMessage>().ShortTime(message);
            }
            
        }

        private void btnAnswer5_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mayor.Text) && !string.IsNullOrWhiteSpace(menor.Text) && !string.IsNullOrWhiteSpace(ladoRom.Text))
            {
                int result = Int32.Parse(mayor.Text);
                int result2 = Int32.Parse(menor.Text);
                int result3 = Int32.Parse(ladoRom.Text);
                double may = result * 1.0;
                double men = result2 * 1.0;
                double lad = result3 * 1.0;
                double area = (may * men) / 2;
                double perimetro = 4 * lad;
                AreaRom.Text = "Area: " + area;
                PerimetroRom.Text = "Perimetro: " + perimetro;
                mayor.Text = "";
                menor.Text = "";
                ladoRom.Text = "";
            }
            else
            {
                var message = "No deje ningun campo vacio";
                DependencyService.Get<IMessage>().ShortTime(message);
            }
           
        }
    }
}