// <copyright file="StoneViewModelTest.cs">Copyright ©  2021</copyright>
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LNStone.Commands;
using LNStone.Models;
using LNStone.ViewModels;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LNStone.ViewModels.Tests
{

    /// <summary>Ta klasa zawiera sparametryzowane testy jednostek dla StoneViewModel</summary>
    [PexClass(typeof(StoneViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]




    [TestClass]
    public partial class StoneViewModelTest
    {

        private StoneDTO currentStone;
        public StoneDTO CurrentStone
        {
            get => currentStone;
            set { currentStone = value;}
        }

        /// <summary>Zastępcza klasa testowa dla get_ClearCommand()</summary>
        [PexMethod]
        public RelayCommand ClearCommandGetTest([PexAssumeUnderTest]StoneViewModel target)
        {
            RelayCommand result = target.ClearCommand;
            return result;

            // TODO: dodaj asercje do metoda StoneViewModelTest.ClearCommandGetTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla Clear()</summary>
        [PexMethod]
        public void ClearTest([PexAssumeUnderTest]StoneViewModel target)
        {
            target.Clear();


            CurrentStone = null;


            Assert.IsNull(CurrentStone);

            // TODO: dodaj asercje do metoda StoneViewModelTest.ClearTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla .ctor()</summary>
        [PexMethod]
        public StoneViewModel ConstructorTest()
        {
            StoneViewModel target = new StoneViewModel();
            return target;
            // TODO: dodaj asercje do metoda StoneViewModelTest.ConstructorTest()
        }

        /// <summary>Zastępcza klasa testowa dla get_CurrentStone()</summary>
        [PexMethod]
        public StoneDTO CurrentStoneGetTest([PexAssumeUnderTest]StoneViewModel target)
        {
            StoneDTO result = target.CurrentStone;
            return result;
            // TODO: dodaj asercje do metoda StoneViewModelTest.CurrentStoneGetTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_CurrentStone(StoneDTO)</summary>
        [PexMethod]
        public void CurrentStoneSetTest([PexAssumeUnderTest]StoneViewModel target, StoneDTO value)
        {
            target.CurrentStone = value;
            // TODO: dodaj asercje do metoda StoneViewModelTest.CurrentStoneSetTest(StoneViewModel, StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla get_DeleteCommand()</summary>
        [PexMethod]
        public RelayCommand DeleteCommandGetTest([PexAssumeUnderTest]StoneViewModel target)
        {
            RelayCommand result = target.DeleteCommand;
            return result;
            // TODO: dodaj asercje do metoda StoneViewModelTest.DeleteCommandGetTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla Delete()</summary>
        [PexMethod]
        public void DeleteTest([PexAssumeUnderTest]StoneViewModel target)
        {
            target.Delete();
            // TODO: dodaj asercje do metoda StoneViewModelTest.DeleteTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_Faceting()</summary>
        [PexMethod]
        public List<string> FacetingGetTest([PexAssumeUnderTest]StoneViewModel target)
        {
            List<string> result = target.Faceting;
            return result;
            // TODO: dodaj asercje do metoda StoneViewModelTest.FacetingGetTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Faceting(List`1&lt;String&gt;)</summary>
        [PexMethod]
        public void FacetingSetTest([PexAssumeUnderTest]StoneViewModel target, List<string> value)
        {
            target.Faceting = value;
            // TODO: dodaj asercje do metoda StoneViewModelTest.FacetingSetTest(StoneViewModel, List`1<String>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Message()</summary>
        [PexMethod]
        public string MessageGetTest([PexAssumeUnderTest]StoneViewModel target)
        {
            string result = target.Message;
            return result;
            // TODO: dodaj asercje do metoda StoneViewModelTest.MessageGetTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Message(String)</summary>
        [PexMethod]
        public void MessageSetTest([PexAssumeUnderTest]StoneViewModel target, string value)
        {
            target.Message = value;
            // TODO: dodaj asercje do metoda StoneViewModelTest.MessageSetTest(StoneViewModel, String)
        }

        /// <summary>Zastępcza klasa testowa dla get_SaveCommand()</summary>
        [PexMethod]
        public RelayCommand SaveCommandGetTest([PexAssumeUnderTest]StoneViewModel target)
        {
            RelayCommand result = target.SaveCommand;
            return result;
            // TODO: dodaj asercje do metoda StoneViewModelTest.SaveCommandGetTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla Save()</summary>
        [PexMethod]
        public void SaveTest([PexAssumeUnderTest]StoneViewModel target)
        {
            target.Save();
            // TODO: dodaj asercje do metoda StoneViewModelTest.SaveTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_StoneList()</summary>
        [PexMethod]
        public ObservableCollection<StoneDTO> StoneListGetTest([PexAssumeUnderTest]StoneViewModel target)
        {
            ObservableCollection<StoneDTO> result = target.StoneList;
            return result;
            // TODO: dodaj asercje do metoda StoneViewModelTest.StoneListGetTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_StoneList(ObservableCollection`1&lt;StoneDTO&gt;)</summary>
        [PexMethod]
        public void StoneListSetTest(
            [PexAssumeUnderTest]StoneViewModel target,
            ObservableCollection<StoneDTO> value
        )
        {
            target.StoneList = value;
            // TODO: dodaj asercje do metoda StoneViewModelTest.StoneListSetTest(StoneViewModel, ObservableCollection`1<StoneDTO>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Store()</summary>
        [PexMethod]
        public List<string> StoreGetTest([PexAssumeUnderTest]StoneViewModel target)
        {
            List<string> result = target.Store;
            return result;
            // TODO: dodaj asercje do metoda StoneViewModelTest.StoreGetTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Store(List`1&lt;String&gt;)</summary>
        [PexMethod]
        public void StoreSetTest([PexAssumeUnderTest]StoneViewModel target, List<string> value)
        {
            target.Store = value;
            // TODO: dodaj asercje do metoda StoneViewModelTest.StoreSetTest(StoneViewModel, List`1<String>)
        }

        /// <summary>Zastępcza klasa testowa dla get_UpdateCommand()</summary>
        [PexMethod]
        public RelayCommand UpdateCommandGetTest([PexAssumeUnderTest]StoneViewModel target)
        {
            RelayCommand result = target.UpdateCommand;
            return result;
            // TODO: dodaj asercje do metoda StoneViewModelTest.UpdateCommandGetTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla Update()</summary>
        [PexMethod]
        public void UpdateTest([PexAssumeUnderTest]StoneViewModel target)
        {
            target.Update();
            // TODO: dodaj asercje do metoda StoneViewModelTest.UpdateTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_ViewCommand()</summary>
        [PexMethod]
        public RelayCommand ViewCommandGetTest([PexAssumeUnderTest]StoneViewModel target)
        {
            RelayCommand result = target.ViewCommand;
            return result;
            // TODO: dodaj asercje do metoda StoneViewModelTest.ViewCommandGetTest(StoneViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla View()</summary>
        [PexMethod(MaxBranches = 20000)]
        public void ViewTest([PexAssumeUnderTest]StoneViewModel target)
        {
            target.View();
            // TODO: dodaj asercje do metoda StoneViewModelTest.ViewTest(StoneViewModel)
        }
    }
}
