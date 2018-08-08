using NUnit.Framework;
using System;
using CustomList;

namespace CustomListTest
{
    [TestFixture]
    public class CustomList_Add_Test
    {
        [Test]
        public void AddItemToEmptyList()
        {
            int num = 12;
            NList<int> nums = new NList<int>();


            nums.Add(num);

            Assert.AreEqual(num, nums[0]);
        }

        [Test]
        public void AddItemToEndOfList()
        {
            int num1 = 20;
            int num2 = 30;
            NList<int> nums = new NList<int>();

            nums.Add(num1);
            nums.Add(num2);

            Assert.AreEqual(num2, nums[1]);
        }
        [Test]
        public void AddMoreThan10Items()
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

            NList<int> nums = new NList<int>();

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

        [Test]
        public void AddMoreThan50Items()
        {
            NList<int> nums = new NList<int>();

            for (int i = 0; i <= 55; i++)
            {
                nums.Add(i);
            }

            Assert.AreEqual(55, nums[55]);


        }

        [Test]
        public void Index0AfterAddMoreThan50Items()
        {
            NList<int> nums = new NList<int>();

            for (int i = 0; i <= 55; i++)
            {
                nums.Add(i);
            }

            Assert.AreEqual(0, nums[0]);


        }


        //[Test]
        //public void AddWithEnumerator()
        //{
        //    NList<int> nums = new NList<int>() { 1, 2, 3 };
        //    nums.Add(4);

        //    Assert.AreEqual(4, nums[3]);
        //}

    }
}
