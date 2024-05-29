namespace MauiAppJeffersonR.Views;

public partial class AboutPageJeffersonRuiz : ContentPage
{
	public AboutPageJeffersonRuiz()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        // Navigate to the specified URL in the system browser.
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}