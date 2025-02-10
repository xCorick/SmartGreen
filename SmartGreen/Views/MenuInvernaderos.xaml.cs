using SmartGreen.ViewModel;
using SmartGreen.Views;

namespace SmartGreen;

public partial class MenuInvernaderos : FlyoutPage
{
	public MenuInvernaderos()
	{
		InitializeComponent();
        BindingContext = new VMinvernaderos(Navigation);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavigationPage(new ViewGreenHouse()));
    }

    private async void AddGreenHouse_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavigationPage(new AgregarViveroView()));
    }

    private async void btnNotify_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavigationPage(new NotificationPageView()));
    }

    private async void btnRegInv_Cliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavigationPage(new AgregarViveroView()));
    }

    private async void btnInicio_Cliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavigationPage(new MainMenu()));
    }
}