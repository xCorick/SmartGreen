namespace SmartGreen;

public partial class MenuInvernaderos : FlyoutPage
{
	public MenuInvernaderos()
	{
		InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavigationPage(new ViewGreenHouse()));
    }
}