using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Veterinaria.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registros : ContentPage
    {
        public Registros()
        {
            InitializeComponent();
        }
        private async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Persona registro = new Persona
                {
                    Usuario = txtUsuario.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Cedula = txtCedula.Text.Trim(),
                    Edad = txtEdad.Text.Trim(),
                    Rol = txtRol.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                };
                await App.SQLiteDB.saveRegistroAsync(registro);
                limpiarTxt();
                await DisplayAlert("Registro", "Se guardo exitosamente el registro", "OK");
                await Navigation.PushAsync(new LoginPage());
            }
            else
            {
                await DisplayAlert("Advertencia", "Ingresar todos los datos", "OK");
            }
        }
        public void limpiarTxt()
        {
            txtUsuario.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtRol.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
        public bool validarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtNombre.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtCedula.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtEdad.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtRol.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                respuesta = false;
            }
            else if (txtRol.Text.ToLower().Trim() != "administrador" || txtRol.Text.ToLower().Trim() != "dueño de mascota" || txtRol.Text.ToLower().Trim() != "veterinario" || txtRol.Text.ToLower().Trim() != "vendedor")
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
