namespace SmartGreen;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}

    private async void ToLogin_Tapped(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new Login());
    }
}