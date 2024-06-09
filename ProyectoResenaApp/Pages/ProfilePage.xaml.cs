namespace ProyectoResenaApp.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    private void CerrarBtn(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(LoginUsuario));
    }

    private void VolverBtn(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AllGames));
    }
}