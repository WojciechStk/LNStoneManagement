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
    /// Logika interakcji dla klasy LNGallery.xaml
    /// </summary>
    public partial class LNGallery : UserControl
    {
        
            int i = 1;

            public LNGallery()
            {
                InitializeComponent();
            }

            private void GoBack(object sender, RoutedEventArgs e)
            {
                i--;

                if (i < 1)
                {
                    i = 20;
                }

                picHolder.Source = new BitmapImage(new Uri(@"/LNStone;component/Images/" + i + ".jpg", UriKind.Relative));
            }

            private void GoNext(object sender, RoutedEventArgs e)
            {
                i++;

                if (i > 20)
                {
                    i = 1;
                }

                picHolder.Source = new BitmapImage(new Uri(@"/LNStone;component/Images/" + i + ".jpg", UriKind.Relative));
            }
        
    }
}
