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
            int actual = ReverseAndAdd.Logik.NumberHandler.ReverseInput(original);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
