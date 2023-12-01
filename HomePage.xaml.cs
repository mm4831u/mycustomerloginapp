namespace mycustomerloginapp;

public partial class HomePage : ContentPage
{
    ProductPageViewModel productPageViewModel;
    public HomePage()
    {
        InitializeComponent();
        productPageViewModel = new ProductPageViewModel(this.Navigation);
        BindingContext = productPageViewModel;
    }

}