using CommunityToolkit.Mvvm.Input;

namespace FitNutri.Views;

public partial class ChatPage : ContentPage
{
	public ChatPage()
	{
		InitializeComponent();
	}

    private async void OnDietClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DietPage", false);
    }
}

