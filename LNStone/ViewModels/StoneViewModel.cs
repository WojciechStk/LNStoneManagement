using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using LNStone.Commands;
using LNStone.Models;


namespace LNStone.ViewModels
{
    ///<summary>
    /// This class implements INotifyPropertyChanged
    /// to support one-way and two-way bindings
    /// (such that the UI element updates when the source
    /// has been changed dynamically)
    /// </summary>
    
    public class StoneViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged_Implementation
        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); 
        }
        #endregion

        #region ObjStoneService
        // Binding to the database and binding command that can always execute.
        private readonly StoneService ObjStoneService;

        public StoneViewModel()
        {
            ObjStoneService = new StoneService();
            LoadData();
            _currentStone = new StoneDTO();
            _saveCommand = new RelayCommand(Save);
            _viewCommand = new RelayCommand(View);
            _updateCommand = new RelayCommand(Update);
            _deleteCommand = new RelayCommand(Delete);
            _clearCommand = new RelayCommand(Clear);
        }
        #endregion

        #region DisplayOperation
        private ObservableCollection<StoneDTO> _stoneList;
        public ObservableCollection<StoneDTO> StoneList
        {
            get => _stoneList;
            set { _stoneList = value; OnPropertyChanged("StoneList"); }
        }
        private void LoadData()
        {
            StoneList = new ObservableCollection<StoneDTO>(ObjStoneService.GetAll());
        }
        #endregion

        #region StoneAssignmentOperation
        private StoneDTO _currentStone;
        public StoneDTO CurrentStone
        {
            get => _currentStone;
            set { _currentStone = value; OnPropertyChanged("CurrentStone"); }
        }
        #endregion

        #region Save Operation
        private readonly RelayCommand _saveCommand;
        public RelayCommand SaveCommand => _saveCommand;

        public void Save()
        {
            try
            {
                var IsSave = ObjStoneService.Add(CurrentStone);
                LoadData();
                Message = IsSave ? "The Item has been saved." : "Save operation failed.";

            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
            CurrentStone = new StoneDTO();
        }
        #endregion

        #region Search Operation
        private readonly RelayCommand _viewCommand;
        public RelayCommand ViewCommand => _viewCommand;

        public void View()
        {
            try
            {
                var ObjStone = ObjStoneService.View(CurrentStone.Id);
                if (ObjStone != null)
                {
                    Message = "The Item has been viewed.";
                    CurrentStone.Id = ObjStone.Id;
                    CurrentStone.StoneName = ObjStone.StoneName;
                    CurrentStone.CordPrice = ObjStone.CordPrice;
                    CurrentStone.AmountOfStone = ObjStone.AmountOfStone;
                    CurrentStone.DiameterOfStone = ObjStone.DiameterOfStone;
                    CurrentStone.PricePerStone = ObjStone.PricePerStone;
                    CurrentStone.Store = ObjStone.Store;
                    CurrentStone.Faceting = ObjStone.Faceting;
                }
                else
                {
                    Message = "View operation failed.";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion

        #region Update Operation
        private readonly RelayCommand _updateCommand;
        public RelayCommand UpdateCommand => _updateCommand;

        public void Update()
        {
            try
            {
                var IsUpdated = ObjStoneService.Update(CurrentStone);
                if (IsUpdated)
                {
                    Message = "Item has been updated.";
                    LoadData();
                }
                else
                {
                    Message = "Update operation failed.";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion

        #region Delete Operation
        private readonly RelayCommand _deleteCommand;

        public RelayCommand DeleteCommand => _deleteCommand;
        
        public void Delete()
        {
            try
            {
                var IsDelete = ObjStoneService.Delete(CurrentStone.Id);
                if (IsDelete)
                {
                    Message = "Item has been deleted.";
                    LoadData();
                }
                else
                {
                    Message = "Delete operation failed.";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        #endregion

        #region Clear Operation

        private readonly RelayCommand _clearCommand;

        public RelayCommand ClearCommand => _clearCommand;

        public void Clear()
        {
            try
            {
                if (CurrentStone != null)
                {
                    CurrentStone.Id = null;
                    CurrentStone.StoneName = null;
                    CurrentStone.CordPrice = null;
                    CurrentStone.AmountOfStone = null;
                    CurrentStone.DiameterOfStone = null;
                    CurrentStone.PricePerStone = null;
                    CurrentStone.Store = null;
                    CurrentStone.Faceting = null;
                    Message = "The form has been cleared";
                }
                else
                {
                    Message = "The form has not been cleared";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region MessageOperation
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; OnPropertyChanged("Message"); }
        }
        #endregion

        #region StoreList
        private List<string> _store;
        public List<string> Store
        {
            get
            {
                return new List<string>() { "Manzuko", "Kamieniołomy", "Pasart", "Royal-Stone", "Other" };
            }
            set
            {
                _store = value;
            }
        }
        #endregion

        #region FacetingList
        private List<string> _faceting;
        public List<string> Faceting
        {
            get
            {
                return new List<string>() { "Yes", "No", "Other" };
            }
            set
            {
                _faceting = value;
            }
        }
        #endregion
    }
}
