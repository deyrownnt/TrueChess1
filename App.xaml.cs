using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MyWpf1.View;

namespace MyWpf1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
#if DEBUG
            // Simulează un utilizator logat doar în modul Debug, înainte de a crea MainView
            System.Threading.Thread.CurrentPrincipal = new System.Security.Principal.GenericPrincipal(
                new System.Security.Principal.GenericIdentity("unNumeDeUtilizatorExistent"), // Asigură-te că acest nume există în baza ta de date
                null);
#endif

            var mainView = new MainView();
            mainView.Show();

            // Codul de login comentat nu mai este relevant pentru rularea directă
            //var loginView = new LoginView();
            //loginView.Show();
            //loginView.IsVisibleChanged += (s, ev) =>
            //{
            //    if (loginView.IsVisible == false && loginView.IsLoaded)
            //    {
            //        var mainView = new MainView();
            //        mainView.Show();
            //        // loginView.Close();
            //    }
            //};
        }
    }

}
