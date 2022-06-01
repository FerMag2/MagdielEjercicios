using Biseccion.Modelos;
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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetPeopleAsync();
        }
        public async void btnSave_Clicked(object Sender, EventArgs e)
        {
            //Navigation.PushAsync(new Registro());

            if (!string.IsNullOrWhiteSpace(phNombre.Text) && !string.IsNullOrWhiteSpace(phCorreoE.Text) && !string.IsNullOrWhiteSpace(phPasswordE.Text) && !string.IsNullOrWhiteSpace(phEdad.Text) && !string.IsNullOrWhiteSpace(phEscuela.Text))
            {
                await App.Database.SavePersonAsync(new UsuariosModelos
                {
                    Nombre = phNombre.Text,
                    Escuela = phEscuela.Text,
                    Pasword= phPasswordE.Text,
                    Correo= phCorreoE.Text,
                });

                phNombre.Text = phEscuela.Text =phCorreoE.Text = phPasswordE.Text = phEdad.Text = string.Empty;
                listView.ItemsSource = await App.Database.GetPeopleAsync();
                var message = "Datos Guardados Correctamente";
                DependencyService.Get<IMessage>().ShortTime(message);
            }
            else
            {
                var message = "No deje ningun campo vacio";
                DependencyService.Get<IMessage>().ShortTime(message);
            }
        }
        
        public void btnVolver_Clicked(object Sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
        public string correoGuardar;
        public string paswordeGuardar;
        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (UsuariosModelos)e.SelectedItem;
            var alumno = await App.Database.GetAlumnoByAsync(obj.ID);
            correoGuardar = alumno.Correo;
            paswordeGuardar = alumno.Pasword;
            //await Navigation.PushAsync(new MainPage());

        }
    }
}