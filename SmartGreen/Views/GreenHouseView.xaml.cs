using CommunityToolkit.Maui.Views;
using SmartGreen.ViewModel;
namespace SmartGreen;

public partial class ViewGreenHouse : ContentPage
{
	public ViewGreenHouse()
	{
		InitializeComponent();
        BindingContext = new GreenHouseViewModel(Navigation);
	}
    private async void OnOpenPopupClicked(object sender, EventArgs e)
    {
        await Humedad.Show();// Muestra el popup
    }
}