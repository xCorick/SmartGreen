using SmartGreen.ViewModel;
namespace SmartGreen.Views;

public partial class NotificationPageView : ContentPage
{
	public NotificationPageView()
	{
		InitializeComponent();
		BindingContext = new VMNotificationPage(Navigation);
	}
}