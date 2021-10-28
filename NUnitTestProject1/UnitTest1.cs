using App1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var c = new ForTestingClass();
            var name = "Anybody";
            var result = c.CheerName(name);
            Assert.IsNotNull(result);
        }
    }
}