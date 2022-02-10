using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using LNStone.Models;

namespace LNStone.ViewModels
{
    public partial class CalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Internal class Command
        // Is here for a specific purpose
        internal class Command : ICommand
        {

            Action<object> executeMethod;
            Func<object, bool> canexecuteMethod;

            public Command(Action<object> executeMethod, Func<object, bool> canexecuteMethod)
            {
                this.executeMethod = executeMethod;
                this.canexecuteMethod = canexecuteMethod;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                executeMethod(parameter);
            }

            public event EventHandler CanExecuteChanged;
        }
        #endregion

        public ICommand MyCommand { get; set; }
        public ICommand ResetCommand { get; set; }

        public CalculatorViewModel()
        {
            BindComboBox();
            MyCommand = new Command(ExecuteResultCommand, CanExecuteMethod);
            ResetCommand = new Command(ExecuteResetCommand, CanExecuteMethod);
        }

        private void BindComboBox()
        {
            LNStoneDbEntities obj = new LNStoneDbEntities();
            List<Stone> lst = obj.Stone.ToList();
            _stoneSelected = lst;
        }

        #region ExecuteMethod: Reset, Result
        private void ExecuteResetCommand(object parameter)
        {
            StoneSelected = null;
            SelectedQuantity = 0;
            SelectedQuantity1 = 0;
            SelectedQuantity2 = 0;
            SelectedQuantity3 = 0;
            SelectedQuantity4 = 0;
            SelectedQuantity5 = 0;
            SelectedQuantity6 = 0;
            SelectedQuantity7 = 0;
            SelectedQuantity8 = 0;
            SelectedQuantity9 = 0;
            Result = null;
            Result1 = null;
            Result2 = null;
            Result3 = null;
            Result4 = null;
            Result5 = null;
            Result6 = null;
            Result7 = null;
            Result8 = null;
            Result9 = null;
            Sum = null;
            SelectedMargin = 0;
            Total = null;

            LNStoneDbEntities obj = new LNStoneDbEntities();
            List<Stone> lst = obj.Stone.ToList();
            StoneSelected = lst;
        }

        private void ExecuteResultCommand(object parameter)
        {
            Result = SelectedQuantity * Price_Per_Stone;
            Result1 = SelectedQuantity1 * Price_Per_Stone1;
            Result2 = SelectedQuantity2 * Price_Per_Stone2;
            Result3 = SelectedQuantity3 * Price_Per_Stone3;
            Result4 = SelectedQuantity4 * Price_Per_Stone4;
            Result5 = SelectedQuantity5 * Price_Per_Stone5;
            Result6 = SelectedQuantity6 * Price_Per_Stone6;
            Result7 = SelectedQuantity7 * Price_Per_Stone7;
            Result8 = SelectedQuantity8 * Price_Per_Stone8;
            Result9 = SelectedQuantity9 * Price_Per_Stone9;
            Sum = Result + Result1 + Result2 + Result3 + Result4 + Result5 + Result6 + Result7 + Result8 + Result9;
            Total = (Sum * SelectedMargin) / 100 + Sum;
        }
        private bool CanExecuteMethod(object parameter)
        {
            return true;
        }
        #endregion

        #region Field: Quantity
        public List<int> Quantity
        {
            get
            {
                try
                {
                    return Enumerable.Range(0, 100).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            set
            {
                Quantity = value; OnPropertyChanged("Quantity");
            }
        }
        #endregion

        #region Field: Margin
        public List<int> Margin
        {
            get
            {
                try
                {
                    return new List<int> { 0, 15, 30, 50, 70, 100 };
                }
                catch (Exception)
                {
                    throw;
                }
            }
            set
            {
                Margin = value; OnPropertyChanged("Margin");
            }
        }
        #endregion

        #region Field: SelectedMargin
        private int _selectedMargin;
        public int SelectedMargin
        {
            get => _selectedMargin;
            set
            {
                if (_selectedMargin == value)
                {
                    return;
                }
                _selectedMargin = value; OnPropertyChanged("SelectedMargin");
            }
        }
        #endregion

        #region Field: StoneSelected
        private List<Stone> _stoneSelected;
        public List<Stone> StoneSelected
        {
            get => _stoneSelected;
            set
            {
                if (_stoneSelected != value)
                {
                    _stoneSelected = value;
                    OnPropertyChanged("StoneSelected");
                }
            }
        }
        #endregion

        #region Field: MySelectedStone
        private Stone _mySelectedStone;
        public Stone MySelectedStone
        {
            get => _mySelectedStone;
            set
            {
                if (_mySelectedStone != value)
                {
                    _mySelectedStone = value;
                    OnPropertyChanged("MySelectedStone");
                }
            }
        }
        #endregion

        #region Field: SelectedQuantity
        private int _selectedQuantity;
        public int SelectedQuantity
        {
            get => _selectedQuantity;
            set
            {
                if (_selectedQuantity == value)
                {
                    return;
                }
                _selectedQuantity = value; OnPropertyChanged("SelectedQuantity");
            }
        }
        #endregion

        #region Field: Price_Per_Stone
        private double? _price_Per_Stone;
        public double? Price_Per_Stone
        {
            get
            {
                if (_price_Per_Stone == null)
                {
                    _price_Per_Stone = 0; OnPropertyChanged("MySelectedStone.Price_per_Stone");
                }
                if (_price_Per_Stone != null & _selectedQuantity > 0)
                {
                    _price_Per_Stone = MySelectedStone.Price_per_Stone; OnPropertyChanged("MySelectedStone.Price_per_Stone");
                }
                return _price_Per_Stone;
            }
        }
        #endregion

        #region Field: Result
        private double? _result;
        public double? Result
        {
            get => _result;
            set
            {
                if (_result == value)
                {
                    return;
                }
                _result = value;
                OnPropertyChanged("Result");
            }
        }
        #endregion

        #region Field: MySelectedStone1
        private Stone _mySelectedStone1;
        public Stone MySelectedStone1
        {
            get => _mySelectedStone1;
            set
            {
                if (_mySelectedStone1 != value)
                {
                    _mySelectedStone1 = value;
                    OnPropertyChanged("MySelectedStone1");
                }
            }
        }
        #endregion

        #region Field: StoneSelected1
        private List<Stone> _stoneSelected1;
        public List<Stone> StoneSelected1
        {
            get => _stoneSelected1;
            set
            {
                if (_stoneSelected1 != value)
                {
                    _stoneSelected1 = value;
                    OnPropertyChanged("StoneSelected1");
                }
            }
        }
        #endregion

        #region Field: SelectedQuantity1
        private int _selectedQuantity1;
        public int SelectedQuantity1
        {
            get => _selectedQuantity1;
            set
            {
                if (_selectedQuantity1 == value)
                {
                    return;
                }
                _selectedQuantity1 = value; OnPropertyChanged("SelectedQuantity1");
            }
        }
        #endregion

        #region Field: Price_Per_Stone1
        private double? _price_Per_Stone1;
        public double? Price_Per_Stone1
        {
            get
            {
                if (_price_Per_Stone1 == null)
                {
                    _price_Per_Stone1 = 0; OnPropertyChanged("MySelectedStone1.Price_per_Stone");
                }
                if (_price_Per_Stone1 != null & _selectedQuantity1 > 0)
                {
                    _price_Per_Stone1 = MySelectedStone1.Price_per_Stone; OnPropertyChanged("MySelectedStone1.Price_per_Stone");
                }
                return _price_Per_Stone1;
            }
        }
        #endregion

        #region Field: Result1
        private double? _result1;
        public double? Result1
        {
            get => _result1;
            set
            {
                if (_result1 == value)
                {
                    return;
                }

                _result1 = value;
                OnPropertyChanged("Result1");
            }
        }
        #endregion

        #region Field: MySelectedStone2
        private Stone _mySelectedStone2;
        public Stone MySelectedStone2
        {
            get => _mySelectedStone2;
            set
            {
                if (_mySelectedStone2 != value)
                {
                    _mySelectedStone2 = value;
                    OnPropertyChanged("MySelectedStone2");
                }
            }
        }
        #endregion

        #region Field: StoneSelected2
        private List<Stone> _stoneSelected2;
        public List<Stone> StoneSelected2
        {
            get => _stoneSelected2;
            set
            {
                if (_stoneSelected2 != value)
                {
                    _stoneSelected2 = value;
                    OnPropertyChanged("StoneSelected2");
                }
            }
        }
        #endregion

        #region Field: SelectedQuantity2
        private int _selectedQuantity2;
        public int SelectedQuantity2
        {
            get => _selectedQuantity2;
            set
            {
                if (_selectedQuantity2 == value)
                {
                    return;
                }
                _selectedQuantity2 = value; OnPropertyChanged("SelectedQuantity2");
            }
        }
        #endregion

        #region Field: Price_Per_Stone2
        private double? _price_Per_Stone2;
        public double? Price_Per_Stone2
        {
            get
            {
                if (_price_Per_Stone2 == null)
                {
                    _price_Per_Stone2 = 0; OnPropertyChanged("MySelectedStone2.Price_per_Stone");
                }
                if (_price_Per_Stone2 != null & _selectedQuantity2 > 0)
                {
                    _price_Per_Stone2 = MySelectedStone2.Price_per_Stone; OnPropertyChanged("MySelectedStone2.Price_per_Stone");
                }
                return _price_Per_Stone2;
            }
        }
        #endregion

        #region Field: Result2
        private double? _result2;
        public double? Result2
        {
            get => _result2;
            set
            {
                if (_result2 == value)
                {
                    return;
                }
                _result2 = value;
                OnPropertyChanged("Result2");
            }
        }
        #endregion

        #region Field: MySelectedStone3
        private Stone _mySelectedStone3;
        public Stone MySelectedStone3
        {
            get => _mySelectedStone3;
            set
            {
                if (_mySelectedStone3 != value)
                {
                    _mySelectedStone3 = value;
                    OnPropertyChanged("MySelectedStone3");
                }
            }
        }
        #endregion

        #region Field: StoneSelected3
        private List<Stone> _stoneSelected3;
        public List<Stone> StoneSelected3
        {
            get => _stoneSelected3;
            set
            {
                if (_stoneSelected3 != value)
                {
                    _stoneSelected3 = value;
                    OnPropertyChanged("StoneSelected3");
                }
            }
        }
        #endregion

        #region Field: SelectedQuantity3
        private int _selectedQuantity3;
        public int SelectedQuantity3
        {
            get => _selectedQuantity3;
            set
            {
                if (_selectedQuantity3 == value)
                {
                    return;
                }
                _selectedQuantity3 = value; OnPropertyChanged("SelectedQuantity3");
            }
        }
        #endregion

        #region Field: Price_Per_Stone3
        private double? _price_Per_Stone3;
        public double? Price_Per_Stone3
        {
            get
            {
                if (_price_Per_Stone3 == null)
                {
                    _price_Per_Stone3 = 0; OnPropertyChanged("MySelectedStone3.Price_per_Stone");
                }
                if (_price_Per_Stone3 != null & _selectedQuantity3 > 0)
                {
                    _price_Per_Stone3 = MySelectedStone3.Price_per_Stone; OnPropertyChanged("MySelectedStone3.Price_per_Stone");
                }
                return _price_Per_Stone3;
            }
        }
        #endregion

        #region Field: Result3
        private double? _result3;
        public double? Result3
        {
            get => _result3;
            set
            {
                if (_result3 == value)
                {
                    return;
                }
                _result3 = value;
                OnPropertyChanged("Result3");
            }
        }
        #endregion

        #region Field: MySelectedStone4
        private Stone _mySelectedStone4;
        public Stone MySelectedStone4
        {
            get => _mySelectedStone4;
            set
            {
                if (_mySelectedStone4 != value)
                {
                    _mySelectedStone4 = value;
                    OnPropertyChanged("MySelectedStone4");
                }
            }
        }
        #endregion

        #region Field: StoneSelected4
        private List<Stone> _stoneSelected4;
        public List<Stone> StoneSelected4
        {
            get => _stoneSelected4;
            set
            {
                if (_stoneSelected4 != value)
                {
                    _stoneSelected4 = value;
                    OnPropertyChanged("StoneSelected4");
                }
            }
        }
        #endregion

        #region Field: SelectedQuantity4
        private int _selectedQuantity4;
        public int SelectedQuantity4
        {
            get => _selectedQuantity4;
            set
            {
                if (_selectedQuantity4 == value)
                {
                    return;
                }
                _selectedQuantity4 = value; OnPropertyChanged("SelectedQuantity4");
            }
        }
        #endregion

        #region Field: Price_Per_Stone4
        private double? _price_Per_Stone4;
        public double? Price_Per_Stone4
        {
            get
            {
                if (_price_Per_Stone4 == null)
                {
                    _price_Per_Stone4 = 0; OnPropertyChanged("MySelectedStone4.Price_per_Stone");
                }
                if (_price_Per_Stone4 != null & _selectedQuantity4 > 0)
                {
                    _price_Per_Stone4 = MySelectedStone4.Price_per_Stone; OnPropertyChanged("MySelectedStone4.Price_per_Stone");
                }
                return _price_Per_Stone4;
            }
        }
        #endregion

        #region Field: Result4
        private double? _result4;
        public double? Result4
        {
            get => _result4;
            set
            {
                if (_result4 == value)
                {
                    return;
                }
                _result4 = value;
                OnPropertyChanged("Result4");
            }
        }
        #endregion

        #region Field: MySelectedStone5
        private Stone _mySelectedStone5;
        public Stone MySelectedStone5
        {
            get => _mySelectedStone5;
            set
            {
                if (_mySelectedStone5 != value)
                {
                    _mySelectedStone5 = value;
                    OnPropertyChanged("MySelectedStone5");
                }
            }
        }
        #endregion

        #region Field: StoneSelected5
        private List<Stone> _stoneSelected5;
        public List<Stone> StoneSelected5
        {
            get => _stoneSelected5;
            set
            {
                if (_stoneSelected5 != value)
                {
                    _stoneSelected5 = value;
                    OnPropertyChanged("StoneSelected5");
                }
            }
        }
        #endregion

        #region Field: SelectedQuantity5
        private int _selectedQuantity5;
        public int SelectedQuantity5
        {
            get => _selectedQuantity5;
            set
            {
                if (_selectedQuantity5 == value)
                {
                    return;
                }
                _selectedQuantity5 = value; OnPropertyChanged("SelectedQuantity5");
            }
        }
        #endregion

        #region Field: Price_Per_Stone5
        private double? _price_Per_Stone5;
        public double? Price_Per_Stone5
        {
            get
            {
                if (_price_Per_Stone5 == null)
                {
                    _price_Per_Stone5 = 0; OnPropertyChanged("MySelectedStone5.Price_per_Stone");
                }
                if (_price_Per_Stone5 != null & _selectedQuantity5 > 0)
                {
                    _price_Per_Stone5 = MySelectedStone5.Price_per_Stone; OnPropertyChanged("MySelectedStone5.Price_per_Stone");
                }
                return _price_Per_Stone5;
            }
        }
        #endregion

        #region Field: Result5
        private double? _result5;
        public double? Result5
        {
            get => _result5;
            set
            {
                if (_result5 == value)
                {
                    return;
                }
                _result5 = value;
                OnPropertyChanged("Result5");
            }
        }
        #endregion

        #region Field: MySelectedStone6
        private Stone _mySelectedStone6;
        public Stone MySelectedStone6
        {
            get => _mySelectedStone6;
            set
            {
                if (_mySelectedStone6 != value)
                {
                    _mySelectedStone6 = value;
                    OnPropertyChanged("MySelectedStone6");
                }
            }
        }
        #endregion

        #region Field: StoneSelected6
        private List<Stone> _stoneSelected6;
        public List<Stone> StoneSelected6
        {
            get => _stoneSelected6;
            set
            {
                if (_stoneSelected6 != value)
                {
                    _stoneSelected6 = value;
                    OnPropertyChanged("StoneSelected6");
                }
            }
        }
        #endregion

        #region Field: SelectedQuantity6
        private int _selectedQuantity6;
        public int SelectedQuantity6
        {
            get => _selectedQuantity6;
            set
            {
                if (_selectedQuantity6 == value)
                {
                    return;
                }
                _selectedQuantity6 = value; OnPropertyChanged("SelectedQuantity6");
            }
        }
        #endregion

        #region Field: Price_Per_Stone6
        private double? _price_Per_Stone6;
        public double? Price_Per_Stone6
        {
            get
            {
                if (_price_Per_Stone6 == null)
                {
                    _price_Per_Stone6 = 0; OnPropertyChanged("MySelectedStone6.Price_per_Stone");
                }
                if (_price_Per_Stone6 != null & _selectedQuantity6 > 0)
                {
                    _price_Per_Stone6 = MySelectedStone6.Price_per_Stone; OnPropertyChanged("MySelectedStone6.Price_per_Stone");
                }
                return _price_Per_Stone6;
            }
        }
        #endregion

        #region Field: Result6
        private double? _result6;
        public double? Result6
        {
            get => _result6;
            set
            {
                if (_result6 == value)
                {
                    return;
                }
                _result6 = value;
                OnPropertyChanged("Result6");
            }
        }
        #endregion

        #region Field: MySelectedStone7
        private Stone _mySelectedStone7;
        public Stone MySelectedStone7
        {
            get => _mySelectedStone7;
            set
            {
                if (_mySelectedStone7 != value)
                {
                    _mySelectedStone7 = value;
                    OnPropertyChanged("MySelectedStone7");
                }
            }
        }
        #endregion

        #region Field: StoneSelected7
        private List<Stone> _stoneSelected7;
        public List<Stone> StoneSelected7
        {
            get => _stoneSelected7;
            set
            {
                if (_stoneSelected7 != value)
                {
                    _stoneSelected7 = value;
                    OnPropertyChanged("StoneSelected7");
                }
            }
        }
        #endregion

        #region Field: SelectedQuantity7
        private int _selectedQuantity7;
        public int SelectedQuantity7
        {
            get => _selectedQuantity7;
            set
            {
                if (_selectedQuantity7 == value)
                {
                    return;
                }
                _selectedQuantity7 = value; OnPropertyChanged("SelectedQuantity7");
            }
        }
        #endregion

        #region Field: Price_Per_Stone7
        private double? _price_Per_Stone7;
        public double? Price_Per_Stone7
        {
            get
            {
                if (_price_Per_Stone7 == null)
                {
                    _price_Per_Stone7 = 0; OnPropertyChanged("MySelectedStone7.Price_per_Stone");
                }
                if (_price_Per_Stone7 != null & _selectedQuantity7 > 0)
                {
                    _price_Per_Stone7 = MySelectedStone7.Price_per_Stone; OnPropertyChanged("MySelectedStone7.Price_per_Stone");
                }
                return _price_Per_Stone7;
            }
        }
        #endregion

        #region Field: Result7
        private double? _result7;
        public double? Result7
        {
            get => _result7;
            set
            {
                if (_result7 == value)
                {
                    return;
                }
                _result7 = value;
                OnPropertyChanged("Result7");
            }
        }
        #endregion

        #region Field: MySelectedStone8
        private Stone _mySelectedStone8;
        public Stone MySelectedStone8
        {
            get => _mySelectedStone8;
            set
            {
                if (_mySelectedStone8 != value)
                {
                    _mySelectedStone8 = value;
                    OnPropertyChanged("MySelectedStone8");
                }
            }
        }
        #endregion

        #region Field: StoneSelected8
        private List<Stone> _stoneSelected8;
        public List<Stone> StoneSelected8
        {
            get { return _stoneSelected8; }
            set
            {
                if (_stoneSelected8 != value)
                {
                    _stoneSelected8 = value;
                    OnPropertyChanged("StoneSelected8");
                }
            }
        }
        #endregion

        #region Field: SelectedQuantity8
        private int _selectedQuantity8;
        public int SelectedQuantity8
        {
            get => _selectedQuantity8;
            set
            {
                if (_selectedQuantity8 == value)
                {
                    return;
                }
                _selectedQuantity8 = value; OnPropertyChanged("SelectedQuantity8");
            }
        }
        #endregion

        #region Field: Price_Per_Stone8
        private double? _price_Per_Stone8;
        public double? Price_Per_Stone8
        {
            get
            {
                if (_price_Per_Stone8 == null)
                {
                    _price_Per_Stone8 = 0; OnPropertyChanged("MySelectedStone8.Price_per_Stone");
                }
                if (_price_Per_Stone8 != null & _selectedQuantity8 > 0)
                {
                    _price_Per_Stone8 = MySelectedStone8.Price_per_Stone; OnPropertyChanged("MySelectedStone8.Price_per_Stone");
                }
                return _price_Per_Stone8;
            }
        }
        #endregion

        #region Field: Result8
        private double? _result8;
        public double? Result8
        {
            get => _result8;
            set
            {
                if (_result8 == value)
                {
                    return;
                }
                _result8 = value;
                OnPropertyChanged("Result8");
            }
        }
        #endregion

        #region Field: MySelectedStone9
        private Stone _mySelectedStone9;
        public Stone MySelectedStone9
        {
            get => _mySelectedStone9;
            set
            {
                if (_mySelectedStone9 != value)
                {
                    _mySelectedStone9 = value;
                    OnPropertyChanged("MySelectedStone9");
                }
            }
        }
        #endregion

        #region Field: StoneSelected9
        private List<Stone> _stoneSelected9;
        public List<Stone> StoneSelected9
        {
            get => _stoneSelected9;
            set
            {
                if (_stoneSelected9 != value)
                {
                    _stoneSelected9 = value;
                    OnPropertyChanged("StoneSelected9");
                }
            }
        }
        #endregion

        #region Field: SelectedQuantity9
        private int _selectedQuantity9;
        public int SelectedQuantity9
        {
            get => _selectedQuantity9;
            set
            {
                if (_selectedQuantity9 == value)
                {
                    return;
                }
                _selectedQuantity9 = value; OnPropertyChanged("SelectedQuantity9");
            }
        }
        #endregion

        #region Field: Price_Per_Stone9
        private double? _price_Per_Stone9;
        public double? Price_Per_Stone9
        {
            get
            {
                if (_price_Per_Stone9 == null)
                {
                    _price_Per_Stone9 = 0; OnPropertyChanged("MySelectedStone9.Price_per_Stone");
                }
                if (_price_Per_Stone9 != null & _selectedQuantity9 > 0)
                {
                    _price_Per_Stone9 = MySelectedStone9.Price_per_Stone; OnPropertyChanged("MySelectedStone9.Price_per_Stone");
                }
                return _price_Per_Stone9;
            }
        }
        #endregion

        #region Field: Result9
        private double? _result9;
        public double? Result9
        {
            get => _result9;
            set
            {
                if (_result9 == value)
                {
                    return;
                }
                _result9 = value;
                OnPropertyChanged("Result9");
            }
        }
        #endregion

        #region Field: Sum
        private double? _sum;
        public double? Sum
        {
            get => _sum;
            set
            {
                if (_sum == value)
                {
                    return;
                }
                _sum = value;
                OnPropertyChanged("Sum");
            }
        }
        #endregion

        #region Field: Total
        private double? _total;
        public double? Total
        {
            get => _total;
            set
            {
                if (_total == value)
                {
                    return;
                }
                _total = value;
                OnPropertyChanged("Total");
            }
        }
        #endregion
    }
}