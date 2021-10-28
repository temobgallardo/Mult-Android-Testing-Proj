using App1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new ForTestingClass();
            var name = "Anybody";
            var result = c.CheerName(name);
            Assert.IsNotNull(result);
        }
    }
}
