using Microsoft.Maui.Controls;

namespace SmartGreen;

public partial class FlyoutInicio : FlyoutPage

{
    public FlyoutInicio()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }
}