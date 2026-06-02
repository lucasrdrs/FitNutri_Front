using System;
using Microsoft.Maui.Controls;

namespace FitNutri.Views;

public partial class RegisterPage : ContentPage {
    public RegisterPage() {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e) {
        await Shell.Current.GoToAsync("//LoginPage", false);
    }

    private async void OnLoginLabelTapped(object sender, EventArgs e) {
        await Shell.Current.GoToAsync("//LoginPage", false);
    }
}