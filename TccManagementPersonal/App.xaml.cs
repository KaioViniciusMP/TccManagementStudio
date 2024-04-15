using TccManagementPersonal.Componentes;
using TccManagementPersonal.Views;

namespace TccManagementPersonal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new PageEntrada());
        }
    }
}
