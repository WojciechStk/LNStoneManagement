using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LNStone.Views
{
    /// <summary>
    /// Logika interakcji dla klasy LN_Stone.xaml
    /// </summary>
    public partial class LN_Stone : Window
    {
        public LN_Stone()
        {
            InitializeComponent();
            FirstPage_Load();
        }
        // Move from code-behind!
        #region Window_MouseDown
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        #endregion

        #region ButtonCloseWindow_Click
        private void ButtonCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion

        #region ButtonOpenMenu_Click
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }
        #endregion

        #region ButtonCloseMenu_Click
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }
        #endregion

        #region ButtonInstagram_Click
        private void ButtonInstagram_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Clear();
            UserControl usc = new LNInstagram();
            GridMain.Children.Add(usc);
        }
        #endregion

        #region ButtonShops_Click
        private void ButtonShops_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Clear();
            UserControl usc = new LNShops();
            GridMain.Children.Add(usc);
        }
        #endregion

        #region ButtonAbout_Click
        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Clear();
            UserControl usc = new LNAbout();
            GridMain.Children.Add(usc);
        }
        #endregion

        #region ButtonResizeWindow_Click
        private void ButtonResizeWindow_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
                ResizeMode = ResizeMode.NoResize;
            }
            else
            {
                WindowState = WindowState.Normal;
                ResizeMode = ResizeMode.NoResize;
            }
        }
        #endregion

        #region FirstPage_Load
        private void FirstPage_Load()
        {
            UserControl usc = new LNHome();
            GridMain.Children.Add(usc);
        }
        #endregion

        #region ListViewMenu_SelectionChanged
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    usc = new LNHome();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemDatabase":
                    usc = new LNStoneView();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemGallery":
                    usc = new LNGallery();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemCreate":
                    usc = new LN_Calculator();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemHelp":
                    usc = new LNHelp();
                    GridMain.Children.Add(usc);
                    break;
            }
        }
        #endregion
    }
}
