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
            string testInput = "1 + 2";
            int testExpect = 3;
            Assert.AreEqual(Calculator.TryCalculate(testInput, out testExpect));
        }

        [TestMethod]
            public void TestSubtractionCorrect()
            {
                string testInput = "3 - 2";
                int testExpect = 1;
                Assert.AreEqual(Calculator.TryCalculate(testInput, out testExpect));
            }

        [TestMethod]
            public void TestMultiplicationCorrect()
            {
                string testInput = "1 * 2";
                int testExpect = 2;
                Assert.AreEqual(Calculator.TryCalculate(testInput, out testExpect));
            }

        [TestMethod]
            public void TestDivisionCorrect()
            {
                string testInput = "6 / 3";
                int testExpect = 2;
                Assert.AreEqual(Calculator.TryCalculate(testInput, out testExpect));
            }

        [TestMethod]
            public void TestAdditionIncorrect()
            {
                string testInput = "1 + 2";
                int testExpect = 3;
                Assert.AreNotEqual(Calculator.TryCalculate(testInput, out testExpect));
            }

        [TestMethod]
            public void TestSubtractionIncorrect()
            {
                string testInput = "3 - 2";
                int testExpect = 1;
                Assert.AreNotEqual(Calculator.TryCalculate(testInput, out testExpect));
            }

        [TestMethod]
            public void TestMultiplicationIncorrect()
            {
                string testInput = "1 * 2";
                int testExpect = 2;
                Assert.AreNotEqual(Calculator.TryCalculate(testInput, out testExpect));
            }

        [TestMethod]
            public void TestDivisionIncorrect()
            {
                string testInput = "6 / 3";
                int testExpect = 2;
                Assert.AreNotEqual(Calculator.TryCalculate(testInput, out testExpect));
            }

            [TestMethod]
            public void TestInvalidInputNoSpace()
            {
                string testInput = "1+2";
                int testExpect = 0;
                Assert.AreEqual(Calculator.TryCalculate(testInput, out testExpect));
            }

            [TestMethod]
            public void TestInvalidInputNull()
            {
                string testInput = "";
                int testExpect = 0;
                Assert.AreEqual(Calculator.TryCalculate(testInput, out testExpect));
            }
    }
}
