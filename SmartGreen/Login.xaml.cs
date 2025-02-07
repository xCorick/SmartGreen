namespace SmartGreen;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void Btn_SingUp(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Register());
    }
}