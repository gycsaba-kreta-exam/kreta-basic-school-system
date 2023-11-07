using KretaBasicSchoolSystem.Desktop.Views;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using System.Windows;

namespace KretaBasicSchoolSystem.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private bool _loginPage = false;
        //private readonly IHost host;



        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (_loginPage)
            {
                var loginView = new LoginView();
                loginView.Show();
                loginView.IsVisibleChanged += (s, ev) =>
                {
                    if (loginView.IsVisible == false && loginView.IsLoaded)
                    {
                        var mainView = new MainView();
                        mainView.Show();
                        loginView.Close();
                    }
                };
            }
            else
            {
                var mainView = new MainView();
                mainView.Show();
            }            
        }
    }
}
