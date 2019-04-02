using System;
using Calculator.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSUnitTestProject
{
    [TestClass]
    public class IntTest
    {
        static CalculatorCreator Creator;
        static ICalculator<int> Calculator;

        [TestInitialize]
        public void TestInit()
        {
            Creator = new CalculatorCreator();
            Calculator = Creator.Create<int>();
        }

        [TestMethod]
        public void AdditionTest()
        {
            var a = 1;
            var b = 2;
            var expectedResult = 3;

            var realResul = Calculator.Sum(a, b);

            Assert.AreEqual(expectedResult, realResul);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            var a = 1;
            var b = 2;
            var expectedResult = -1;

            var realResul = Calculator.Sub(a, b);

            Assert.AreEqual(expectedResult, realResul);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            var a = 2;
            var b = 3;
            var expectedResult = 6;

            var realResul = Calculator.Mul(a, b);

            Assert.AreEqual(expectedResult, realResul);
        }

        [TestMethod]
        public void DivisionTest()
        {
            var a = 1;
            var b = 2;
            var expectedResult = 0;

            var realResul = Calculator.Div(a, b);

            Assert.AreEqual(expectedResult, realResul);
        }

        [TestMethod]
        public void DivisionByZeroTest()
        {
            var a = 3;
            var b = 0;
            Assert.ThrowsException<DivideByZeroException>(() => Calculator.Div(a, b));
        }
    }
}
