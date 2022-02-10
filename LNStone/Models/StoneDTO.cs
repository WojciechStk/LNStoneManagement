using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Input;
using LNStone.Commands;
using LNStone.ViewModels;

namespace LNStone.Models
{
    ///<summary>
    /// This class implements INotifyPropertyChanged
    /// to support one-way and two-way bindings
    /// (such that the UI element updates when the source
    /// has been changed dynamically)
    /// 
    /// This class implements INotifyDataErrorInfo
    /// to enables data entity classes to implement
    /// custom validation rules and expose validation
    /// results asynchronously.
    /// </summary>

    public class StoneDTO : INotifyPropertyChanged, INotifyDataErrorInfo
    {

        private readonly ErrorsViewModel _errorsViewModel;
        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool CanCreate => !HasErrors;
        public ICommand CreateProductCommand { get; }
        public bool HasErrors => _errorsViewModel.HasErrors;

        public IEnumerable GetErrors(string propertyName)
        {
            return _errorsViewModel.GetErrors(propertyName);
        }

        private void ErrorsViewModel_ErrorsChanged(object sender, DataErrorsChangedEventArgs e)
        {
            ErrorsChanged?.Invoke(this, e);
            OnPropertyChanged(nameof(CanCreate));
        }

        public StoneDTO()
        {
            CreateProductCommand = new RelayCommand(this);
            _errorsViewModel = new ErrorsViewModel();
            _errorsViewModel.ErrorsChanged += ErrorsViewModel_ErrorsChanged;
        }

        #region Property: Id
        private int? _id;
        public int? Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged("Id");
                _errorsViewModel.ClearErrors(nameof(Id));

                if (Id == null)
                {
                    _errorsViewModel.AddError(nameof(Id), "The field cannot be empty.");
                }
                else
                {
                    _errorsViewModel.ClearErrors(nameof(Id));
                }
            }
        }
        #endregion

        #region Property: StoneName
        private string _stoneName;
        public string StoneName
        {
            get => _stoneName;
            set
            {
                _stoneName = value;
                OnPropertyChanged("StoneName");
                _errorsViewModel.ClearErrors(nameof(StoneName));

                if (StoneName == null)
                {
                    _errorsViewModel.AddError(nameof(StoneName), "The field cannot be empty.");
                }
                else
                {
                    _errorsViewModel.ClearErrors(nameof(StoneName));
                }
            }
        }
        #endregion

        #region Property: CordPrice
        private double? _cordPrice;
        public double? CordPrice
        {
            get => _cordPrice;
            set
            {
                _cordPrice = value;
                OnPropertyChanged("CordPrice");
                PricePerStone = _cordPrice / _amountOfStone;
                _errorsViewModel.ClearErrors(nameof(CordPrice));

                if (CordPrice == null)
                {
                    _errorsViewModel.AddError(nameof(CordPrice), "The field cannot be empty.");
                }
                else
                {
                    _errorsViewModel.ClearErrors(nameof(CordPrice));
                }
            }
        }
        #endregion

        #region Property: AmountOfStone
        private double? _amountOfStone;
        public double? AmountOfStone
        {
            get => _amountOfStone;
            set
            {
                _amountOfStone = value;
                OnPropertyChanged("AmountOfStone");
                PricePerStone = _cordPrice / _amountOfStone;
                _errorsViewModel.ClearErrors(nameof(AmountOfStone));

                if (AmountOfStone == null)
                {
                    _errorsViewModel.AddError(nameof(AmountOfStone), "The field cannot be empty.");
                }
                else
                {
                    _errorsViewModel.ClearErrors(nameof(AmountOfStone));
                }
            }
        }
        #endregion

        #region Property: PricePerStone
        private double? _pricePerStone;
        public double? PricePerStone
        {
            get => _pricePerStone;
            set
            {
                _pricePerStone = value.HasValue ? Math.Round(value.Value, 2, MidpointRounding.AwayFromZero) : (double?)null;
                OnPropertyChanged("PricePerStone");
                _errorsViewModel.ClearErrors(nameof(PricePerStone));

                if (PricePerStone == null)
                {
                    _errorsViewModel.AddError(nameof(PricePerStone), "The field will be automatically generated.");
                }
                else
                {
                    _errorsViewModel.ClearErrors(nameof(PricePerStone));
                }


            }
        }
        #endregion

        #region Property: DiameterOfStone
        private int? _diameterOfStone;
        public int? DiameterOfStone
        {
            get => _diameterOfStone;
            set
            {
                _diameterOfStone = value;
                OnPropertyChanged("DiameterOfStone");
                _errorsViewModel.ClearErrors(nameof(DiameterOfStone));

                if (DiameterOfStone == null)
                {
                    _errorsViewModel.AddError(nameof(DiameterOfStone), "The field cannot be empty.");
                }
                else
                {
                    _errorsViewModel.ClearErrors(nameof(DiameterOfStone));
                }
            }
        }
        #endregion

        #region Property: SearchStone
        private string _searchStone;
        public string SearchStone
        {
            get => _searchStone;
            set
            {
                _searchStone = value;
                OnPropertyChanged("SearchStone");
                _errorsViewModel.ClearErrors(nameof(SearchStone));

                if (SearchStone == null)
                {
                    _errorsViewModel.AddError(nameof(SearchStone), "The search will start automatically after entering the text.");
                }
                else
                {
                    _errorsViewModel.ClearErrors(nameof(SearchStone));
                }
            }
        }
        #endregion

        #region Property: Store
        private string _store;
        public string Store
        {
            get => _store;
            set
            {
                _store = value;
                OnPropertyChanged("Store");
                _errorsViewModel.ClearErrors(nameof(Store));

                if (Store == null)
                {
                    _errorsViewModel.AddError(nameof(Store), "This field cannot be empty.");
                }
                else
                {
                    _errorsViewModel.ClearErrors(nameof(Store));
                }
            }
        }
        #endregion

        #region Property: Faceting
        private string _faceting;
        public string Faceting
        {
            get => _faceting;
            set
            {
                _faceting = value;
                OnPropertyChanged("Faceting");
                _errorsViewModel.ClearErrors(nameof(Faceting));

                if (Faceting == null)
                {
                    _errorsViewModel.AddError(nameof(Faceting), "This field cannot be empty.");
                }
                else
                {
                    _errorsViewModel.ClearErrors(nameof(Faceting));
                }
            }
        }
        #endregion
    }
}
