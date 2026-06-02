namespace FitNutri.Views;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    private async void OnStatCardTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///RankingPage", false);
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///LoginPage", false);
    }
}
