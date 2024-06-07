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

    private async void EntrarBtn(object sender, EventArgs e)
    {
        string email = emailTxt.Text;
        string contra = contraTxt.Text;

        if(!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(contra))
        {
            var usuario = await App.BaseDeDatos.UsuarioDataTable.ObtenerUsuario(email, contra);

            if(usuario == null) 
            {
                await DisplayAlert("Alerta", "Datos invalidos", "ok");
                return;
            }
            App.usuario = usuario;
            await Shell.Current.GoToAsync(nameof(AllGames));
        }
    }

    private void VolverBtn(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AllGames));
    }
}