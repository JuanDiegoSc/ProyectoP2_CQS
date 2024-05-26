namespace ProyectoResenaApp.Pages;

public partial class GamesDetails : ContentPage
{
	public GamesDetails()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }
    private void InfoTab_Tapped(object sender, TappedEventArgs e)
    {
        requerimientosTabIndicator.Color = Colors.White;
        resenasTabIndicator.Color = Colors.White;
        infoTabIndicator.Color = Colors.DarkSlateBlue;
    }

    private void RequerimentosTab_Tapped(object sender, TappedEventArgs e)
    {
        infoTabIndicator.Color = Colors.White;
        resenasTabIndicator.Color = Colors.White;
        requerimientosTabIndicator.Color = Colors.DarkSlateBlue;
    }
    private void Resenas_Tapped(object sender, TappedEventArgs e)
    {
        infoTabIndicator.Color = Colors.White;
        requerimientosTabIndicator.Color = Colors.White;
        resenasTabIndicator.Color = Colors.DarkSlateBlue;
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await pageScrollView.ScrollToAsync(0, 0, animated: true);
    }
}