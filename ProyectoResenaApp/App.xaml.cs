using ProyectoResenaApp.Pages;

namespace ProyectoResenaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new GamesDetails());
        }
    }
}
