//using NUnit.Framework;
//using System;
//using CustomList;
//namespace CustomListTest
//{
//    [TestFixture]
//    public class CustomList_OverloadPlus_Test
//    {
//        [Test]
//        public void AddsTwoNLists()
//        {
//            NList<int> list3 = new NList<int>();

//            NList<int> list1 = new NList<int>() { 1, 2, 3 };
//            NList<int> list2 = new NList<int>() { 4, 5, 6 };

//            list3 = list1 + list2;

//            Assert.AreEqual(6, list3.Count);
//        }

//        [Test]
//        public void SecondListAppendedToEnd()
//        {
//            NList<int> list3 = new NList<int>();

//            NList<int> list1 = new NList<int>() { 1, 2, 3 };
//            NList<int> list2 = new NList<int>() { 4, 5, 6 };

//            list3 = list1 + list2;

//            Assert.AreEqual(3, list3.IndexOf(4));
//        }

//        [Test]
//        public void CountContinuesUpdate()
//        {
//            NList<int> totalList = new NList<int>(){};

//            for (int i = 0; i < 50; i++)
//            {
//                totalList += new NList<int>() { i };
//            }

//            Assert.AreEqual(50, totalList.Count);
//        }

//        [Test]
//        public void EveryListGetsAppendedToEnd()
//        {
//            NList<int> totalList = new NList<int>() { };

//            for (int i = 0; i < 50; i++)
//            {
//                totalList += new NList<int>() { i };
//            }

//            Assert.IsTrue(totalList[49] == 49);
//        }

//        [Test]
//        public void AddEmptyList()
//        {
//            NList<int> list3 = new NList<int>();

//            NList<int> list1 = new NList<int>() { 3 };
//            NList<int> list2 = new NList<int>() { };

//            list3 = list1 + list2;

//            Assert.AreEqual(1, list3.Count);
//        }

//        [Test]
//        public void AddTwoEmptyLists()
//        {
//            NList<int> list3 = new NList<int>();

//            NList<int> list1 = new NList<int>() { };
//            NList<int> list2 = new NList<int>() { };

//            list3 = list1 + list2;

//            Assert.AreEqual(0, list3.Count);
//        }
//        [Test]
//        [ExpectedException(typeof(ArrayTypeMismatchException))]
//        public void AddDifferentTypeLists()
//        {
//            NList<string> list3 = new NList<string>();

//            NList<string> list1 = new NList<string>() { "trent", "daniels", "false" };
//            NList<int> list2 = new NList<int>() { 2 };

//            list3 = list1 + list2;
//        }

//    }
//}
