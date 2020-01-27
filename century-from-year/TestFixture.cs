using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace century_from_year
{
    [TestClass]
    public class TestFixture
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(18, Kata.СenturyFromYear(1705));
            Assert.AreEqual(19, Kata.СenturyFromYear(1900));
            Assert.AreEqual(17, Kata.СenturyFromYear(1601));
            Assert.AreEqual(20, Kata.СenturyFromYear(2000));
        }
    }
}
