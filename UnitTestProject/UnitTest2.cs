using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            AddToRandom oRandom = new AddToRandom();

            // act
            int result = oRandom.add5toRandom();

            // assert
            Assert.AreEqual(15, result);


        }
        [TestClass]
        class MockRandomClass : IRandomGenerator
        {
            public int generateNumber()
            {
                return 7;
            }
        };

        [TestMethod]
        public void ModifiedRandomMethodTest()
        {
            //arrange
            IRandomGenerator oMockRandom = new MockRandomClass();
            AddToRandomTest oRandom = new AddToRandomTest(oMockRandom);


            // act
            int result = oRandom.add5toRandom();

            // assert
            Assert.AreEqual(result, 12);


        }
    }

    
}



     
    

