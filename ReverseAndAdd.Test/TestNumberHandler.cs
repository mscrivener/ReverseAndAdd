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
            ulong original = 119;
            ulong expected = 911;

            //Act
            ulong actual = Logik.NumberHandler.ReverseInput(original);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AddTwoNumbers()
        {
            //Arrange
            ulong firstNumber = 2;
            ulong secondNumber = 3;
            ulong expected = 5;

            //Act
            ulong actual = Logik.NumberHandler.AddNumbers(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_IsPalindrome()
        {
            //Arrange
            ulong original = 4;
            ulong reversed = 4;
            bool expected = true;

            //Act
            bool actual = Logik.NumberHandler.IsPalindrome(original, reversed);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
