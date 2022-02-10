// <copyright file="StoneDTOTest.cs">Copyright ©  2021</copyright>
using System;
using System.Collections;
using LNStone.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LNStone.Models.Tests
{
    /// <summary>Ta klasa zawiera sparametryzowane testy jednostek dla StoneDTO</summary>
    [PexClass(typeof(StoneDTO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]

    
    public partial class StoneDTOTest
    {


        /// <summary>Zastępcza klasa testowa dla get_AmountOfStone()</summary>
        [PexMethod]
        public double? AmountOfStoneGetTest(StoneDTO target)
        {

            
            
            double? result = target.AmountOfStone;


            return result;



              
            // TODO: dodaj asercje do metoda StoneDTOTest.AmountOfStoneGetTest(StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla set_AmountOfStone(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void AmountOfStoneSetTest([PexAssumeUnderTest]StoneDTO target, double? value)
        {
            target.AmountOfStone = value;
            // TODO: dodaj asercje do metoda StoneDTOTest.AmountOfStoneSetTest(StoneDTO, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_CanCreate()</summary>
        [PexMethod]
        public bool CanCreateGetTest([PexAssumeUnderTest]StoneDTO target)
        {
            bool result = target.CanCreate;
            return result;
            // TODO: dodaj asercje do metoda StoneDTOTest.CanCreateGetTest(StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla .ctor()</summary>
        [PexMethod]
        public StoneDTO ConstructorTest()
        {
            StoneDTO target = new StoneDTO();
            return target;
            // TODO: dodaj asercje do metoda StoneDTOTest.ConstructorTest()
        }

        /// <summary>Zastępcza klasa testowa dla get_CordPrice()</summary>
        [PexMethod]
        public double? CordPriceGetTest([PexAssumeUnderTest]StoneDTO target)
        {
            double? result = target.CordPrice;
            return result;
            // TODO: dodaj asercje do metoda StoneDTOTest.CordPriceGetTest(StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla set_CordPrice(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void CordPriceSetTest([PexAssumeUnderTest]StoneDTO target, double? value)
        {
            target.CordPrice = value;
            // TODO: dodaj asercje do metoda StoneDTOTest.CordPriceSetTest(StoneDTO, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_DiameterOfStone()</summary>
        [PexMethod]
        public int? DiameterOfStoneGetTest([PexAssumeUnderTest]StoneDTO target)
        {
            int? result = target.DiameterOfStone;
            return result;
            // TODO: dodaj asercje do metoda StoneDTOTest.DiameterOfStoneGetTest(StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla set_DiameterOfStone(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public void DiameterOfStoneSetTest([PexAssumeUnderTest]StoneDTO target, int? value)
        {
            target.DiameterOfStone = value;
            // TODO: dodaj asercje do metoda StoneDTOTest.DiameterOfStoneSetTest(StoneDTO, Nullable`1<Int32>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Faceting()</summary>
        [PexMethod]
        public string FacetingGetTest([PexAssumeUnderTest]StoneDTO target)
        {
            string result = target.Faceting;
            return result;
            // TODO: dodaj asercje do metoda StoneDTOTest.FacetingGetTest(StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla set_Faceting(String)</summary>
        [PexMethod]
        public void FacetingSetTest([PexAssumeUnderTest]StoneDTO target, string value)
        {
            target.Faceting = value;
            // TODO: dodaj asercje do metoda StoneDTOTest.FacetingSetTest(StoneDTO, String)
        }

        /// <summary>Zastępcza klasa testowa dla GetErrors(String)</summary>
        [PexMethod]
        public IEnumerable GetErrorsTest([PexAssumeUnderTest]StoneDTO target, string propertyName)
        {
            IEnumerable result = target.GetErrors(propertyName);
            return result;
            // TODO: dodaj asercje do metoda StoneDTOTest.GetErrorsTest(StoneDTO, String)
        }

        /// <summary>Zastępcza klasa testowa dla get_HasErrors()</summary>
        [PexMethod]
        public bool HasErrorsGetTest([PexAssumeUnderTest]StoneDTO target)
        {
            bool result = target.HasErrors;
            return result;
            // TODO: dodaj asercje do metoda StoneDTOTest.HasErrorsGetTest(StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla get_Id()</summary>
        [PexMethod]
        public int? IdGetTest([PexAssumeUnderTest]StoneDTO target)
        {
            int? result = target.Id;
            return result;
            // TODO: dodaj asercje do metoda StoneDTOTest.IdGetTest(StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla set_Id(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public void IdSetTest([PexAssumeUnderTest]StoneDTO target, int? value)
        {
            target.Id = value;
            // TODO: dodaj asercje do metoda StoneDTOTest.IdSetTest(StoneDTO, Nullable`1<Int32>)
        }

        /// <summary>Zastępcza klasa testowa dla get_PricePerStone()</summary>
        [PexMethod]
        public double? PricePerStoneGetTest([PexAssumeUnderTest]StoneDTO target)
        {
            double? result = target.PricePerStone;
            return result;
            // TODO: dodaj asercje do metoda StoneDTOTest.PricePerStoneGetTest(StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla set_PricePerStone(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void PricePerStoneSetTest([PexAssumeUnderTest]StoneDTO target, double? value)
        {
            target.PricePerStone = value;
            // TODO: dodaj asercje do metoda StoneDTOTest.PricePerStoneSetTest(StoneDTO, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_SearchStone()</summary>
        [PexMethod]
        public string SearchStoneGetTest([PexAssumeUnderTest]StoneDTO target)
        {
            string result = target.SearchStone;
            return result;
            // TODO: dodaj asercje do metoda StoneDTOTest.SearchStoneGetTest(StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla set_SearchStone(String)</summary>
        [PexMethod]
        public void SearchStoneSetTest([PexAssumeUnderTest]StoneDTO target, string value)
        {
            target.SearchStone = value;
            // TODO: dodaj asercje do metoda StoneDTOTest.SearchStoneSetTest(StoneDTO, String)
        }

        
        /// <summary>Zastępcza klasa testowa dla get_StoneName()</summary>
        [PexMethod]
        public string StoneNameGetTest([PexAssumeUnderTest]StoneDTO target)
        {
            string result = target.StoneName;
            return result;
            // TODO: dodaj asercje do metoda StoneDTOTest.StoneNameGetTest(StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla set_StoneName(String)</summary>
        [PexMethod]
        public void StoneNameSetTest([PexAssumeUnderTest]StoneDTO target, string value)
        {
            target.StoneName = value;
            // TODO: dodaj asercje do metoda StoneDTOTest.StoneNameSetTest(StoneDTO, String)
        }

        /// <summary>Zastępcza klasa testowa dla get_Store()</summary>
        [PexMethod]
        public string StoreGetTest([PexAssumeUnderTest]StoneDTO target)
        {
            string result = target.Store;
            return result;
            // TODO: dodaj asercje do metoda StoneDTOTest.StoreGetTest(StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla set_Store(String)</summary>
        [PexMethod]
        public void StoreSetTest([PexAssumeUnderTest]StoneDTO target, string value)
        {
            target.Store = value;
            // TODO: dodaj asercje do metoda StoneDTOTest.StoreSetTest(StoneDTO, String)
        }
    }
}
