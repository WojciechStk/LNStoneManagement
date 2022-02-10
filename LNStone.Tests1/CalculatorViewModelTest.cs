// <copyright file="CalculatorViewModelTest.cs">Copyright ©  2021</copyright>
using System;
using LNStone.ViewModels;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LNStone.ViewModels.Tests
{
    /// <summary>Ta klasa zawiera sparametryzowane testy jednostek dla CalculatorViewModel</summary>
    [PexClass(typeof(CalculatorViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CalculatorViewModelTest
    {
    }
}
