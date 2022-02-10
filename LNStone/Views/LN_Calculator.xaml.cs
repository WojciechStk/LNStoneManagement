using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using LNStone.ViewModels;

namespace LNStone.Views
{
    public partial class LN_Calculator : UserControl
    {
        private readonly CalculatorViewModel ViewModel;

        public LN_Calculator()
        {
            InitializeComponent();
            ViewModel = new CalculatorViewModel();
            DataContext = ViewModel;
        }

        // Move from code-behind to CalculatorViewModel.cs
        #region BtnPrint
        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Calculator.Background = new SolidColorBrush();
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();

                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(Calculator, "inventory");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected exception occured while trying to acces default printer. Please ensure that default printer is installed in your OS!");
            }
            finally
            {
                this.IsEnabled = true;
            }
        }
        #endregion
    }
}

