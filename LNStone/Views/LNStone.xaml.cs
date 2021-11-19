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
using LNStone.ViewModels;

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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void ButtonCloseWindow_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ButtonInstagram_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Clear();
            UserControl usc = new LNInstagram();
            GridMain.Children.Add(usc);
        }

        private void ButtonShops_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Clear();
            UserControl usc = new LNShops();
            GridMain.Children.Add(usc);
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Clear();
            UserControl usc = new LNAbout();
            GridMain.Children.Add(usc);
        }

        private void FirstPage_Load()
        {
            UserControl usc = new LNHome();
            GridMain.Children.Add(usc);
           
        }

       

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();


            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {

                //default:
                //    usc = new ItemHome();
                //    GridMain.Children.Add(usc);
                //    break;

                case "ItemHome":
                    usc = new LNHome();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemDatabase":
                    usc = new StoneView();
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



                    //case "ItemDatabase":
                    //    usc = new UserControlDatabase();
                    //    GridMain.Children.Add(usc);
                    //    break;
            }



        }
    }
}
