// <copyright file="CalculatorViewModelTest.cs">Copyright ©  2021</copyright>
using System;
using System.Collections.Generic;
using LNStone;
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
        /// <summary>Zastępcza klasa testowa dla .ctor()</summary>
        [PexMethod]
        public CalculatorViewModel ConstructorTest()
        {
            CalculatorViewModel target = new CalculatorViewModel();
            return target;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.ConstructorTest()
        }

        /// <summary>Zastępcza klasa testowa dla get_Margin()</summary>
        [PexMethod]
        public List<int> MarginGetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            List<int> result = target.Margin;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MarginGetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Margin(List`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public void MarginSetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            List<int> value
        )
        {
            target.Margin = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MarginSetTest(CalculatorViewModel, List`1<Int32>)
        }

        /// <summary>Zastępcza klasa testowa dla get_MySelectedStone1()</summary>
        [PexMethod]
        public Stone MySelectedStone1GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            Stone result = target.MySelectedStone1;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone1GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_MySelectedStone1(Stone)</summary>
        [PexMethod]
        public void MySelectedStone1SetTest([PexAssumeUnderTest]CalculatorViewModel target, Stone value)
        {
            target.MySelectedStone1 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone1SetTest(CalculatorViewModel, Stone)
        }

        /// <summary>Zastępcza klasa testowa dla get_MySelectedStone2()</summary>
        [PexMethod]
        public Stone MySelectedStone2GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            Stone result = target.MySelectedStone2;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone2GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_MySelectedStone2(Stone)</summary>
        [PexMethod]
        public void MySelectedStone2SetTest([PexAssumeUnderTest]CalculatorViewModel target, Stone value)
        {
            target.MySelectedStone2 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone2SetTest(CalculatorViewModel, Stone)
        }

        /// <summary>Zastępcza klasa testowa dla get_MySelectedStone3()</summary>
        [PexMethod]
        public Stone MySelectedStone3GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            Stone result = target.MySelectedStone3;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone3GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_MySelectedStone3(Stone)</summary>
        [PexMethod]
        public void MySelectedStone3SetTest([PexAssumeUnderTest]CalculatorViewModel target, Stone value)
        {
            target.MySelectedStone3 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone3SetTest(CalculatorViewModel, Stone)
        }

        /// <summary>Zastępcza klasa testowa dla get_MySelectedStone4()</summary>
        [PexMethod]
        public Stone MySelectedStone4GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            Stone result = target.MySelectedStone4;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone4GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_MySelectedStone4(Stone)</summary>
        [PexMethod]
        public void MySelectedStone4SetTest([PexAssumeUnderTest]CalculatorViewModel target, Stone value)
        {
            target.MySelectedStone4 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone4SetTest(CalculatorViewModel, Stone)
        }

        /// <summary>Zastępcza klasa testowa dla get_MySelectedStone5()</summary>
        [PexMethod]
        public Stone MySelectedStone5GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            Stone result = target.MySelectedStone5;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone5GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_MySelectedStone5(Stone)</summary>
        [PexMethod]
        public void MySelectedStone5SetTest([PexAssumeUnderTest]CalculatorViewModel target, Stone value)
        {
            target.MySelectedStone5 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone5SetTest(CalculatorViewModel, Stone)
        }

        /// <summary>Zastępcza klasa testowa dla get_MySelectedStone6()</summary>
        [PexMethod]
        public Stone MySelectedStone6GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            Stone result = target.MySelectedStone6;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone6GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_MySelectedStone6(Stone)</summary>
        [PexMethod]
        public void MySelectedStone6SetTest([PexAssumeUnderTest]CalculatorViewModel target, Stone value)
        {
            target.MySelectedStone6 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone6SetTest(CalculatorViewModel, Stone)
        }

        /// <summary>Zastępcza klasa testowa dla get_MySelectedStone7()</summary>
        [PexMethod]
        public Stone MySelectedStone7GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            Stone result = target.MySelectedStone7;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone7GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_MySelectedStone7(Stone)</summary>
        [PexMethod]
        public void MySelectedStone7SetTest([PexAssumeUnderTest]CalculatorViewModel target, Stone value)
        {
            target.MySelectedStone7 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone7SetTest(CalculatorViewModel, Stone)
        }

        /// <summary>Zastępcza klasa testowa dla get_MySelectedStone8()</summary>
        [PexMethod]
        public Stone MySelectedStone8GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            Stone result = target.MySelectedStone8;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone8GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_MySelectedStone8(Stone)</summary>
        [PexMethod]
        public void MySelectedStone8SetTest([PexAssumeUnderTest]CalculatorViewModel target, Stone value)
        {
            target.MySelectedStone8 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone8SetTest(CalculatorViewModel, Stone)
        }

        /// <summary>Zastępcza klasa testowa dla get_MySelectedStone9()</summary>
        [PexMethod]
        public Stone MySelectedStone9GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            Stone result = target.MySelectedStone9;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone9GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_MySelectedStone9(Stone)</summary>
        [PexMethod]
        public void MySelectedStone9SetTest([PexAssumeUnderTest]CalculatorViewModel target, Stone value)
        {
            target.MySelectedStone9 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStone9SetTest(CalculatorViewModel, Stone)
        }

        /// <summary>Zastępcza klasa testowa dla get_MySelectedStone()</summary>
        [PexMethod]
        public Stone MySelectedStoneGetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            Stone result = target.MySelectedStone;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStoneGetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_MySelectedStone(Stone)</summary>
        [PexMethod]
        public void MySelectedStoneSetTest([PexAssumeUnderTest]CalculatorViewModel target, Stone value)
        {
            target.MySelectedStone = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.MySelectedStoneSetTest(CalculatorViewModel, Stone)
        }

        /// <summary>Zastępcza klasa testowa dla get_Price_Per_Stone1()</summary>
        [PexMethod]
        public double? Price_Per_Stone1GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Price_Per_Stone1;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Price_Per_Stone1GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_Price_Per_Stone2()</summary>
        [PexMethod]
        public double? Price_Per_Stone2GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Price_Per_Stone2;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Price_Per_Stone2GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_Price_Per_Stone3()</summary>
        [PexMethod]
        public double? Price_Per_Stone3GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Price_Per_Stone3;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Price_Per_Stone3GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_Price_Per_Stone4()</summary>
        [PexMethod]
        public double? Price_Per_Stone4GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Price_Per_Stone4;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Price_Per_Stone4GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_Price_Per_Stone5()</summary>
        [PexMethod]
        public double? Price_Per_Stone5GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Price_Per_Stone5;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Price_Per_Stone5GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_Price_Per_Stone6()</summary>
        [PexMethod]
        public double? Price_Per_Stone6GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Price_Per_Stone6;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Price_Per_Stone6GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_Price_Per_Stone7()</summary>
        [PexMethod]
        public double? Price_Per_Stone7GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Price_Per_Stone7;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Price_Per_Stone7GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_Price_Per_Stone8()</summary>
        [PexMethod]
        public double? Price_Per_Stone8GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Price_Per_Stone8;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Price_Per_Stone8GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_Price_Per_Stone9()</summary>
        [PexMethod]
        public double? Price_Per_Stone9GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Price_Per_Stone9;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Price_Per_Stone9GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_Price_Per_Stone()</summary>
        [PexMethod]
        public double? Price_Per_StoneGetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Price_Per_Stone;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Price_Per_StoneGetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla get_Quantity()</summary>
        [PexMethod]
        public List<int> QuantityGetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            List<int> result = target.Quantity;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.QuantityGetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Quantity(List`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public void QuantitySetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            List<int> value
        )
        {
            target.Quantity = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.QuantitySetTest(CalculatorViewModel, List`1<Int32>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Result1()</summary>
        [PexMethod]
        public double? Result1GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Result1;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result1GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Result1(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void Result1SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            double? value
        )
        {
            target.Result1 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result1SetTest(CalculatorViewModel, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Result2()</summary>
        [PexMethod]
        public double? Result2GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Result2;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result2GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Result2(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void Result2SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            double? value
        )
        {
            target.Result2 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result2SetTest(CalculatorViewModel, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Result3()</summary>
        [PexMethod]
        public double? Result3GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Result3;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result3GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Result3(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void Result3SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            double? value
        )
        {
            target.Result3 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result3SetTest(CalculatorViewModel, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Result4()</summary>
        [PexMethod]
        public double? Result4GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Result4;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result4GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Result4(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void Result4SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            double? value
        )
        {
            target.Result4 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result4SetTest(CalculatorViewModel, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Result5()</summary>
        [PexMethod]
        public double? Result5GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Result5;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result5GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Result5(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void Result5SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            double? value
        )
        {
            target.Result5 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result5SetTest(CalculatorViewModel, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Result6()</summary>
        [PexMethod]
        public double? Result6GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Result6;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result6GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Result6(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void Result6SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            double? value
        )
        {
            target.Result6 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result6SetTest(CalculatorViewModel, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Result7()</summary>
        [PexMethod]
        public double? Result7GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Result7;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result7GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Result7(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void Result7SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            double? value
        )
        {
            target.Result7 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result7SetTest(CalculatorViewModel, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Result8()</summary>
        [PexMethod]
        public double? Result8GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Result8;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result8GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Result8(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void Result8SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            double? value
        )
        {
            target.Result8 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result8SetTest(CalculatorViewModel, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Result9()</summary>
        [PexMethod]
        public double? Result9GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Result9;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result9GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Result9(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void Result9SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            double? value
        )
        {
            target.Result9 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.Result9SetTest(CalculatorViewModel, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Result()</summary>
        [PexMethod]
        public double? ResultGetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Result;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.ResultGetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Result(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void ResultSetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            double? value
        )
        {
            target.Result = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.ResultSetTest(CalculatorViewModel, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_SelectedMargin()</summary>
        [PexMethod]
        public int SelectedMarginGetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            int result = target.SelectedMargin;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedMarginGetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_SelectedMargin(Int32)</summary>
        [PexMethod]
        public void SelectedMarginSetTest([PexAssumeUnderTest]CalculatorViewModel target, int value)
        {
            target.SelectedMargin = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedMarginSetTest(CalculatorViewModel, Int32)
        }

        /// <summary>Zastępcza klasa testowa dla get_SelectedQuantity1()</summary>
        [PexMethod]
        public int SelectedQuantity1GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            int result = target.SelectedQuantity1;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity1GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_SelectedQuantity1(Int32)</summary>
        [PexMethod]
        public void SelectedQuantity1SetTest([PexAssumeUnderTest]CalculatorViewModel target, int value)
        {
            target.SelectedQuantity1 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity1SetTest(CalculatorViewModel, Int32)
        }

        /// <summary>Zastępcza klasa testowa dla get_SelectedQuantity2()</summary>
        [PexMethod]
        public int SelectedQuantity2GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            int result = target.SelectedQuantity2;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity2GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_SelectedQuantity2(Int32)</summary>
        [PexMethod]
        public void SelectedQuantity2SetTest([PexAssumeUnderTest]CalculatorViewModel target, int value)
        {
            target.SelectedQuantity2 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity2SetTest(CalculatorViewModel, Int32)
        }

        /// <summary>Zastępcza klasa testowa dla get_SelectedQuantity3()</summary>
        [PexMethod]
        public int SelectedQuantity3GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            int result = target.SelectedQuantity3;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity3GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_SelectedQuantity3(Int32)</summary>
        [PexMethod]
        public void SelectedQuantity3SetTest([PexAssumeUnderTest]CalculatorViewModel target, int value)
        {
            target.SelectedQuantity3 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity3SetTest(CalculatorViewModel, Int32)
        }

        /// <summary>Zastępcza klasa testowa dla get_SelectedQuantity4()</summary>
        [PexMethod]
        public int SelectedQuantity4GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            int result = target.SelectedQuantity4;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity4GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_SelectedQuantity4(Int32)</summary>
        [PexMethod]
        public void SelectedQuantity4SetTest([PexAssumeUnderTest]CalculatorViewModel target, int value)
        {
            target.SelectedQuantity4 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity4SetTest(CalculatorViewModel, Int32)
        }

        /// <summary>Zastępcza klasa testowa dla get_SelectedQuantity5()</summary>
        [PexMethod]
        public int SelectedQuantity5GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            int result = target.SelectedQuantity5;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity5GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_SelectedQuantity5(Int32)</summary>
        [PexMethod]
        public void SelectedQuantity5SetTest([PexAssumeUnderTest]CalculatorViewModel target, int value)
        {
            target.SelectedQuantity5 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity5SetTest(CalculatorViewModel, Int32)
        }

        /// <summary>Zastępcza klasa testowa dla get_SelectedQuantity6()</summary>
        [PexMethod]
        public int SelectedQuantity6GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            int result = target.SelectedQuantity6;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity6GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_SelectedQuantity6(Int32)</summary>
        [PexMethod]
        public void SelectedQuantity6SetTest([PexAssumeUnderTest]CalculatorViewModel target, int value)
        {
            target.SelectedQuantity6 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity6SetTest(CalculatorViewModel, Int32)
        }

        /// <summary>Zastępcza klasa testowa dla get_SelectedQuantity7()</summary>
        [PexMethod]
        public int SelectedQuantity7GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            int result = target.SelectedQuantity7;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity7GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_SelectedQuantity7(Int32)</summary>
        [PexMethod]
        public void SelectedQuantity7SetTest([PexAssumeUnderTest]CalculatorViewModel target, int value)
        {
            target.SelectedQuantity7 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity7SetTest(CalculatorViewModel, Int32)
        }

        /// <summary>Zastępcza klasa testowa dla get_SelectedQuantity8()</summary>
        [PexMethod]
        public int SelectedQuantity8GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            int result = target.SelectedQuantity8;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity8GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_SelectedQuantity8(Int32)</summary>
        [PexMethod]
        public void SelectedQuantity8SetTest([PexAssumeUnderTest]CalculatorViewModel target, int value)
        {
            target.SelectedQuantity8 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity8SetTest(CalculatorViewModel, Int32)
        }

        /// <summary>Zastępcza klasa testowa dla get_SelectedQuantity9()</summary>
        [PexMethod]
        public int SelectedQuantity9GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            int result = target.SelectedQuantity9;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity9GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_SelectedQuantity9(Int32)</summary>
        [PexMethod]
        public void SelectedQuantity9SetTest([PexAssumeUnderTest]CalculatorViewModel target, int value)
        {
            target.SelectedQuantity9 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantity9SetTest(CalculatorViewModel, Int32)
        }

        /// <summary>Zastępcza klasa testowa dla get_SelectedQuantity()</summary>
        [PexMethod]
        public int SelectedQuantityGetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            int result = target.SelectedQuantity;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantityGetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_SelectedQuantity(Int32)</summary>
        [PexMethod]
        public void SelectedQuantitySetTest([PexAssumeUnderTest]CalculatorViewModel target, int value)
        {
            target.SelectedQuantity = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SelectedQuantitySetTest(CalculatorViewModel, Int32)
        }

        /// <summary>Zastępcza klasa testowa dla get_StoneSelected1()</summary>
        [PexMethod]
        public List<Stone> StoneSelected1GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            List<Stone> result = target.StoneSelected1;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected1GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_StoneSelected1(List`1&lt;Stone&gt;)</summary>
        [PexMethod]
        public void StoneSelected1SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            List<Stone> value
        )
        {
            target.StoneSelected1 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected1SetTest(CalculatorViewModel, List`1<Stone>)
        }

        /// <summary>Zastępcza klasa testowa dla get_StoneSelected2()</summary>
        [PexMethod]
        public List<Stone> StoneSelected2GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            List<Stone> result = target.StoneSelected2;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected2GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_StoneSelected2(List`1&lt;Stone&gt;)</summary>
        [PexMethod]
        public void StoneSelected2SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            List<Stone> value
        )
        {
            target.StoneSelected2 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected2SetTest(CalculatorViewModel, List`1<Stone>)
        }

        /// <summary>Zastępcza klasa testowa dla get_StoneSelected3()</summary>
        [PexMethod]
        public List<Stone> StoneSelected3GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            List<Stone> result = target.StoneSelected3;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected3GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_StoneSelected3(List`1&lt;Stone&gt;)</summary>
        [PexMethod]
        public void StoneSelected3SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            List<Stone> value
        )
        {
            target.StoneSelected3 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected3SetTest(CalculatorViewModel, List`1<Stone>)
        }

        /// <summary>Zastępcza klasa testowa dla get_StoneSelected4()</summary>
        [PexMethod]
        public List<Stone> StoneSelected4GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            List<Stone> result = target.StoneSelected4;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected4GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_StoneSelected4(List`1&lt;Stone&gt;)</summary>
        [PexMethod]
        public void StoneSelected4SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            List<Stone> value
        )
        {
            target.StoneSelected4 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected4SetTest(CalculatorViewModel, List`1<Stone>)
        }

        /// <summary>Zastępcza klasa testowa dla get_StoneSelected5()</summary>
        [PexMethod]
        public List<Stone> StoneSelected5GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            List<Stone> result = target.StoneSelected5;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected5GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_StoneSelected5(List`1&lt;Stone&gt;)</summary>
        [PexMethod]
        public void StoneSelected5SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            List<Stone> value
        )
        {
            target.StoneSelected5 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected5SetTest(CalculatorViewModel, List`1<Stone>)
        }

        /// <summary>Zastępcza klasa testowa dla get_StoneSelected6()</summary>
        [PexMethod]
        public List<Stone> StoneSelected6GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            List<Stone> result = target.StoneSelected6;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected6GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_StoneSelected6(List`1&lt;Stone&gt;)</summary>
        [PexMethod]
        public void StoneSelected6SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            List<Stone> value
        )
        {
            target.StoneSelected6 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected6SetTest(CalculatorViewModel, List`1<Stone>)
        }

        /// <summary>Zastępcza klasa testowa dla get_StoneSelected7()</summary>
        [PexMethod]
        public List<Stone> StoneSelected7GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            List<Stone> result = target.StoneSelected7;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected7GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_StoneSelected7(List`1&lt;Stone&gt;)</summary>
        [PexMethod]
        public void StoneSelected7SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            List<Stone> value
        )
        {
            target.StoneSelected7 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected7SetTest(CalculatorViewModel, List`1<Stone>)
        }

        /// <summary>Zastępcza klasa testowa dla get_StoneSelected8()</summary>
        [PexMethod]
        public List<Stone> StoneSelected8GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            List<Stone> result = target.StoneSelected8;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected8GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_StoneSelected8(List`1&lt;Stone&gt;)</summary>
        [PexMethod]
        public void StoneSelected8SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            List<Stone> value
        )
        {
            target.StoneSelected8 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected8SetTest(CalculatorViewModel, List`1<Stone>)
        }

        /// <summary>Zastępcza klasa testowa dla get_StoneSelected9()</summary>
        [PexMethod]
        public List<Stone> StoneSelected9GetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            List<Stone> result = target.StoneSelected9;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected9GetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_StoneSelected9(List`1&lt;Stone&gt;)</summary>
        [PexMethod]
        public void StoneSelected9SetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            List<Stone> value
        )
        {
            target.StoneSelected9 = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelected9SetTest(CalculatorViewModel, List`1<Stone>)
        }

        /// <summary>Zastępcza klasa testowa dla get_StoneSelected()</summary>
        [PexMethod]
        public List<Stone> StoneSelectedGetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            List<Stone> result = target.StoneSelected;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelectedGetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_StoneSelected(List`1&lt;Stone&gt;)</summary>
        [PexMethod]
        public void StoneSelectedSetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            List<Stone> value
        )
        {
            target.StoneSelected = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.StoneSelectedSetTest(CalculatorViewModel, List`1<Stone>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Sum()</summary>
        [PexMethod]
        public double? SumGetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Sum;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SumGetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Sum(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void SumSetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            double? value
        )
        {
            target.Sum = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.SumSetTest(CalculatorViewModel, Nullable`1<Double>)
        }

        /// <summary>Zastępcza klasa testowa dla get_Total()</summary>
        [PexMethod]
        public double? TotalGetTest([PexAssumeUnderTest]CalculatorViewModel target)
        {
            double? result = target.Total;
            return result;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.TotalGetTest(CalculatorViewModel)
        }

        /// <summary>Zastępcza klasa testowa dla set_Total(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public void TotalSetTest(
            [PexAssumeUnderTest]CalculatorViewModel target,
            double? value
        )
        {
            target.Total = value;
            // TODO: dodaj asercje do metoda CalculatorViewModelTest.TotalSetTest(CalculatorViewModel, Nullable`1<Double>)
        }
    }
}
