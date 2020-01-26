using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace square_every_digit
{
    [TestClass]
    public class TestFixture
    {
        [TestMethod]
        public void SquareDigitsTest()
        {
            Assert.AreEqual(811181, Kata.SquareDigits(9119));
        }
    }
}
