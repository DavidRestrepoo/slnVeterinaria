using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Veterinaria.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Administracion : ContentPage
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private async void registro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registros());
        }
    }
}