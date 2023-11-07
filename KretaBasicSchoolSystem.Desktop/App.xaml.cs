using KretaBasicSchoolSystem.Desktop.Views;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using KretaDesktop.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic.Logging;
using System;
using System.Windows;

namespace KretaBasicSchoolSystem.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private bool _loginPage = false;
        private IHost host;


        public App()
        {
            host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.ConfigureViewViewModels();
                })
                .Build();

        }


        protected async override void OnStartup(StartupEventArgs e)
        {
            await host.StartAsync();
            try
            {
                var window = host.Services.GetRequiredService<MainView>();
                window.Show();
            }
            catch (Exception ex)
            {
            }
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {

            /*if (_loginPage)
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
            } */           
        }


    }
}
