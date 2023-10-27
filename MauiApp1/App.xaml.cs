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

        //MainPage = new FlyoutPageDemo();

        //MainPage = new TabbedPageDemo();

        // MainPage = new StackLayoutDemo();

        //MainPage = new GridDemo();

       // MainPage = new AbsoluteDemo();
        
     //  MainPage = new FlexDemo();
       
     MainPage = new PresentData();
    }
}
