using NUnit.Framework;
using System;
using CustomList;

namespace CustomListTest
{
    [TestFixture]
    public class CustomList_Iteration_Test
    {
        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ChangesValueAtIndex()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            NList<int> nums = new NList<int>();
            nums.Add(num1);
            nums.Add(num2);
            nums.Add(num3);

            for (int i = 0; i < 50; i++)
            {
                nums[i] += 5;
            }

            Assert.AreEqual(25, nums[1]);

        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetsIndexAfterIteration()
        {
            NList<int> nums = new NList<int>();

            for (int i = 0; i < 3; i++)
            {
                nums[i] = i;
                nums.Add(nums[i]);
            }

            Assert.AreEqual(1, nums[3]);
        }

        [Test]
        public void CountAfterIteration()
        {
            NList<int> nums = new NList<int>();

            for (int i = 0; i < 6; i++)
            {
                nums.Add(i);
            }

            Assert.AreEqual(6, nums.Count);
        }

        [Test]
        public void RemoveFromList()
        {
            NList<int> nums = new NList<int>() { 15, 14, 13, 1, 2, 3 };

            for (int i = 0; i < 3; i++)
            {
                foreach(int num in nums)
                {
                    if (nums[i] == num)
                    {
                        nums.Remove(i);
                    }
                }

            }

            Assert.AreEqual(4, nums.Count);
        }

        [Test]
        public void ForEachLoop()
        {
            NList<NList<int>> bigList = new NList<NList<int>>() { };
            for (int i = 0; i < 10; i++)
            {
                bigList.Add(new NList<int>());
            }

            foreach (NList<int>list in bigList)
            {
                list.Add(1);
            }

            Assert.AreEqual(1, bigList[5][0]);
        }



                           
    }
}
