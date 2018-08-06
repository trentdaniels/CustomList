using NUnit.Framework;
using System;

namespace CustomListTest
{
    [TestFixture]
    public class CustomList_Add_Test
    {
        [Test]
        public void AddItemToEmptyList()
        {
            int num = 12;
            BList<int> nums = new BList<int>();


            nums.Add(num);

            Assert.AreEqual(num, nums[0]);
        }

        [Test]
        public void AddItemToEndOfList()
        {
            int num1 = 20;
            int num2 = 30;
            BList<int> nums = new BList<int>();

            nums.Add(num1);
            nums.Add(num2);

            Assert.AreEqual(num2, nums[1]);
        }
        [Test]
        public void AddManyItemsToList()
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int num6 = 6;
            int num7 = 7;
            int num8 = 8;
            int num9 = 9;
            int num10 = 10;
            int num11 = 11;

            BList<int> nums = new BList<int>();

            nums.Add(num1);
            nums.Add(num2);
            nums.Add(num3);
            nums.Add(num4);
            nums.Add(num5);
            nums.Add(num6);
            nums.Add(num7);
            nums.Add(num8);
            nums.Add(num9);
            nums.Add(num10);
            nums.Add(num11);

            Assert.AreEqual(num11, nums[10]);
        }

    }
}
