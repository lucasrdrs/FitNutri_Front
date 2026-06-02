using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FitNutri.Models;
using System.Collections.ObjectModel;

namespace FitNutri.ViewModels
{
    public partial class DietViewModel : ObservableObject
    {
        [ObservableProperty]
        private string professionalName = "Dra. Ana Paula";

        [ObservableProperty]
        private string professionalImage = "nutri_avatar.png";

        [ObservableProperty]
        private ObservableCollection<MealItem> mealItems;

        public DietViewModel()
        {
            MealItems = new ObservableCollection<MealItem>
            {
                new MealItem { Name = "Arroz Integral", Calories = 150, Quantity = 2 },
                new MealItem { Name = "Frango Grelhado", Calories = 200, Quantity = 3 },
                new MealItem { Name = "Salada Mista", Calories = 50, Quantity = 1 },
                new MealItem { Name = "Maçã", Calories = 80, Quantity = 2 }
            };
        }

        [RelayCommand]
        private void IncrementQuantity(MealItem item)
        {
            item.Quantity++;
            OnPropertyChanged(nameof(MealItems));
        }

        [RelayCommand]
        private void DecrementQuantity(MealItem item)
        {
            if (item.Quantity > 0)
            {
                item.Quantity--;
                OnPropertyChanged(nameof(MealItems));
            }
        }

        [RelayCommand]
        private async Task VoltarAsync()
        {
            await Shell.Current.GoToAsync("///HomePage");
        }
    }
}
