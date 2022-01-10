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

namespace LNStone.Views
{
    /// <summary>
    /// Logika interakcji dla klasy LNShops.xaml
    /// </summary>
    public partial class LNShops : UserControl
    {
        public LNShops()
        {
            InitializeComponent();
        }

        private void ButtonManzuko_OnClick(object sender, RoutedEventArgs e)
        {
            WebBrowser.Source = new Uri("https://www.manzuko.com", UriKind.Absolute);
            //WebBrowser.ZoomFactor = 0.5;
        }

        private void ButtonKamieniolomy_OnClick(object sender, RoutedEventArgs e)
        {
            WebBrowser.Source = new Uri("https://www.kamieniolomy.pl", UriKind.Absolute);
            
        }

        private void ButtonPasart_OnClick(object sender, RoutedEventArgs e)
        {
            WebBrowser.Source = new Uri("https://www.pasart.pl", UriKind.Absolute);
            
        }
    }
}
