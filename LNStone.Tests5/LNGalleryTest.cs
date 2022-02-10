// <copyright file="LNGalleryTest.cs">Copyright ©  2021</copyright>
using System;
using LNStone.Views;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LNStone.Views.Tests
{
    /// <summary>Ta klasa zawiera sparametryzowane testy jednostek dla LNGallery</summary>
    [PexClass(typeof(LNGallery))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class LNGalleryTest
    {
        /// <summary>Zastępcza klasa testowa dla .ctor()</summary>
        [PexMethod]
        public LNGallery ConstructorTest()
        {
            LNGallery target = new LNGallery();
            return target;
            // TODO: dodaj asercje do metoda LNGalleryTest.ConstructorTest()
        }
    }
}
