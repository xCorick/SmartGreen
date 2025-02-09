namespace SmartGreen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuInvernaderos());
            //MainPage = new NavigationPage(new Login());
        }
    }
}
