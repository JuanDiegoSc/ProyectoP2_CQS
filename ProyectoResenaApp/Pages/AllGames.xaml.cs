using Microsoft.Maui.ApplicationModel.Communication;
using ProyectoResenaApp.Models;
using ProyectoResenaApp.Servicios;
using System.Collections.ObjectModel;

namespace ProyectoResenaApp.Pages;

public partial class AllGames : ContentPage
{
    public ObservableCollection<Juego> Carrusel1 { get; set; }
    public ObservableCollection<Juego> Carrusel2 { get; set; }

    public AllGames()
    {
        InitializeComponent();
        //InitializeGames();
        BindingContext = this;
        GetCategorias();
        GetJuegos();
    }

    private async void GetJuegos()
    {
        var juegos = await ApiService.GetJuegos();
        CvJuegos.ItemsSource = juegos;
    }

    private async void GetCategorias() //Agregar como MVVM
    {
       var categorias =  await ApiService.GetCategorias();
        CvCategorias.ItemsSource = categorias;
    }

    private void InitializeGames()
    {
        var juego1 = new Juego
        {
            Nombre = "The Last Of Us",
            Imagen = "tlou.png",
            Desarrollador = "Naughty Dog",
            Editor = "Sony Computer Entertainment",
            FechaLanzamiento = "2013-06-14",
            Requerimientos = "\r\nRequiere un procesador y un sistema operativo de 64 bits.\r\nSistema operativo: Windows 10 (versión 1909 o posterior)\r\nProcesador: AMD Ryzen 5 3600X, Intel Core i7-8700\r\nMemoria: 16 GB de RAM\r\nGráficos: AMD Radeon RX 5700 XT (8 GB), AMD Radeon RX 6600 XT (8 GB), NVIDIA GeForce RTX 2070 SUPER (8 GB), NVIDIA GeForce RTX 3060 (8 GB)\r\nAlmacenamiento: 100 GB de espacio disponible\r\nNotas adicionales: Se recomienda SSD",
            Resenas = new ObservableCollection<Resena>()
        };

        var juego2 = new Juego
        {
            Nombre = "Fallout Shelter",
            Imagen = "imgfallout.png",
            Desarrollador = "Bethesda Game Studios",
            Editor = "Bethesda Softworks",
            FechaLanzamiento = "2015-06-14",
            Requerimientos = "\r\nRequiere un procesador y un sistema operativo de 64 bits.\r\nSO*: Windows 7 de 64 bits\r\nProcesador: Intel Core 2 CPU cuádruple Q9550 a 2,83 GHZ\r\nMemoria: 2 GB de RAM\r\nGráficos: NVIDIA GeForce GTS 250 1Ghz, Radeon HD 6970 1GHz\r\nAlmacenamiento: 2 GB de espacio disponible",
            Resenas = new ObservableCollection<Resena>()
        };

        var juego3 = new Juego
        {
            Nombre = "Sekiro: Shadows Die Twice",
            Imagen = "sekiro.png",
            Desarrollador = "FromSoftware",
            Editor = "Activision",
            FechaLanzamiento = "2019-03-22",
            Requerimientos = "\r\nSO *: Windows 7 de 64 bits | Windows 8 de 64 bits | Windows 10 de 64 bits\r\nProcesador: Intel Core i5-2500K | AMD Ryzen 5 1400\r\nMemoria: 8 GB de RAM\r\nGráficos: NVIDIA GeForce GTX 970 | AMDRadeon RX 570\r\nDirectX: Versión 11\r\nRed: Conexión a Internet de banda ancha\r\nAlmacenamiento: 25 GB de espacio disponible\r\nTarjeta de sonido: Compatible con DirectX 11",
            Resenas = new ObservableCollection<Resena>()
        };

        Carrusel1 = new ObservableCollection<Juego> { juego1, juego2, juego3 };
        Carrusel2 = new ObservableCollection<Juego> { juego1, juego2, juego3 };
    }

    private async void OnGameSelected(object sender, EventArgs e)
    {
        var image = sender as Image;
        var game = image.BindingContext as Juego;
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
