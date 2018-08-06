﻿using NUnit.Framework;
using System;
namespace CustomListTest
{
    [TestFixture]
    public class CustomList_Count_Test
    {
        [Test]
        public void GetsCount()
        {
            int num1 = 12;

            CustomList<int> nums = new CustomList<int>();
            nums.Add(num1);

            Assert.AreEqual(1, nums.Count);
            
        }

        [Test]
        public void UpdatesCount()
        {
            int num1 = 12;
            int num2 = 20;
            int firstCount;
            int secondCount;

            CustomList<int> nums = new CustomList<int>();
            nums.Add(num1);
            firstCount = nums.Count;

            nums.Add(num2);
            secondCount = nums.Count;

            Assert.AreNotEqual(firstCount, secondCount);

        }

        [Test]
        public void CountIncreases()
        {
            int num1 = 12;
            int num2 = 20;
            int firstCount;
            int secondCount;

            CustomList<int> nums = new CustomList<int>();
            nums.Add(num1);
            firstCount = nums.Count;

            nums.Add(num2);
            secondCount = nums.Count;

            Assert.Greater(secondCount, firstCount);

        }

        [Test]
        public void CountIncreasesBy1()
        {
            int num1 = 20;
            int num2 = 24;
            int firstCount;
            int secondCount;

            CustomList<int> nums = new CustomList<int>();
            nums.Add(num1);
            firstCount = nums.Count;

            nums.Add(num2);
            secondCount = nums.Count;

            Assert.AreEqual(2, secondCount);
        }

        [Test]
        public void CountIsReadOnly()
        {
            CustomList<int> nums = new CustomList<int>();

            Assert.IsFalse(nums.GetProperty("Count").CanWrite);
        }
    }
}
