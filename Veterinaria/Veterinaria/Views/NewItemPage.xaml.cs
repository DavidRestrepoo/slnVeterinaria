using System;
using System.Collections.Generic;
using System.ComponentModel;
using Veterinaria.Models;
using Veterinaria.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Veterinaria.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}