using NUnit.Framework;
using System;
using CustomList;
namespace CustomListTest
{
    [TestFixture]
    public class CustomList_ToString_Test
    {
        [Test]
        public void ConvertsToString()
        {
            NList<int> nums = new NList<int>(){ 1, 2, 3 };

            Assert.IsTrue(nums.ToString() == typeof(string));
        }

        [Test]
        public void DefaultArgumentCreatesSeparator()
        {
            NList<int> nums = new NList<int>() { 1, 2, 3 };

            Assert.AreEqual(nums.ToString(), "123");
        }

        [Test]
        public void ArgumentCreatesSeparator()
        {
            NList<int> nums = new NList<int>() { 1, 2, 3 };

            Assert.AreEqual(nums.ToString(", "), "1, 2, 3");
        }

    }
}
