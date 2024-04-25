using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OperationsUnitTesting
{
    [TestClass]
    public class operationsTest1
    {
        [TestMethod]
        public void DivideTest()
        {
            //Arrange
            int expected = 4;
            int numerator = 20;
            int denominator = 5;

            //Act
            int actual = OperationsLibrary.operations.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            //Arrange
            int expected = 30;
            int numA = 10;
            int numB = 3;

            //Act          
            int actual = OperationsLibrary.operations.Multiply(numA, numB);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTest()
        {
            //Arrange
            int expected = 13;
            int numA = 10;
            int numB = 3;

            //Act          
            int actual = OperationsLibrary.operations.Add(numA, numB);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractTest()
        {
            //Arrange
            int expected = 7;
            int numA = 10;
            int numB = 3;

            //Act          
            int actual = OperationsLibrary.operations.Subtract(numA, numB);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemainderTest()
        {
            //Arrange
            int expected = 1;
            int numA = 13;
            int numB = 2;

            //Act          
            int actual = OperationsLibrary.operations.Remainder(numA, numB);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
