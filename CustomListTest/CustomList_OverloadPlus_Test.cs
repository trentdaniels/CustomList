using NUnit.Framework;
using System;
using CustomList;
using System.Collections.Generic;

namespace CustomListTest
{
    [TestFixture]
    public class CustomList_OverloadPlus_Test
    {
        [Test]
        public void AddsTwoNLists()
        {
            NList<int> list3 = new NList<int>();
            NList<int> list1 = new NList<int>();
            NList<int> list2 = new NList<int>();

            for (int i = 0; i < 10; i++)
            {
                list1.Add(i);
                list2.Add(i);
            }
            list3 = list1 + list2;

            Assert.AreEqual(20, list3.Count);
        }

        [Test]
        public void SecondListAppendedToEnd()
        {
            NList<int> list3 = new NList<int>();

            NList<int> list1 = new NList<int>();
            NList<int> list2 = new NList<int>();
            for (int i = 0; i < 3; i++)
            {
                list1.Add(i);
            }
            list2.Add(3);
            list3 = list1 + list2;

            Assert.AreEqual(3, list3[3]);
        }

        [Test]
        public void CountContinuesUpdate()
        {
            NList<List<int>> totalList = new NList<List<int>>();

            for (int i = 0; i < 50; i++)
            {
                totalList.Add(new List<int>());
            }

            Assert.AreEqual(50, totalList.Count);
        }

        [Test]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void EveryListGetsAppendedToEnd()
        {
            NList<NList<int>> totalList = new NList<NList<int>>();

            for (int i = 0; i < 50; i++)
            {
                totalList[i] = new NList<int>() + new NList<int>();
            }

            Assert.Equals(2, totalList[49].Count);
        }

        [Test]
        public void AddEmptyList()
        {
            NList<int> list3 = new NList<int>();

            NList<int> list1 = new NList<int>();
            NList<int> list2 = new NList<int>();
            list1.Add(2);
            list3 = list1 + list2;

            Assert.AreEqual(1, list3.Count);
        }

        [Test]
        public void AddTwoEmptyLists()
        {
            NList<int> list3 = new NList<int>();

            NList<int> list1 = new NList<int>() { };
            NList<int> list2 = new NList<int>() { };

            list3 = list1 + list2;

            Assert.AreEqual(0, list3.Count);
        }

    }
}
