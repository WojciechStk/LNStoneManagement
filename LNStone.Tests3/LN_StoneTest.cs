// <copyright file="LN_StoneTest.cs">Copyright ©  2021</copyright>
using System;
using LNStone.Views;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LNStone.Views.Tests
{
    /// <summary>Ta klasa zawiera sparametryzowane testy jednostek dla LN_Stone</summary>
    [PexClass(typeof(LN_Stone))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class LN_StoneTest
    {
    }
}
