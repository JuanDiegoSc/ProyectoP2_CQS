namespace ProyectoResenaApp.Pages;

public partial class LoginUsuario : ContentPage
{
	public LoginUsuario()
	{
		InitializeComponent();
	}

    private async void CrearCuenta_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new RegistroUsuario());
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
}