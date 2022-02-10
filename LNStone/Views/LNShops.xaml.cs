using System;
using System.Windows;
using System.Windows.Controls;

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

        // Move from code-behind
        #region Btn_1
        private void ButtonManzuko_OnClick(object sender, RoutedEventArgs e)
        {
            WebBrowser.Source = new Uri("https://www.manzuko.com", UriKind.Absolute);
            //Optional: WebBrowser.ZoomFactor = 0.5;
        }
        #endregion

        #region Btn_2
        private void ButtonKamieniolomy_OnClick(object sender, RoutedEventArgs e)
        {
            WebBrowser.Source = new Uri("https://www.kamieniolomy.pl", UriKind.Absolute);
        }
        #endregion

        #region Btn_3
        private void ButtonPasart_OnClick(object sender, RoutedEventArgs e)
        {
            WebBrowser.Source = new Uri("https://www.pasart.pl", UriKind.Absolute);
        }
        #endregion

        #region Btn_4
        private void ButtonRoyalStone_OnClick(object sender, RoutedEventArgs e)
        {
            WebBrowser.Source = new Uri("https://www.royal-stone.pl", UriKind.Absolute);
        }
        #endregion
    }
}
