using SmartGreen.ViewModel;

namespace SmartGreen.Views;

public partial class AgregarViveroView : ContentPage
{
	public AgregarViveroView()
	{
		InitializeComponent();
		BindingContext = new VMAgregarVivero(Navigation);
	}
}