using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using SQLitePCL;
using Veterinaria.Models;

namespace Veterinaria.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //App.SQLiteDB.saveRegistroAsync(user);
            
            this.BindingContext = new LoginViewModel();

        }

        private  async void btnLogin_Clicked(object sender, EventArgs e)
        {            
            var username = txtUsuario.Text;
            var password = txtPassword.Text;
            Persona user = await App.SQLiteDB.validarLogin(username, password);
            if (user != null)
            {
                switch (user.Rol.ToLower())
                {
                    case "veterinario":
                        await Navigation.PushAsync(new veterinario());
                        break;
                    case "vendedor":
                       // await Navigation.PushAsync(new vendedor());
                        break;
                    case "administrador":
                       await Navigation.PushAsync(new Registros());
                        break;
                        default: 
                        break;
                }
                
            }
            else
            {
                await DisplayAlert("Error", "Nombre de usuario o contraseña incorrectos", "OK");
            }
        }

        private async void btnRegistrese_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registros());
        }
    }
}