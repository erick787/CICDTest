using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("This test checks whether a number is even or not")]
        public void IsAnEvenNumber()
        {
            int number = 2;
            number += 5;
            Assert.IsTrue(number % 2 == 0);
        }
    }
}
