using System;
using System.ComponentModel;
using Veterinaria.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Veterinaria.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            //App.SQLiteDB.primerUsuario();
            primerUsuario();
        }

        public void primerUsuario()
        {

            var table = App.SQLiteDB.GetRegistroByIdAsync(1);        

            if (table != null)
            {
                Persona persona = new Persona();
                persona.Usuario = "Admon";
                persona.Rol = "administrador";
                persona.Nombre = "Admon";
                persona.Cedula = "123";
                persona.Edad = "20";
                persona.Password = "Admon";
                var u = App.SQLiteDB.saveRegistroAsync(persona);
            }
        }


        private  async void login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}