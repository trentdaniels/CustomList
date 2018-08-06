using NUnit.Framework;
using System;
using CustomList;
namespace CustomListTest
{
    [TestFixture]
    public class CustomList_Indexer_Test
    {
        [Test]
        public void IndexerIsZeroBased()
        {
            int num1 = 20;

            NList<int> nums = new NList<int>();
            nums.Add(num1);

            Assert.AreEqual(num1, nums[0]);
        }

        [Test]
        public void IndexOfDoubleDigits()
        {
            NList<int> nums = new NList<int>();
            for (int i = 0; i < 16; i++)
            {
                nums[i].Add(i + 1);
            }

            Assert.AreEqual(15, nums[14]);
        }

        [Test]
        public void NegativeIndexDoesNotExist()
        {
            NList<int> nums = new NList<int>() { 12, 14, 15, 16 };

            Assert.IsNullOrEmpty(nums[-1]);
        }

        [Test]
        public void IndexIsAnInteger()
        {
            NList<int> nums = new NList<int>() { 12, 14, 15 };


            Assert.AreEqual(1, nums.IndexOf(14));
        }

        [Test]
        public void IndexWithDoubleDigits()
        {
            NList<int> nums = new NList<int>();

            for (int i = 0; i < 51; i++)
            {
                nums.Add(i + 1);
            }

            Assert.AreEqual(49, nums[48]);
        }

    }
    
}
