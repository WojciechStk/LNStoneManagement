using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using LNStone.Models;
using LNStone.Commands;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Windows.Data;
using System.Xml.Linq;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;


namespace LNStone.ViewModels
{
    public class StoneViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged_Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        

        private readonly StoneService ObjStoneService;
        public StoneViewModel()
        {
            ObjStoneService = new StoneService();
            LoadData();
            currentStone = new StoneDTO();
            saveCommand = new RelayCommand(Save);
            viewCommand = new RelayCommand(View);
            updateCommand = new RelayCommand(Update);
            deleteCommand = new RelayCommand(Delete);
            clearCommand = new RelayCommand(Clear);
            
        }







        #region DisplayOperation
        private ObservableCollection<StoneDTO> stoneList;
        public ObservableCollection<StoneDTO> StoneList
        {
            get { return stoneList; }
            set { stoneList = value; OnPropertyChanged("StoneList"); }
        }
        private void LoadData()
        {
            StoneList = new ObservableCollection<StoneDTO>(ObjStoneService.GetAll());
        }
        #endregion

        private StoneDTO currentStone;

        public StoneDTO CurrentStone
        {
            get { return currentStone; }
            set { currentStone = value; OnPropertyChanged("CurrentStone"); }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        #region Save Operation
        private readonly RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }
        public void Save()
        {
            try
            {
                var IsSave = ObjStoneService.Add(CurrentStone);
                LoadData();
                if (IsSave)
                    Message = "The Item has been saved.";
                else
                    Message = "The operation was unsuccessful!";

            }
            catch (Exception)
            {
                



            }

            CurrentStone = new StoneDTO();
        }
        #endregion

        #region Search Operation
        private readonly RelayCommand viewCommand;

        public RelayCommand ViewCommand
        {
            get { return viewCommand; }
        }
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
        private readonly RelayCommand updateCommand;

        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
        }

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
        private readonly RelayCommand deleteCommand;

        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
        }

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

        private readonly RelayCommand clearCommand;

        public RelayCommand ClearCommand
        {
            get { return clearCommand; }
        }

        

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
                   
                    

                    Message = "The form has been cleared";
                }
                else
                {
                    Message = "The form has not been cleared";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        

    }
}
