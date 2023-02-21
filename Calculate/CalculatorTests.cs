using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate.Tests
{
    [TestClass]
        public class CalculatorTests
        {
            Calculator calc = new();

            [TestMethod]
            public void TestAdditionCorrect()
            {
                double testAddActual = Calculator.Add(1, 2);
                double testAddExpect = 3;
                Assert.AreEqual<double>(testAddExpect, testAddActual);
            }

            [TestMethod]
            public void TestSubtractionCorrect()
            {
                double testSubtractActual = Calculator.Subtract(3, 2);
                double testSubtractExpect = 1;
                Assert.AreEqual<double>(testSubtractExpect, testSubtractActual);
            }

            [TestMethod]
            public void TestMultiplicationCorrect()
            {
                double testMultiplyActual = Calculator.Multiply(1, 2);
                double testMultiplyExpect = 2;
                Assert.AreEqual<double>(testMultiplyExpect, testMultiplyActual);
            }

            [TestMethod]
            public void TestDivisionCorrect()
            {
                double testDivideActual = Calculator.Divide(6, 2);
                double testDivideExpect = 3;
                Assert.AreEqual<double>(testDivideExpect, testDivideActual);
            }

            [TestMethod]
            public void TestAdditionIncorrect()
            {
                double testAddActual = Calculator.Add(1, 2);
                double testAddExpect = 3;
                Assert.AreNotEqual<double>(testAddExpect, testAddActual);
            }

            [TestMethod]
            public void TestSubtractionIncorrect()
            {
                double testSubtractActual = Calculator.Subtract(3, 2);
                double testSubtractExpect = 1;
                Assert.AreNotEqual<double>(testSubtractExpect, testSubtractActual);
            }

            [TestMethod]
            public void TestMultiplicationIncorrect()
            {
                double testMultiplyActual = Calculator.Multiply(1, 2);
                double testMultiplyExpect = 2;
                Assert.AreNotEqual<double>(testMultiplyExpect, testMultiplyActual);
            }

            [TestMethod]
            public void TestDivisionIncorrect()
            {
                double testDivideActual = Calculator.Divide(6, 2);
                double testDivideExpect = 3;
                Assert.AreNotEqual<double>(testDivideExpect, testDivideActual);
            }

            [TestMethod]
                public void TestInvalidInput()
                {

                }
            }
}
