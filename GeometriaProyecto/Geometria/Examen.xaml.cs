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
    public partial class Examen : ContentPage
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
            preguntas[0] = "Area de un cuadrado de 2cm cada lado";
            preguntas[1] = "Area de un cuadrado de 4cm cada lado";
            preguntas[2] = "Perimetro de un rectangulo que mide 2x3";
            preguntas[3] = "¿Cuanto mide un angulo recto?";
            preguntas[4] = "¿Cuanto mide el lado de un cuadrado de area 100?";
            preguntas[5] = "Suma de los angulos internos de un triangulo";
            preguntas[6] = "Area de un triangulo de base 5 y altura 7";
            preguntas[7] = "Perimetro de un cuadrado de lado 5";
            preguntas[8] = "Area de un circulo de radio 2, pi=3.14";
            preguntas[9] = "Suma de los angulos interiores de un cuadrilatero";
        }
        public void initRespuestas()
        {
            respuestas = new string[10];
            respuestas[0] = "4";
            respuestas[1] = "16";
            respuestas[2] = "10";
            respuestas[3] = "90";
            respuestas[4] = "10";
            respuestas[5] = "180";
            respuestas[6] = "17.5";
            respuestas[7] = "20";
            respuestas[8] = "12.5664";
            respuestas[9] = "360";


        }
        public Boolean validar(string pregunta, string respuesta)
        {
            switch (pregunta)
            {
                case "Area de un cuadrado de 2cm cada lado":
                    if (respuesta.Equals("4"))
                        return true;
                    break;
                case "Area de un cuadrado de 4cm cada lado":
                    if (respuesta.Equals("16"))
                        return true;
                    break;
                case "Perimetro de un rectangulo que mide 2x3":
                    if (respuesta.Equals("10"))
                        return true;
                    break;
                case "¿Cuanto mide un angulo recto?":
                    if (respuesta.Equals("90"))
                        return true;
                    break;
                case "¿Cuanto mide el lado de un cuadrado de area 100?":
                    if (respuesta.Equals("10"))
                        return true;
                    break;
                case "Suma de los angulos internos de un triangulo":
                    if (respuesta.Equals("180"))
                        return true;
                    break;
                case "Area de un triangulo de base 5 y altura 7":
                    if (respuesta.Equals("17.5"))
                        return true;
                    break;
                case "Perimetro de un cuadrado de lado 5":
                    if (respuesta.Equals("20"))
                        return true;
                    break;
                case "Area de un circulo de radio 2, pi=3.14":
                    if (respuesta.Equals("12.5664"))
                        return true;
                    break;
                case "Suma de los angulos interiores de un cuadrilatero":
                    if (respuesta.Equals("360"))
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
        public Examen()
        {
            InitializeComponent();
            initPreguntas();
            lblPregunta.Text = preguntas[0];
            initRespuestas();
        }
       

        public void btnAnswer1_Clicked(object Sender, EventArgs e)
        {
            setPuntaje(btnAnswer1.Text);
        }
        public void btnAnswer2_Clicked(object Sender, EventArgs e)
        {         
            setPuntaje(btnAnswer2.Text);
        }
        public void btnAnswer3_Clicked(object Sender, EventArgs e)
        {
            setPuntaje(btnAnswer3.Text);
        }

        public void setPuntaje(string answer)
        {
            
            if(validar(lblPregunta.Text, answer))
            {
                if (pun < preguntas.Length)
                {
                    pun++;
                    lblPuntaje.Text = "Puntaje: " + pun + "/10";
                    siguientePregunta();
                    cambiarValores();
                    lblNumPregunta.Text = "Pregunta "+(x+1);
                }     
            }
            else
            {
                siguientePregunta();
                cambiarValores();
                lblNumPregunta.Text = "Pregunta " + (x+1);
            }
        }

        public void cambiarValores()
        {
            Random aleatorio = new Random();
            int n = aleatorio.Next(1,4);
            double aux = n;
            if (n == 1)
            {
                btnAnswer1.Text = respuestas[x];
                btnAnswer2.Text = ""+aux * 0.7;
                btnAnswer3.Text = "" + aux * 0.65;
            }
               
            else if (n == 2)
            {
                btnAnswer2.Text = respuestas[x];
                btnAnswer1.Text = "" + aux * 0.6;
                btnAnswer3.Text = "" + aux * 0.57;
            }
                
            else if (n == 3)
            {
                btnAnswer3.Text = respuestas[x];
                btnAnswer1.Text = "" + aux * 0.67;
                btnAnswer2.Text = "" + aux * 0.52;
            }
                
        }

    }
}