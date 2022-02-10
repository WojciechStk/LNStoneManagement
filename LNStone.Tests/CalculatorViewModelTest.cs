using System.Reflection;
// <copyright file="CalculatorViewModelTest.cs">Copyright ©  2021</copyright>

using System;
using LNStone.ViewModels;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LNStone.ViewModels.Tests
{
    [TestClass]
    [PexClass(typeof(CalculatorViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CalculatorViewModelTest
    {

        [PexMethod(MaxBranches = 20000)]
        [PexMethodUnderTest("BindComboBox()")]
        internal void BindComboBox([PexAssumeUnderTest] CalculatorViewModel target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            object result = ((MethodBase)(typeof(CalculatorViewModel).GetMethod("BindComboBox",
                                                                                BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                                CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.BindComboBox(CalculatorViewModel)
        }
    }
}
