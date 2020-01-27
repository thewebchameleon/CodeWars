using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace remove_all_marked_elements_of_list
{
    [TestClass]
    public class TestFixture
    {
        [TestMethod]
        public void Test1()
        {
            int[] integerList = new int[] { 1, 1, 2, 3, 1, 2, 3, 4 };
            int[] valuesList = new int[] { 1, 3 };
            int[] expectedList = new int[] { 2, 2, 4 };
            Assert.IsTrue(Kata.Remove(integerList, valuesList).SequenceEqual(expectedList));
        }

        [TestMethod]
        public void Test2()
        {
            int[] integerList = new int[] { 1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8 };
            int[] valuesList = new int[] { 1, 3, 4, 2 };
            int[] expectedList = new int[] { 5, 6, 7, 8 };
            Assert.IsTrue(Kata.Remove(integerList, valuesList).SequenceEqual(expectedList));
        }

        [TestMethod]
        public void Test3()
        {
            int[] integerList = new int[] { 8, 2, 7, 2, 3, 4, 6, 5, 4, 4, 1, 2, 3 };
            int[] valuesList = new int[] { 2, 4, 3 };
            int[] expectedList = new int[] { 8, 7, 6, 5, 1 };
            Assert.IsTrue(Kata.Remove(integerList, valuesList).SequenceEqual(expectedList));
        }


    }
}
