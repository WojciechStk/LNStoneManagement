using System.Windows.Controls;
using LNStone.ViewModels;

namespace LNStone.Views
{
    /// <summary>
    /// Logika interakcji dla klasy LNStoneView.xaml
    /// </summary>
    public partial class LNStoneView : UserControl
    {
        private readonly StoneViewModel ViewModel;

        public LNStoneView()
        {
            InitializeComponent();
            ViewModel = new StoneViewModel();
            DataContext = ViewModel;
        }
    }
}
