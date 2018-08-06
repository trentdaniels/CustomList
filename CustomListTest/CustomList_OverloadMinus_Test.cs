using NUnit.Framework;
using System;
using CustomList;
namespace CustomListTest
{
    [TestFixture]
    public class CustomList_OverloadMinus_Test
    {
        [Test]
        public void SubtractsFromFirstList()
        {
            NList<int> list3 = new NList<int>();
            NList<int> expected;

            NList<int> list1 = new NList<int>() { 10, 9, 9 };
            NList<int> list2 = new NList<int>() { 1, 9, 9 };

            list3 = list1 - list2;
            expected = new NList<int>() { 10 };

            CollectionAssert.AreEqual(expected, list3);
        }

        [Test]
        public void EmptyFirstList()
        {
            NList<int> list3 = new NList<int>();

            NList<int> list1 = new NList<int>() {  };
            NList<int> list2 = new NList<int>() { 1, 9, 9 };

            list3 = list1 - list2;

            CollectionAssert.AreEqual(list1, list3);
        }

        [Test]
        public void EmptySecondList()
        {
            NList<int> list3 = new NList<int>();

            NList<int> list1 = new NList<int>() { 1, 9, 9 };
            NList<int> list2 = new NList<int>() {  };

            list3 = list1 - list2;

            CollectionAssert.AreEqual(list1, list3);
        }

        [Test]
        public void SubtractListFromItself()
        {
            NList<int> list3 = new NList<int>();

            NList<int> list1 = new NList<int>() { 1, 9, 9 };

            list3 = list1 - list1;
            NList<int> expected = new NList<int>() { };


            CollectionAssert.AreEqual(expected, list3);
        }

        [Test]
        public void ListOfStrings()
        {
            NList<string> list3 = new NLis<string>t();
            NList<string> expected;

            NList<string> list1 = new NList<string>() { "trent", "daniels","false" };
            NList<string> list2 = new NList<string>() { "trent" };

            expected = new NList<string>() { "daniels", "false" };
            list3 = list1 - list2;

            CollectionAssert.AreEqual(expected, list3);
        }

        [Test]
        [ExpectedException(typeof(ArrayTypeMismatchException))]
        public void SubtractDifferentTypeLists()
        {
            NList<string> list3 = new NList<string>();

            NList<string> list1 = new NList<string>() { "trent", "daniels", "false" };
            NList<int> list2 = new NList<int>() { 2 };

            list3 = list1 - list2;
        }

        [Test]
        public void SubtractMultipleLists()
        {
            NList<int> list4 = new NList<int>();
            NList<int> expected = new NList<int>();
            NList<int> list1 = new NList<int>() { 1, 2, 3 };
            NList<int> list2 = new NList<int>() { 2, 3 };
            NList<int> list3 = new NList<int>() { 2 };

            list4 = list1 - list2 - list3;
            expected = new NList<int>() { 1, 2 };

            CollectionAssert.AreEqual(expected, list4);
        }
    }
}
