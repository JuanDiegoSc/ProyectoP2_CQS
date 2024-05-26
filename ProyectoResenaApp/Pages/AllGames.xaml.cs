using ProyectoResenaApp.Models;
using System.Collections.ObjectModel;

namespace ProyectoResenaApp.Pages;

public partial class AllGames : ContentPage
{

    public ObservableCollection<Carrusel>? Carrusel1 { get; set; }
    public ObservableCollection<Carrusel>? Carrusel2 { get; set; }
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
             new Carrusel { Name = "The Last Of Us", ReadTime = new TimeSpan(0, 30, 0), Image = "tlou.png" },
             new Carrusel { Name = "Fallout Shelter", ReadTime = new TimeSpan(0, 25, 0), Image = "imgfallout.png" },
             new Carrusel { Name = "Sekiro: Shadows Die Twice", ReadTime = new TimeSpan(0, 30, 0), Image = "sekiro.png" }
        };

        Carrusel2 = new ObservableCollection<Carrusel>
        {
            new Carrusel { Name = "The Last Of Us", ReadTime = new TimeSpan(0, 30, 0), Image = "tlou.png" },
            new Carrusel { Name = "Fallout Shelter", ReadTime = new TimeSpan(0, 25, 0), Image = "imgfallout.png" },
            new Carrusel { Name = "Sekiro: Shadows Die Twice", ReadTime = new TimeSpan(0, 30, 0), Image = "sekiro.png" }
  };
    }
}