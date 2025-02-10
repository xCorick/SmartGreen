namespace SmartGreen;

public partial class MainMenu : ContentPage
{
	public MainMenu()
	{
		InitializeComponent();
	}

    private async void view_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new NavigationPage(new MenuInvernaderos()));
    }
}