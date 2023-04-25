using System.ComponentModel;
using Veterinaria.ViewModels;
using Xamarin.Forms;

namespace Veterinaria.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}