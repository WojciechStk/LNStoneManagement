using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using LNStone.Models;

namespace LNStone.Views
{
    /// <summary>
    /// Logika interakcji dla klasy LN_Calculator.xaml
    /// </summary>

    [Serializable]
    public partial class LN_Calculator : INotifyPropertyChanged
    {
        public LN_Calculator()
        {
            InitializeComponent();
            BindComboBox();
            CmbBoxQuantity();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void BindComboBox()
        {
            LNStoneDbEntities obj = new LNStoneDbEntities();
            List<Stone> lst = obj.Stone.ToList();
            cmbStone0.ItemsSource = lst;
            cmbStone1.ItemsSource = lst;
            cmbStone2.ItemsSource = lst;
            cmbStone3.ItemsSource = lst;
            cmbStone4.ItemsSource = lst;
            cmbStone5.ItemsSource = lst;
            cmbStone6.ItemsSource = lst;
            cmbStone7.ItemsSource = lst;
            cmbStone8.ItemsSource = lst;
            cmbStone9.ItemsSource = lst;
        }

        private void cmbStone0_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cursor = System.Windows.Input.Cursors.Wait;

            if (cmbStone0.SelectedItem is Stone obj)
            {
                txtPricePerStone0.Text = obj.Price_per_Stone.ToString();
                txtDiameterOfStone0.Text = obj.Diameter_of_Stone.ToString();
            }
            Cursor = System.Windows.Input.Cursors.Arrow;
        }
        
        private void cmbStone1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cursor = System.Windows.Input.Cursors.Wait;
            Stone obj = cmbStone1.SelectedItem as Stone;
            if (obj != null)
            {
                txtPricePerStone1.Text = obj.Price_per_Stone.ToString();
                txtDiameterOfStone1.Text = obj.Diameter_of_Stone.ToString();
            }
            Cursor = System.Windows.Input.Cursors.Arrow;
        }

        private void cmbStone2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cursor = System.Windows.Input.Cursors.Wait;
            Stone obj = cmbStone2.SelectedItem as Stone;
            if (obj != null)
            {
                txtPricePerStone2.Text = obj.Price_per_Stone.ToString();
                txtDiameterOfStone2.Text = obj.Diameter_of_Stone.ToString();
            }
            Cursor = System.Windows.Input.Cursors.Arrow;
        }

        private void cmbStone3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cursor = System.Windows.Input.Cursors.Wait;
            Stone obj = cmbStone3.SelectedItem as Stone;
            if (obj != null)
            {
                txtPricePerStone3.Text = obj.Price_per_Stone.ToString();
                txtDiameterOfStone3.Text = obj.Diameter_of_Stone.ToString();
            }
            Cursor = System.Windows.Input.Cursors.Arrow;
        }

        private void cmbStone4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cursor = System.Windows.Input.Cursors.Wait;
            Stone obj = cmbStone4.SelectedItem as Stone;
            if (obj != null)
            {
                txtPricePerStone4.Text = obj.Price_per_Stone.ToString();
                txtDiameterOfStone4.Text = obj.Diameter_of_Stone.ToString();
            }
            Cursor = System.Windows.Input.Cursors.Arrow;
        }

        private void cmbStone5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cursor = System.Windows.Input.Cursors.Wait;
            Stone obj = cmbStone5.SelectedItem as Stone;
            if (obj != null)
            {
                txtPricePerStone5.Text = obj.Price_per_Stone.ToString();
                txtDiameterOfStone5.Text = obj.Diameter_of_Stone.ToString();
            }
            Cursor = System.Windows.Input.Cursors.Arrow;
        }

        private void cmbStone6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cursor = System.Windows.Input.Cursors.Wait;
            Stone obj = cmbStone6.SelectedItem as Stone;
            if (obj != null)
            {
                txtPricePerStone6.Text = obj.Price_per_Stone.ToString();
                txtDiameterOfStone6.Text = obj.Diameter_of_Stone.ToString();
            }
            Cursor = System.Windows.Input.Cursors.Arrow;
        }

        private void cmbStone7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cursor = System.Windows.Input.Cursors.Wait;
            Stone obj = cmbStone7.SelectedItem as Stone;
            if (obj != null)
            {
                txtPricePerStone7.Text = obj.Price_per_Stone.ToString();
                txtDiameterOfStone7.Text = obj.Diameter_of_Stone.ToString();
            }
            Cursor = System.Windows.Input.Cursors.Arrow;
        }

        private void cmbStone8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cursor = System.Windows.Input.Cursors.Wait;
            Stone obj = cmbStone8.SelectedItem as Stone;
            if (obj != null)
            {
                txtPricePerStone8.Text = obj.Price_per_Stone.ToString();
                txtDiameterOfStone8.Text = obj.Diameter_of_Stone.ToString();
            }
            Cursor = System.Windows.Input.Cursors.Arrow;
        }

        private void cmbStone9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cursor = System.Windows.Input.Cursors.Wait;
            Stone obj = cmbStone9.SelectedItem as Stone;
            if (obj != null)
            {
                txtPricePerStone9.Text = obj.Price_per_Stone.ToString();
                txtDiameterOfStone9.Text = obj.Diameter_of_Stone.ToString();
            }
            Cursor = System.Windows.Input.Cursors.Arrow;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int Quantity0;
            int Quantity1;
            int Quantity2;
            int Quantity3;
            int Quantity4;
            int Quantity5;
            int Quantity6;
            int Quantity7;
            int Quantity8;
            int Quantity9;
            double Price0;
            double Price1;
            double Price2;
            double Price3;
            double Price4;
            double Price5;
            double Price6;
            double Price7;
            double Price8;
            double Price9;
            double Total0;
            double Total1;
            double Total2;
            double Total3;
            double Total4;
            double Total5;
            double Total6;
            double Total7;
            double Total8;
            double Total9;

            if (cmbQuantity0.Text == "")
            {
                Total0 = 0;
            }
            else
            {
                Quantity0 = Convert.ToInt32(cmbQuantity0.Text);
                Price0 = Convert.ToDouble(txtPricePerStone0.Text);
                Total0 = Quantity0 * Price0;
                txtTotal0.Text = Convert.ToString(Total0);
                
            }

            if (cmbQuantity1.Text == "")
            {
                Total1 = 0;
            }
            else
            {
                Quantity1 = Convert.ToInt32(cmbQuantity1.Text);
                Price1 = Convert.ToDouble(txtPricePerStone1.Text);
                Total1 = Quantity1 * Price1;
                txtTotal1.Text = Convert.ToString(Total1);
            }

            if (cmbQuantity2.Text == "")
            {
                Total2 = 0;
            }
            else
            {
                Quantity2 = Convert.ToInt32(cmbQuantity2.Text);
                Price2 = Convert.ToDouble(txtPricePerStone2.Text);
                Total2 = Quantity2 * Price2;
                txtTotal2.Text = Convert.ToString(Total2);
            }

            if (cmbQuantity3.Text == "")
            {
                Total3 = 0;
            }
            else
            {
                Quantity3 = Convert.ToInt32(cmbQuantity3.Text);
                Price3 = Convert.ToDouble(txtPricePerStone3.Text);
                Total3 = Quantity3 * Price3;
                txtTotal3.Text = Convert.ToString(Total3);
            }

            if (cmbQuantity4.Text == "")
            {
                Total4 = 0;
            }
            else
            {
                Quantity4 = Convert.ToInt32(cmbQuantity4.Text);
                Price4 = Convert.ToDouble(txtPricePerStone4.Text);
                Total4 = Quantity4 * Price4;
                txtTotal4.Text = Convert.ToString(Total4);
            }

            if (cmbQuantity5.Text == "")
            {
                Total5 = 0;
            }
            else
            {
                Quantity5 = Convert.ToInt32(cmbQuantity5.Text);
                Price5 = Convert.ToDouble(txtPricePerStone5.Text);
                Total5 = Quantity5 * Price5;
                txtTotal5.Text = Convert.ToString(Total5);
            }

            if (cmbQuantity6.Text == "")
            {
                Total6 = 0;
            }
            else
            {
                Quantity6 = Convert.ToInt32(cmbQuantity6.Text);
                Price6 = Convert.ToDouble(txtPricePerStone6.Text);
                Total6 = Quantity6 * Price6;
                txtTotal6.Text = Convert.ToString(Total6);
            }

            if (cmbQuantity7.Text == "")
            {
                Total7 = 0;
            }
            else
            {
                Quantity7 = Convert.ToInt32(cmbQuantity7.Text);
                Price7 = Convert.ToDouble(txtPricePerStone7.Text);
                Total7 = Quantity7 * Price7;
                txtTotal7.Text = Convert.ToString(Total7);
            }

            if (cmbQuantity8.Text == "")
            {
                Total8 = 0;
            }
            else
            {
                Quantity8 = Convert.ToInt32(cmbQuantity8.Text);
                Price8 = Convert.ToDouble(txtPricePerStone8.Text);
                Total8 = Quantity8 * Price8;
                txtTotal8.Text = Convert.ToString(Total8);
            }

            if (cmbQuantity9.Text == "")
            {
                Total9 = 0;
            }
            else
            {
                Quantity9 = Convert.ToInt32(cmbQuantity9.Text);
                Price9 = Convert.ToDouble(txtPricePerStone9.Text);
                Total9 = Quantity9 * Price9;
                txtTotal9.Text = Convert.ToString(Total9);
            }

            double num0;
            double num1;
            double num2;
            double num3;
            double num4;
            double num5;
            double num6;
            double num7;
            double num8;
            double num9;
            double sum;

            if (txtPricePerStone0.Text == "")
            {
                num0 = 0;
            }
            else
            {
                num0 = Convert.ToDouble(txtPricePerStone0.Text);
            }

            if (txtPricePerStone1.Text == "")
            {
                num1 = 0;
            }
            else
            {
                num1 = Convert.ToDouble(txtPricePerStone1.Text);
            }

            if (txtPricePerStone2.Text == "")
            {
                num2 = 0;
            }
            else
            {
                num2 = Convert.ToDouble(txtPricePerStone2.Text);
            }

            if (txtPricePerStone3.Text == "")
            {
                num3 = 0;
            }
            else
            {
                num3 = Convert.ToDouble(txtPricePerStone3.Text);
            }

            if (txtPricePerStone4.Text == "")
            {
                num4 = 0;
            }
            else
            {
                num4 = Convert.ToDouble(txtPricePerStone4.Text);
            }

            if (txtPricePerStone5.Text == "")
            {
                num5 = 0;
            }
            else
            {
                num5 = Convert.ToDouble(txtPricePerStone5.Text);
            }

            if (txtPricePerStone6.Text == "")
            {
                num6 = 0;
            }
            else
            {
                num6 = Convert.ToDouble(txtPricePerStone6.Text);
            }

            if (txtPricePerStone7.Text == "")
            {
                num7 = 0;
            }
            else
            {
                num7 = Convert.ToDouble(txtPricePerStone7.Text);
            }

            if (txtPricePerStone8.Text == "")
            {
                num8 = 0;
            }
            else
            {
                num8 = Convert.ToDouble(txtPricePerStone8.Text);
            }

            if (txtPricePerStone9.Text == "")
            {
                num9 = 0;
            }
            else
            {
                num9 = Convert.ToDouble(txtPricePerStone9.Text);
            }

            sum = Total0 + Total1 + Total2 + Total2 + Total3 + Total4 + Total5 + Total6 + Total7 + Total8 + Total9;

            txtSum.Text = Convert.ToString(sum);
        }

        public void CmbBoxQuantity()
        {
            for (int i = 0; i < 100; i++)
            {
                cmbQuantity0.Items.Add(i);
                cmbQuantity1.Items.Add(i);
                cmbQuantity2.Items.Add(i);
                cmbQuantity3.Items.Add(i);
                cmbQuantity4.Items.Add(i);
                cmbQuantity5.Items.Add(i);
                cmbQuantity6.Items.Add(i);
                cmbQuantity7.Items.Add(i);
                cmbQuantity8.Items.Add(i);
                cmbQuantity9.Items.Add(i);
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            cmbStone0.Text = "";
            txtDiameterOfStone0.Text = "";
            cmbQuantity0.Text = "";
            txtPricePerStone0.Text = "";
            txtTotal0.Text = "";

            cmbStone1.Text = "";
            txtDiameterOfStone1.Text = "";
            cmbQuantity1.Text = "";
            txtPricePerStone1.Text = "";
            txtTotal1.Text = "";

            cmbStone2.Text = "";
            txtDiameterOfStone2.Text = "";
            cmbQuantity2.Text = "";
            txtPricePerStone2.Text = "";
            txtTotal2.Text = "";

            cmbStone3.Text = "";
            txtDiameterOfStone3.Text = "";
            cmbQuantity3.Text = "";
            txtPricePerStone3.Text = "";
            txtTotal3.Text = "";

            cmbStone4.Text = "";
            txtDiameterOfStone4.Text = "";
            cmbQuantity4.Text = "";
            txtPricePerStone4.Text = "";
            txtTotal4.Text = "";

            cmbStone5.Text = "";
            txtDiameterOfStone5.Text = "";
            cmbQuantity5.Text = "";
            txtPricePerStone5.Text = "";
            txtTotal5.Text = "";

            cmbStone6.Text = "";
            txtDiameterOfStone6.Text = "";
            cmbQuantity6.Text = "";
            txtPricePerStone6.Text = "";
            txtTotal6.Text = "";

            cmbStone7.Text = "";
            txtDiameterOfStone7.Text = "";
            cmbQuantity7.Text = "";
            txtPricePerStone7.Text = "";
            txtTotal7.Text = "";

            cmbStone8.Text = "";
            txtDiameterOfStone8.Text = "";
            cmbQuantity8.Text = "";
            txtPricePerStone8.Text = "";
            txtTotal8.Text = "";

            cmbStone9.Text = "";
            txtDiameterOfStone9.Text = "";
            cmbQuantity9.Text = "";
            txtPricePerStone9.Text = "";
            txtTotal9.Text = "";

            txtSum.Text = "";
        }
    }
}

