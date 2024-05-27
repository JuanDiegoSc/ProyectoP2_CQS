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
        resenasContent.IsVisible = false;
        tabText.Text = "Fecha de Lanzamiento: 28 de Marzo de 2023 \r\nDesarrolador: Naughty Dog LLC, Iron Galaxy Studios \r\nEditor: PlayStation PC LLC";
    }

    private void RequerimentosTab_Tapped(object sender, TappedEventArgs e)
    {
        infoTabIndicator.Color = Colors.White;
        resenasTabIndicator.Color = Colors.White;
        requerimientosTabIndicator.Color = Colors.DarkSlateBlue;
        resenasContent.IsVisible = false;
        tabText.Text = "RECOMENDADO:\r\n\nRequiere un procesador y un sistema operativo de 64 bits\r\nOS: Windows 10 (versión 1909 o más nuevo)\r\nProcesador: AMD Ryzen 5 3600X, Intel Core i7-8700\r\nMemoria: 16 GB de RAM\r\nGráficos: AMD Radeon RX 5700 XT (8 GB), AMD Radeon RX 6600 XT (8 GB), Nvidia GeForce RTX 2070 Super (8 GB), Nvidia GeForce RTX 3060 (8 GB)\r\nAlmacenamiento: 100 GB de espacio disponible\r\nNotas adicionales: SSD recomendado";

    }
    private void Resenas_Tapped(object sender, TappedEventArgs e)
    {
        infoTabIndicator.Color = Colors.White;
        requerimientosTabIndicator.Color = Colors.White;
        resenasTabIndicator.Color = Colors.DarkSlateBlue;
        resenasContent.IsVisible = true;
        tabText.Text = string.Empty;
    }

    private void StarTapped(object sender, TappedEventArgs e)
    {
        Image star = (Image)sender;
        if (star.Source.ToString() == "star_empty")
        {
            star.Source = "star_full";
        }
        else
        {
            star.Source = "star_empty";
        }
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await pageScrollView.ScrollToAsync(0, 0, animated: true);
    }
}