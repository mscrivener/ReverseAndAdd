using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseAndAdd.Test
{
    [TestClass]
    public class TestNumberHandler
    {
        [TestMethod]
        public void Test_ReverseNumber()
        {
            //Arrange
            long original = 119;
            long expected = 911;

            //Act
            long actual = Logik.NumberHandler.ReverseInput(original);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AddTwoNumbers()
        {
            //Arrange
            long firstNumber = 2;
            long secondNumber = 3;
            long expected = 5;

            //Act
            long actual = Logik.NumberHandler.AddNumbers(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
