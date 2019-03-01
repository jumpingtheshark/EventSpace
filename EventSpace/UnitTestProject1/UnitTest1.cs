using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventSpace;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
    

        public class CalculatorTests
        {
            [TestMethod]
            public void Adding_4_And_3_Should_Return_7()
            {
                var calculator = new Calculator();

                int result = calculator.addNumbers(4, 7);

                Assert.AreEqual(7, result);
            }
        }

    }
}
