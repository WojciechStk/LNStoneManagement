using LNStone.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace LNStone.Views
{
    /// <summary>
    /// Logika interakcji dla klasy LNGallery.xaml
    /// </summary>
    public partial class LNGallery : UserControl
    {
        private readonly GalleryViewModel ViewModel;

        public LNGallery()
        {
            InitializeComponent();
            ViewModel = new GalleryViewModel();
            DataContext = ViewModel;
        }



        //Move from code-behind
        int i = 1;

        #region Function: GoBack
        private void GoBack(object sender, RoutedEventArgs e)
        {
            i--;

            if (i < 1)
            {
                i = 20;
            }
            picHolder.Source = new BitmapImage(new Uri(@"/LNStone;component/Images/" + i + ".jpg", UriKind.Relative));
        }
        #endregion

        #region Function: GoNext
        private void GoNext(object sender, RoutedEventArgs e)
        {
            i++;

            if (i > 20)
            {
                i = 1;
            }
            picHolder.Source = new BitmapImage(new Uri(@"/LNStone;component/Images/" + i + ".jpg", UriKind.Relative));
        }
        #endregion
    }
}
