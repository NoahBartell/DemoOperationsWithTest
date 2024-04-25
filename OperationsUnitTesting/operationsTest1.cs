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
    }
}
