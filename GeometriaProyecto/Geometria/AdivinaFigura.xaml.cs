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
    public partial class AdivinaFigura : ContentPage
    {
        int pun = 0;
        int x = 0;
        string[] preguntas;
        string[] respuestas;


        public int getPun()
        {
            return this.pun;
        }
        public void initPreguntas()
        {
            preguntas = new string[10];
            preguntas[0] = "Tengo 4 lados, dos son cortos y 2 alargados";
            preguntas[1] = "Yo no tengo lados rectos soy redondo como una moneda";
            preguntas[2] = "Tengo 4 lados exactamente iguales";
            preguntas[3] = "Tengo tres lados y tres puntas";
            preguntas[4] = "Tengo 4 lados iguales pero no soy cuadrado";
            preguntas[5] = "Selecciona el rectangulo";
            preguntas[6] = "Selecciona el circulo";
            preguntas[7] = "Selecciona el cuadrado";
            preguntas[8] = "Selecciona el triangulo";
            preguntas[9] = "Selecciona el rombo";
        }
        public void initRespuestas()
        {
            respuestas = new string[10];
            respuestas[0] = "Inciso A";
            respuestas[1] = "Inciso B";
            respuestas[2] = "Inciso C";
            respuestas[3] = "Inciso D";
            respuestas[4] = "Inciso E";
            respuestas[5] = "Inciso A";
            respuestas[6] = "Inciso B";
            respuestas[7] = "Inciso C";
            respuestas[8] = "Inciso D";
            respuestas[9] = "Inciso E";


        }
        public Boolean validar(string pregunta, string respuesta)
        {
            switch (pregunta)
            {
                case "Tengo 4 lados, dos son cortos y 2 alargados":
                    if (respuesta.Equals("Inciso A"))
                        return true;
                    break;
                case "Yo no tengo lados rectos soy redondo como una moneda":
                    if (respuesta.Equals("Inciso B"))
                        return true;
                    break;
                case "Tengo 4 lados exactamente iguales":
                    if (respuesta.Equals("Inciso C"))
                        return true;
                    break;
                case "Tengo tres lados y tres puntas":
                    if (respuesta.Equals("Inciso D"))
                        return true;
                    break;
                case "Tengo 4 lados iguales pero no soy cuadrado":
                    if (respuesta.Equals("Inciso E"))
                        return true;
                    break;
                case "Selecciona el rectangulo":
                    if (respuesta.Equals("Inciso A"))
                        return true;
                    break;
                case "Selecciona el circulo":
                    if (respuesta.Equals("Inciso B"))
                        return true;
                    break;
                case "Selecciona el cuadrado":
                    if (respuesta.Equals("Inciso C"))
                        return true;
                    break;
                case "Selecciona el triangulo":
                    if (respuesta.Equals("Inciso D"))
                        return true;
                    break;
                case "Selecciona el rombo":
                    if (respuesta.Equals("Inciso E"))
                        return true;
                    break;
            }
            return false;
        }

        public void siguientePregunta()
        {
            if (x < preguntas.Length - 1)
            {
                x++;
                lblPregunta.Text = preguntas[x];
            }
            else
            {
                Navigation.PushAsync(new PuntajeFinal(pun));
            }
        }
        public AdivinaFigura()
        {
            InitializeComponent();
            initPreguntas();
            lblPregunta.Text = preguntas[0];
            initRespuestas();
        }

        private void btnAnswer1_Clicked(object sender, EventArgs e)
        {
            setPuntaje(btnAnswer1.Text);
        }

        private void btnAnswer2_Clicked(object sender, EventArgs e)
        {
            setPuntaje(btnAnswer2.Text);
        }

        private void btnAnswer3_Clicked(object sender, EventArgs e)
        {
            setPuntaje(btnAnswer3.Text);
        }
        public void setPuntaje(string answer)
        {

            if (validar(lblPregunta.Text, answer))
            {
                if (pun < preguntas.Length)
                {
                    pun++;
                    lblPuntaje.Text = "Puntaje: " + pun + "/10";
                    siguientePregunta();
                    cambiarValores();
                    lblNumPregunta.Text = "Pregunta " + (x + 1);
                }
            }
            else
            {
                siguientePregunta();
                cambiarValores();
                lblNumPregunta.Text = "Pregunta " + (x + 1);
            }
        }
        public void cambiarValores()
        {
            if (x == 0) 
            {
                btnAnswer1.Text = respuestas[x];
                btnAnswer2.Text = "Inciso B";
                btnAnswer3.Text = "Inciso C";
                btnAnswer4.Text = "Inciso D";
                btnAnswer5.Text = "Inciso E";
            }
            if (x == 1)
            {
                btnAnswer1.Text = "Inciso A";
                btnAnswer2.Text = respuestas[x];
                btnAnswer3.Text = "Inciso C";
                btnAnswer4.Text = "Inciso D";
                btnAnswer5.Text = "Inciso E";
            }
            if (x == 2)
            {
                btnAnswer1.Text = "Inciso A";
                btnAnswer2.Text = "Inciso B";
                btnAnswer3.Text = respuestas[x];
                btnAnswer4.Text = "Inciso D";
                btnAnswer5.Text = "Inciso E";
            }
            if (x == 3)
            {
                btnAnswer1.Text = "Inciso A";
                btnAnswer2.Text = "Inciso B";
                btnAnswer3.Text = "Inciso C";
                btnAnswer4.Text = respuestas[x];
                btnAnswer5.Text = "Inciso E";
            }
            if (x == 4)
            {
                btnAnswer1.Text = "Inciso A";
                btnAnswer2.Text = "Inciso B";
                btnAnswer3.Text = "Inciso C";
                btnAnswer4.Text = "Inciso D";
                btnAnswer5.Text = respuestas[x];
            }
            if (x == 5)
            {
                btnAnswer1.Text = respuestas[x];
                btnAnswer2.Text = "Inciso B";
                btnAnswer3.Text = "Inciso C";
                btnAnswer4.Text = "Inciso D";
                btnAnswer5.Text = "Inciso E";
            }
            if (x == 6)
            {
                btnAnswer1.Text = "Inciso A";
                btnAnswer2.Text = respuestas[x];
                btnAnswer3.Text = "Inciso B";
                btnAnswer4.Text = "Inciso D";
                btnAnswer5.Text = "Inciso E";
            }
            if (x == 7)
            {
                btnAnswer1.Text = "Inciso A";
                btnAnswer2.Text = "Inciso B";
                btnAnswer3.Text = respuestas[x];
                btnAnswer4.Text = "Inciso D";
                btnAnswer5.Text = "Inciso E";
            }
            if (x == 8)
            {
                btnAnswer1.Text = "Inciso A";
                btnAnswer2.Text = "Inciso D";
                btnAnswer3.Text = "Inciso C";
                btnAnswer4.Text = respuestas[x];
                btnAnswer5.Text = "Inciso E";
            }
            if (x == 9)
            {
                btnAnswer1.Text = "Inciso A";
                btnAnswer2.Text = "Inciso B";
                btnAnswer3.Text = "Inciso C";
                btnAnswer4.Text = "Inciso D";
                btnAnswer5.Text = respuestas[x];
            }

        }

        private void btnAnswer4_Clicked(object sender, EventArgs e)
        {
            setPuntaje(btnAnswer4.Text);
        }

        private void btnAnswer5_Clicked(object sender, EventArgs e)
        {
            setPuntaje(btnAnswer5.Text);
        }
    }
}