using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            // Arrange
            int x = 10; int y = 6;
            MathOpeartion oMathOPeration = new MathOpeartion();

            // Act
            int result= oMathOPeration.Add(x, y);

            // Assert
            Assert.AreEqual(result, 16);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            // Arrange
            int x = 10; int y = 6;
            MathOpeartion oMathOPeration = new MathOpeartion();

            // Act
            int result = oMathOPeration.Substract(x, y);

            // Assert
            Assert.AreEqual(result, 4);

        }

    }
}
