using NUnit.Framework;
using System;
namespace CustomListTest
{
    [TestFixture]
    public class CustomList_Iteration_Test
    {
        [Test]
        public void Iteration()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            NList<int> nums = new NList<int>();
            nums.Add(num1);
            nums.Add(num2);
            nums.Add(num3);

            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] += 5;
            }

            Assert.AreEqual(25, nums[1]);

        }
    }
}
