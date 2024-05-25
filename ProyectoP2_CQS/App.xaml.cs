using ProyectoP2_CQS.InterfazUsuario;
namespace ProyectoP2_CQS

{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Login();
        }
    }
}
