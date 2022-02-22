using IcyStorageClient.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace IcyStorageClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            BootStrapper.Start();

            var window = new MainWindow();
            window.DataContext = BootStrapper.RootVisual;

            window.Closed += (o, e) =>
            {
                BootStrapper.Stop();
            };

            window.Show();
        }
    }
}
