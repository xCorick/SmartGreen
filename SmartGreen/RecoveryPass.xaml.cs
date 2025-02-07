namespace SmartGreen;

public partial class RecoveryPass : ContentPage
{
	public RecoveryPass()
	{
		InitializeComponent();
	}

    private async void Back_Login(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new Login());
    }
}