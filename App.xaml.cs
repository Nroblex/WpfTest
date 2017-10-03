using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfTest.View;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
      
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ConvertWindow window = new WpfTest.View.ConvertWindow
            {
                Title = "Selborn WPF Gerrit",
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            window.Show();
        }
    }
}
