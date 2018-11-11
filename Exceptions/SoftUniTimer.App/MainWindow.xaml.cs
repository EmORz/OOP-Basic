using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace SoftUniTimer.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Shutdown(object sender, RoutedEventArgs e)
        {
            int time = GetSeconds();
            Process.Start("shutdown", $"/s /t {time}");
        }

        private void Abort(object sender, RoutedEventArgs e)
        {
            Process.Start("shutdown", $"/a");
        }

        private void Hibernate(object sender, RoutedEventArgs e)
        {
            Process.Start("shutdown", $"/h");
        }

        private void Restart(object sender, RoutedEventArgs e)
        {
            int time = GetSeconds();

            Process.Start("shutdown", $"/r /t {time}");
        }

        public int GetSeconds()
        {
            string currentTime = listItem.SelectionBoxItem.ToString();
            var time = int.Parse(currentTime.TrimEnd('h', 'm'));

            if (currentTime.Contains("h"))
            {
                time *= 60*60;
            }
            else if (currentTime.Contains("m"))
            {
                time *= 60;
            }

            return time;
        }
    }
}
