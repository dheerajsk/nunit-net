using CCalculator;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator Calculator;

        static List<TestCaseData> TestCases
        {
            get
            {
                return AddTestData.Get();
            }
        }

        [SetUp]
        public void Setup()
        {
            FakeOffset fake = new FakeOffset();
            Calculator = new Calculator(fake);
        }

        [Test]
        public void AddWithOffset_Test()
        {
            // Arrange
            int num1 = 20, num2 = 40;
            int expectedResult = 160;

            // Act
            int result = Calculator.AddWithOffset(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCaseSource("TestCases")]
        public int DDAdd_Test(int x, int y)
        {
            // Act
            return Calculator.Add(x, y);
        }

        [Test]
        public void Add_Test()
        {
            // Arrange
            int num1 = 20, num2 = 40;
            int expectedResult = 60;

            // Act
            int result = Calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Sub_Test()
        {
            // Arrange
            int num1 = 200, num2 = 40;
            int expectedResult = 160;

            // Act
            int result = Calculator.Sub(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Mul_Test()
        {
            // Arrange
            int num1 = 20, num2 = 40;
            int expectedResult = 800;

            // Act
            int result = Calculator.Mul(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Div_Test()
        {
            // Arrange
            int num1 = 200, num2 = 40;
            int expectedResult = 5;

            // Act
            int result = Calculator.Div(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void DivideByZero_Test()
        {
            // Arrange
            int num1 = 0, num2 = 0;

            // Act //Assert
            Assert.Throws<DivideByZeroException>(() => Calculator.Div(num1, num2));

        }
    }
}
