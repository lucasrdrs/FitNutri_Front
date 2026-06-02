using FitNutri.ViewModels;

namespace FitNutri.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        BindingContext = new HomeViewModel();
	}
    private async void OnDietClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DietPage", false);
    }
}
