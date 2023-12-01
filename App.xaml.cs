using mycustomerloginapp.Models;

namespace mycustomerloginapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
