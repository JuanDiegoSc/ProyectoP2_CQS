using ProyectoResenaApp.Data;
using ProyectoResenaApp.Models;
using ProyectoResenaApp.Pages;

namespace ProyectoResenaApp
{
    public partial class App : Application
    {
        static SQLiteData? _baseDeDatos;

        public static SQLiteData BaseDeDatos
        {
            get
            {
                if( _baseDeDatos == null)
                {
                    _baseDeDatos =
                        new SQLiteData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Datos.db"));
                }
                return _baseDeDatos;
            }
        }

        public static Usuario? usuario { get; set; }



        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new GamesDetails());
            MainPage = new AppShell();
        }
    }
}
