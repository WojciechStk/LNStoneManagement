// <copyright file="StoneServiceTest.cs">Copyright ©  2021</copyright>
using System;
using System.Collections.Generic;
using LNStone.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LNStone.Models.Tests
{
    /// <summary>Ta klasa zawiera sparametryzowane testy jednostek dla StoneService</summary>
    [PexClass(typeof(StoneService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class StoneServiceTest
    {
        /// <summary>Zastępcza klasa testowa dla Add(StoneDTO)</summary>
        [PexMethod]
        public bool AddTest([PexAssumeUnderTest]StoneService target, StoneDTO objNewStone)
        {
            bool result = target.Add(objNewStone);
            return result;
            // TODO: dodaj asercje do metoda StoneServiceTest.AddTest(StoneService, StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla .ctor()</summary>
        [PexMethod]
        public StoneService ConstructorTest()
        {
            StoneService target = new StoneService();
            return target;
            // TODO: dodaj asercje do metoda StoneServiceTest.ConstructorTest()
        }

        /// <summary>Zastępcza klasa testowa dla Delete(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public bool DeleteTest([PexAssumeUnderTest]StoneService target, int? id)
        {
            bool result = target.Delete(id);
            return result;
            // TODO: dodaj asercje do metoda StoneServiceTest.DeleteTest(StoneService, Nullable`1<Int32>)
        }

        /// <summary>Zastępcza klasa testowa dla GetAll()</summary>
        [PexMethod]
        public List<StoneDTO> GetAllTest([PexAssumeUnderTest]StoneService target)
        {
            List<StoneDTO> result = target.GetAll();
            return result;
            // TODO: dodaj asercje do metoda StoneServiceTest.GetAllTest(StoneService)
        }

        /// <summary>Zastępcza klasa testowa dla Update(StoneDTO)</summary>
        [PexMethod]
        public bool UpdateTest(
            [PexAssumeUnderTest]StoneService target,
            StoneDTO objStoneToUpdate
        )
        {
            bool result = target.Update(objStoneToUpdate);
            return result;
            // TODO: dodaj asercje do metoda StoneServiceTest.UpdateTest(StoneService, StoneDTO)
        }

        /// <summary>Zastępcza klasa testowa dla View(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public StoneDTO ViewTest([PexAssumeUnderTest]StoneService target, int? Id)
        {
            StoneDTO result = target.View(Id);
            return result;
            // TODO: dodaj asercje do metoda StoneServiceTest.ViewTest(StoneService, Nullable`1<Int32>)
        }
    }
}
