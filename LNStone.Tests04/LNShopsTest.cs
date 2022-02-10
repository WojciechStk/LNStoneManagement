// <copyright file="LNShopsTest.cs">Copyright ©  2021</copyright>
using System;
using LNStone.Views;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LNStone.Views.Tests
{
    /// <summary>Ta klasa zawiera sparametryzowane testy jednostek dla LNShops</summary>
    [PexClass(typeof(LNShops))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class LNShopsTest
    {
        /// <summary>Zastępcza klasa testowa dla .ctor()</summary>
        [PexMethod]
        public LNShops ConstructorTest()
        {
            LNShops target = new LNShops();
            return target;
            // TODO: dodaj asercje do metoda LNShopsTest.ConstructorTest()
        }
    }
}
