using Microsoft.Maui.ApplicationModel.Communication;
using ProyectoResenaApp.Models;
using System.Collections.ObjectModel;

namespace ProyectoResenaApp.Pages;

public partial class AllGames : ContentPage
{
    public ObservableCollection<Carrusel> Carrusel1 { get; set; }
    public ObservableCollection<Carrusel> Carrusel2 { get; set; }

    public AllGames()
    {
        InitializeComponent();
        InitializeGames();
        BindingContext = this;
    }

    private void InitializeGames()
    {
        Carrusel1 = new ObservableCollection<Carrusel>
        {
             new Carrusel { Name = "The Last Of Us", Image = "tlou.png" },
             new Carrusel { Name = "Fallout Shelter", Image = "imgfallout.png" },
             new Carrusel { Name = "Sekiro: Shadows Die Twice", Image = "sekiro.png" }
        };

        Carrusel2 = new ObservableCollection<Carrusel>
        {
            new Carrusel { Name = "The Last Of Us", Image = "tlou.png" },
            new Carrusel { Name = "Fallout Shelter", Image = "imgfallout.png" },
            new Carrusel { Name = "Sekiro: Shadows Die Twice", Image = "sekiro.png" }
        };
    }

    private async void OnGameSelected(object sender, EventArgs e)
    {
        var image = sender as Image;
        var game = image.BindingContext as Carrusel;
        if (game != null)
        {
            var parameters = new Dictionary<string, object>
            {
                { "SelectedGame", game }
            };
            await Shell.Current.GoToAsync(nameof(GamesDetails), parameters);
        }
    }

    private async void HomeBtn(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AllGames));
    }

    private async void ProfileBtn(object sender, EventArgs e)
    {
        if (App.AuthService.IsLoggedIn)
        {
            await Navigation.PushAsync(new ProfilePage());
        }
        else
        {
            await DisplayAlert("No autenticado", "Debe iniciar sesión para acceder al perfil", "OK");
            await Navigation.PushAsync(new LoginUsuario());
        }
    }
}
