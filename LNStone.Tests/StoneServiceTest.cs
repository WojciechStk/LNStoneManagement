using System.Collections.Generic;
// <copyright file="StoneServiceTest.cs">Copyright ©  2021</copyright>

using System;
using LNStone.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LNStone.Models.Tests
{
    [TestClass]
    [PexClass(typeof(StoneService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StoneServiceTest
    {

        [PexMethod(MaxBranches = 20000)]
        public List<StoneDTO> GetAll([PexAssumeUnderTest] StoneService target)
        {
            List<StoneDTO> result = target.GetAll();
            return result;
            // TODO: dodaj asercje do metoda StoneServiceTest.GetAll(StoneService)
        }
    }
}
