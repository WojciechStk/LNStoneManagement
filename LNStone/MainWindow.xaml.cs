using System.Windows;
using LNStone.ViewModels;

namespace LNStone
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly StoneViewModel ViewModel;
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new StoneViewModel();
            this.DataContext = ViewModel;
        }




    }
}
