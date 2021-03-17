using System;
using Xamarin.Forms;
using Using_APIs.ViewModels;
using Using_APIs.Services;

namespace Using_APIs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new TeamViewModel(new AlertService());
        }
    }
}
