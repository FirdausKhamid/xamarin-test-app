﻿using System.ComponentModel;
using Xamarin.Forms;
using TestApp.ViewModels;

namespace TestApp.Views
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
