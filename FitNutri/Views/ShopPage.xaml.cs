namespace FitNutri.Views;

public class ProductItem
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
}

public partial class ShopPage : ContentPage
{
    public ShopPage()
    {
        InitializeComponent();
    }
}