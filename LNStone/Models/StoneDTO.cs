using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Ink;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Windows.Input;
using LNStone.Commands;
using LNStone.ViewModels;
using System.Globalization;

namespace LNStone.Models
{
    public class StoneDTO : INotifyPropertyChanged, INotifyDataErrorInfo
    {

        private readonly ErrorsViewModel _errorsViewModel;
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public StoneDTO()
        {
            CreateProductCommand = new RelayCommand(this);

            _errorsViewModel = new ErrorsViewModel();
            _errorsViewModel.ErrorsChanged += ErrorsViewModel_ErrorsChanged;
        }

        private int? id;

        public int? Id
        {
            get { return id; }

            set 
            { 
                id = value;

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

       

        private string stoneName;
        public string StoneName
        {
            get { return stoneName; }
            set
            { 
                stoneName = value;

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




        private double? cordPrice;
        public double? CordPrice
        {
            get
            {
                return cordPrice;
            }

            set
            {
                cordPrice = value;
                OnPropertyChanged("CordPrice");
                PricePerStone = cordPrice / amountOfStone;

                _errorsViewModel.ClearErrors(nameof(CordPrice));

                if (CordPrice == null)
                {
                    _errorsViewModel.AddError(nameof(CordPrice), "The field cannot be empty. Depending on the country, the decimal value requires either a period or a comma.");
                }
                else
                {
                    _errorsViewModel.ClearErrors(nameof(CordPrice));
                }

                
            }
        }

      

        private double? amountOfStone;
        public double? AmountOfStone
        {
            get
            {
                return amountOfStone;
            }

            set
            {
                amountOfStone = value;
                OnPropertyChanged("AmountOfStone");
                PricePerStone = cordPrice / amountOfStone;

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

        

        private double? pricePerStone;
        public double? PricePerStone
        {
            get
            {
                return pricePerStone;
            }

            set
            {
                pricePerStone = value.HasValue ? Math.Round(value.Value, 2, MidpointRounding.AwayFromZero) : (double?)null;
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

        private int? diameterOfStone;
        public int? DiameterOfStone
        {
            get { return diameterOfStone; }
            set 
            { 
                diameterOfStone = value;
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

        private string searchStone;
        public string SearchStone
        {
            get
            {
                return searchStone;
            }

            set
            {
                searchStone = value;
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

        
    }


}
