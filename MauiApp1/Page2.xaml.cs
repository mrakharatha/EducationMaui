namespace MauiApp1;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void CounterBtn_OnClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}