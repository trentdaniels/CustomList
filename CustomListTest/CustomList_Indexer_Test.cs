﻿using NUnit.Framework;
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
                nums.Add(i + 1);
            }

            Assert.AreEqual(15, nums[14]);
        }

        [Test]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NegativeIndexDoesNotExist()
        {
            NList<int> nums = new NList<int>() { 12, 14, 15, 16 };

            nums[-1] = 15;
        }

        [Test]
        public void IndexIsAnInteger()
        {
            NList<int> nums = new NList<int>() { 12, 14, 15 };


            Assert.AreEqual(14, nums[1]);
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

        [Test]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexIsNegative()
        {
            NList<int> nums = new NList<int>() { };
            for (int i = -15; i < 0; i++)
            {
                nums[i] = 16;
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexAboveCount()
        {
            NList<int> nums = new NList<int>() { 1, 2, 3 };
            nums[6] = 9;
        }

    }
    
}
