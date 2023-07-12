namespace KaraokeListApp;

public partial class AddSong : ContentPage
{
	public AddSong()
	{
		InitializeComponent();
	}

	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
		await Launcher.Default.OpenAsync("https://aka.ms/maui");
	}
}