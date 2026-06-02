using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FitNutri.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task GoToDietPage()
        {
            await Shell.Current.GoToAsync("///DietPage", false);
        }
    }
}
