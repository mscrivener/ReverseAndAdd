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
            int original = 119;
            int expected = 911;

            //Act
            int actual = Logik.NumberHandler.ReverseInput(original);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AddTwoNumbers()
        {
            //Arrange
            int firstNumber = 2;
            int secondNumber = 3;
            int expected = 5;

            //Act
            int actual = Logik.NumberHandler.AddNumbers(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
