namespace FitNutri.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage() {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e) {
        await Shell.Current.GoToAsync("//FeedPage", false);
    }

    private async void OnRegisterLabelTapped(object sender, EventArgs e) {
        await Shell.Current.GoToAsync("//RegisterPage", false);
    }
}