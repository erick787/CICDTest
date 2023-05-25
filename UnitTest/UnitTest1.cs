using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("Checks the functionality of the divide function")]
        public void TestMethod()
        {
            var service = new MathService();
            var result = service.divide(10, 3);
            Assert.AreEqual(5, result, "Result is not 5");
        }

        [TestMethod, TestCategory("Checks the functionality of the divide function when parameters are negative numbers")]
        public void TestMethodValueA()
        {
            var service = new MathService();
            var result = service.divide(-5, 5);
            Assert.AreEqual(0, result, "Result is not zero when parameters are negative");
        }
    }
}
