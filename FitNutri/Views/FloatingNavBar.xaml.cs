namespace FitNutri.Views;

public partial class FloatingNavBar : ContentView
{
	public FloatingNavBar()
	{
		InitializeComponent();
	}

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HomePage", false);
    }

    private async void OnFeedClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///FeedPage", false);
    }

    private async void OnShopClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///ShopPage", false);
    }

    private async void OnProfileClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///ProfilePage", false);
    }

    private async void OnChatClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///FindNutriPage", false);
    }
}
