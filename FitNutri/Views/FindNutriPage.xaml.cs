namespace FitNutri.Views;

public partial class FindNutriPage : ContentPage
{
	public FindNutriPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
    private async void OnChatClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ChatPage", false);
    }
}
