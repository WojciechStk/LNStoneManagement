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
        /// <summary>Zastępcza klasa testowa dla GetAll()</summary>
        [PexMethod]
        public List<StoneDTO> GetAllTest([PexAssumeUnderTest]StoneService target)
        {
            List<StoneDTO> result = target.GetAll();
            return result;
            // TODO: dodaj asercje do metoda StoneServiceTest.GetAllTest(StoneService)
        }
    }
}
