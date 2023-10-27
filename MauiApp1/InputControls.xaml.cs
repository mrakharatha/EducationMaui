using System.Diagnostics;
using System.Globalization;

namespace MauiApp1;

public partial class InputControls : ContentPage
{
	public InputControls()
	{
		InitializeComponent();
	}

	private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
	{
		LblSlider.Text = Slider.Value.ToString(CultureInfo.InvariantCulture);
	}

	private void Stepper_OnValueChanged(object sender, ValueChangedEventArgs e)
	{
		LblStepper.Text= Stepper.Value.ToString( CultureInfo.InvariantCulture);
	}

	private void TxtInput_OnTextChanged(object sender, TextChangedEventArgs e)
	{
		Debug.WriteLine(TxtInput.Text);
	}

	private void TxtInput_OnCompleted(object sender, EventArgs e)
	{
		Debug.WriteLine(TxtInput.Text);
	}
}