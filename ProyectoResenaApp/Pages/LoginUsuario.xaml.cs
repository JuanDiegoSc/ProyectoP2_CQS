namespace ProyectoResenaApp.Pages;

public partial class LoginUsuario : ContentPage
{
	public LoginUsuario()
	{
		InitializeComponent();
	}

    private void CrearCuenta_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(RegistroUsuario));
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AllGames));
    }
}