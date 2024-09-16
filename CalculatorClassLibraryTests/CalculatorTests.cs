using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary.Tests
{
    [TestClass()]
    
    public class CalculatorTests
    {
        [TestMethod()]
        [DataRow('+', 1, 2)]
        [DataRow('+', 1, 3)]
        [DataRow('+', 1, 4)]
        //Plus
        public void CalculatorTestPlus(char operation, int x, int y)
        {
            //Arrange
            Calculator c = new Calculator();
            //Act
            double actual =  c.Calculate(operation, x, y);
            //Assert
            Assert.AreEqual(x + y, actual);
        }

        [TestMethod()]
        //Minus
        [DataRow('-', 2, 1)]
        [DataRow('-', 4, 1)]
        [DataRow('-', 5, 1)]
        public void CalculateTestMinus(char operation, int x, int y)
        {
            //Arrange
            Calculator c = new Calculator();
            //Act
            double actual = c.Calculate(operation, x, y);
            //Assert
            Assert.AreEqual(x - y, actual);
        }

        [TestMethod()]
        [DataRow('*', 1, 2)]
        [DataRow('*', 1, 3)]
        [DataRow('*', 1, 4)]
        //Multiply
        public void CalculateMultiply(char operation, int x, int y)
        {
            //Arrange
            Calculator c = new Calculator();
            //Act
            double actual = c.Calculate(operation, x, y);
            //Assert
            Assert.AreEqual(x * y, actual);
        }

        [TestMethod()]
        [DataRow('/', 1, 2)]
        [DataRow('/', 1, 3)]
        [DataRow('/', 1, 4)]
        //Divide
        public void CalculateDivide(char operation, int x, int y)
        {
            //Arrange
            Calculator c = new Calculator();
            //Act
            double actual = c.Calculate(operation, x, y);
            //Assert
            Assert.AreEqual(x / y, actual);
        }
    }
}