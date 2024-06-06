namespace ProyectoResenaApp.Pages;

public partial class RegistroUsuario : ContentPage
{
	public RegistroUsuario()
	{
		InitializeComponent();
	}

    private void CrearCuentabtn(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AllGames));
    }

    private void RegresarBtn(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(LoginUsuario));
    }
}