namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();


        var navigationPage = new NavigationPage(new MainPage())
        {
            //BarBackground = Colors.Chocolate,
            //BarTextColor = Colors.White
        };


        //MainPage = navigationPage;

        MainPage = new FlyoutPageDemo();
    }
}
