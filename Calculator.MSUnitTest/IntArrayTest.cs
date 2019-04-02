using Calculator.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSUnitTestProject
{
    [TestClass]
    public class IntArrayTest
    {
        static CalculatorCreator Creator;
        static ICalculator<int[]> Calculator;

        [TestInitialize]
        public void TestInit()
        {
            Creator = new CalculatorCreator();
            Calculator = Creator.Create<int[]>();
        }

        [TestMethod]
        public void Add_SameLengthArray_Success()
        {
            var a = new int[] { 1, 2, 3 };
            var b = new int[] { 0, 7, 5 };
            var expectedResult = new int[] { 1, 9, 8 };

            var realResul = Calculator.Sum(a, b);

            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], realResul[j]);
            }
        }

        [TestMethod]
        public void Sub_SameLengthArray_Success()
        {
            var a = new int[] { 1, 2, 5 };
            var b = new int[] { 0, 7, 3 };
            var expectedResult = new int[] { 1, -5, 2 };

            var realResul = Calculator.Sub(a, b);

            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], realResul[j]);
            }
        }

        [TestMethod]
        public void Mul_SameLengthArray_Success()
        {
            var a = new int[] { 1, 2, 3 };
            var b = new int[] { 0, 7, -5 };
            var expectedResult = new int[] { 0, 14, -15 };

            var realResul = Calculator.Mul(a, b);

            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], realResul[j]);
            }
        }

        [TestMethod]
        public void Div_SameLengthArray_Success()
        {
            var a = new int[] { 1, -11, 9 };
            var b = new int[] { 2, 2, 3 };
            var expectedResult = new int[] { 0, -5, 3 };

            var realResul = Calculator.Div(a, b);

            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], realResul[j]);
            }
        }

        [TestMethod]
        public void Add_DifferentLengthArray_Success()
        {
            var a = new int[] { 1, 2, 3 };
            var b = new int[] { 0, 7, -5, 6 };

            var expectedResult = new int[] { 1, 9, -2, 6 };
            var realResul = Calculator.Sum(a, b);
            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], realResul[j]);
            }

            expectedResult = new int[] { 1, 9, -2, 6 };
            realResul = Calculator.Sum(b, a);
            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], realResul[j]);
            }
        }

        [TestMethod]
        public void Sub_DifferentLengthArray_Success()
        {
            var a = new int[] { 1, 2, 5 };
            var b = new int[] { 0, 7, 3, 5 };

            var expectedResult = new int[] { 1, -5, 2, -5 };
            var realResul = Calculator.Sub(a, b);
            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], realResul[j]);
            }

            expectedResult = new int[] { -1, 5, -2, 5 };
            realResul = Calculator.Sub(b, a);
            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], realResul[j]);
            }
        }

        [TestMethod]
        public void Mul_DifferentLengthArray_Success()
        {
            var a = new int[] { 1, 2, 3 };
            var b = new int[] { 0, 7, -5, 4 };

            var expectedResult = new int[] { 0, 14, -15, 4 };
            var realResul = Calculator.Mul(a, b);
            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], realResul[j]);
            }

            expectedResult = new int[] { 0, 14, -15, 4 };
            realResul = Calculator.Mul(b, a);
            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], realResul[j]);
            }
        }

        [TestMethod]
        public void Div_DifferentLengthArray_Success()
        {
            var a = new int[] { 1, -5, 9, -12 };
            var b = new int[] { 2, 16, 3, 5, 7 };

            var expectedResult = new int[] { 0, 0, 3, -2, 0 };
            var realResul = Calculator.Div(a, b);
            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], realResul[j]);
            }

            expectedResult = new int[] { 2, -3, 0, 0, 7 };
            realResul = Calculator.Div(b, a);
            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], realResul[j]);
            }
        }

        [TestMethod]
        public void Div_DivisionByZero_Exception()
        {
            var a = new int[] { 1, 2, 3 };
            var b = new int[] { 3, 0, -5, 6 };
            Assert.ThrowsException<DivideByZeroException>(() => Calculator.Div(a, b));
        }

        [TestMethod]
        public void Add_NullArray_Exception()
        {
            var a = new int[] { 1, 2, 3 };
            Assert.ThrowsException<NullReferenceException>(() => Calculator.Sum(null, a));
        }

        [TestMethod]
        public void Mul_NullArray_Exception()
        {
            var a = new int[] { 1, 2, 3 };
            Assert.ThrowsException<NullReferenceException>(() => Calculator.Mul(a, null));
        }

        [TestMethod]
        public void Div_NullArray_Exception()
        {
            var a = new int[] { 1, 2, 3 };
            Assert.ThrowsException<NullReferenceException>(() => Calculator.Mul(null, a));
        }

        [TestMethod]
        public void Sub_NullArray_Exception()
        {
            var a = new int[] { 1, 2, 3 };
            Assert.ThrowsException<NullReferenceException>(() => Calculator.Sub(null, a));
        }
    }
}
