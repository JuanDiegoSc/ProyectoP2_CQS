using ProyectoResenaApp.Models;
using Microsoft.Maui.Controls;
using System;

namespace ProyectoResenaApp.Pages;

[QueryProperty(nameof(SelectedGame), "SelectedGame")]
public partial class GamesDetails : ContentPage
{
    private Carrusel _selectedGame;
    public Carrusel SelectedGame
    {
        get => _selectedGame;
        set
        {
            _selectedGame = value;
            OnPropertyChanged();
            UpdateGameDetails();
        }
    }

    public GamesDetails()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private async void BackBtn(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void InfoTab_Tapped(object sender, TappedEventArgs e)
    {
        requerimientosTabIndicator.Color = Colors.White;
        resenasTabIndicator.Color = Colors.White;
        infoTabIndicator.Color = Colors.DarkSlateBlue;
        resenasContent.IsVisible = false;
        tabText.Text = $"Fecha de Lanzamiento: {SelectedGame.ReleaseDate}\n" +
                       $"Desarrollador: {SelectedGame.Developer}\n" +
                       $"Editor: {SelectedGame.Publisher}";
    }

    private void RequerimentosTab_Tapped(object sender, TappedEventArgs e)
    {
        infoTabIndicator.Color = Colors.White;
        resenasTabIndicator.Color = Colors.White;
        requerimientosTabIndicator.Color = Colors.DarkSlateBlue;
        resenasContent.IsVisible = false;
        tabText.Text = SelectedGame.Requirements;
    }

    private void Resenas_Tapped(object sender, TappedEventArgs e)
    {
        infoTabIndicator.Color = Colors.White;
        requerimientosTabIndicator.Color = Colors.White;
        resenasTabIndicator.Color = Colors.DarkSlateBlue;
        resenasContent.IsVisible = true;
        tabText.Text = string.Empty;
    }

    private void UpdateGameDetails()
    {
        // Toca actualizar otros detalles si es necesario F
    }

    private void StarTapped(object sender, TappedEventArgs e)
    {
        var tappedStar = sender as Image;
        int starRating = int.Parse(tappedStar.StyleId);

        star1.Source = starRating >= 1 ? "star_filled.png" : "star_empty.png";
        star2.Source = starRating >= 2 ? "star_filled.png" : "star_empty.png";
        star3.Source = starRating >= 3 ? "star_filled.png" : "star_empty.png";
        star4.Source = starRating >= 4 ? "star_filled.png" : "star_empty.png";
        star5.Source = starRating >= 5 ? "star_filled.png" : "star_empty.png";
    }
}
