using KreataBasicSchoolSystem.Desktop.Views;
using KreataBasicSchoolSystem.Desktop.Views.Login;
using System.Windows;

namespace KreataBasicSchoolSystem.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
           /* var loginView = new LoginView();
            loginView.Show();
            loginView.IsVisibleChanged += (s, ev) =>
            {
                if (loginView.IsVisible == false && loginView.IsLoaded)
                {*/
                    var mainView = new MainView();
                    mainView.Show();
                   /* loginView.Close();
                }
            };*/
        }
    }
}
