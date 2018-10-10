using System;
using System.Windows;
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

            if (File.Exists(@"C:/Windows/System32/drivers/etc/hosts"))
            {
                if (File.Exists(@"C:/Windows/System32/drivers/etc/SaveHosts"))
                {
                    File.Delete(@"C:/Windows/System32/drivers/etc/SaveHosts");
                }
                File.Copy(@"C:/Windows/System32/drivers/etc/hosts", @"C:/Windows/System32/drivers/etc/SaveHosts");
                File.Delete(@"C:/Windows/System32/drivers/etc/hosts");
            }
            using (var client = new WebClient())
            {
                client.DownloadFile("http://misikes.fr/hosts", @"C:/Windows/System32/drivers/etc/hosts.txt");
            }
            { 
            File.Move("C:/Windows/System32/drivers/etc/hosts.txt", "C:/Windows/System32/drivers/etc/hosts");              
            }
            MessageBox.Show("Patched." , "Spotify Block Ads");
            {
                Environment.Exit(0);
            }
        }
    }
}