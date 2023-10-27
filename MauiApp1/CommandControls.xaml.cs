namespace MauiApp1;

public partial class CommandControls : ContentPage
{
	public CommandControls()
	{
		InitializeComponent();
	}

	private void Btn1_OnClicked(object sender, EventArgs e)
	{
		DisplayAlert("alert", "button clicked", "Ok");
	}


	private void SrcInput_OnSearchButtonPressed(object sender, EventArgs e)
	{
		DisplayAlert("alert", $"Search: {SrcInput.Text}", "Ok");
	}

	private void SwipeItem_OnInvoked(object sender, EventArgs e)
	{
		DisplayAlert("alert", "element tapped", "Ok");
	}
}