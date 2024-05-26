using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
namespace ProyectoResenaApp.Pages;
public partial class HomePage : ContentPage
{
    public ObservableCollection<ImagenesCarrusel> Resources { get; set; }
    public HomePage()
	{
		InitializeComponent();

        Resources = new ObservableCollection<ImageResource>{
        new ImageResource { ImagePath = "tou1.jpg", Title = "The Last Of Us Part I" },
        new ImageResource { ImagePath = "sekiro.jpg", Title = "Sekiro Shadows Die Twice" },
        new ImageResource { ImagePath = "liesp.jpg", Title = "Lies Of P" },
    };

        BindingContext = this;
    }
}