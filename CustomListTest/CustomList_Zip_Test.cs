using NUnit.Framework;
using System;
using CustomList;
namespace CustomListTest
{
    [TestFixture]
    public class CustomList_Zip_Test
    {
        [Test]
        public void ZipListsTogether()
        {
            NList<int> list3 = new NList<int>();

            NList<int> list1 = new NList<int>() { 1, 3, 5 };
            NList<int> list2 = new NList<int>() { 2, 4, 6 };
            NList<int> expected = new NList<int>() { 1, 2, 3, 4, 5, 6 };
            list3.Zip(list1, list2);

            CollectionAssert.AreEqual(expected, list3);
        }

        [Test]
        public void ListsWithDifferentCounts()
        {
            NList<int> list3 = new NList<int>();

            NList<int> list1 = new NList<int>() { 1, 5 };
            NList<int> list2 = new NList<int>() { 2, 4, 6 };
            NList<int> expected = new NList<int>() { 1, 2, 5, 4, 6 };
            list3.Zip(list1, list2);

            CollectionAssert.AreEqual(expected, list3);
        }

        [Test]
        public void EmptyFirstZippedList()
        {
            NList<int> list3 = new NList<int>();

            NList<int> list1 = new NList<int>() { };
            NList<int> list2 = new NList<int>() { 2, 4, 6 };
            NList<int> expected = new NList<int>() { 2, 4, 6 };
            list3.Zip(list1, list2);

            CollectionAssert.AreEqual(expected, list3);
        }

        [Test]
        public void EmptySecondZippedList()
        {
            NList<int> list3 = new NList<int>();

            NList<int> list1 = new NList<int>() { 1, 3, 5 };
            NList<int> list2 = new NList<int>() { };
            NList<int> expected = new NList<int>() { 1, 3, 5 };
            list3.Zip(list1, list2);

            CollectionAssert.AreEqual(expected, list3);
        }

        [Test]
        public void TwoEmptyLists()
        {
            NList<int> list3 = new NList<int>();

            NList<int> list1 = new NList<int>() { };
            NList<int> list2 = new NList<int>() { };
            NList<int> expected = new NList<int>() { };
            list3.Zip(list1, list2);

            CollectionAssert.AreEqual(expected, list3);
        }
    }
}
