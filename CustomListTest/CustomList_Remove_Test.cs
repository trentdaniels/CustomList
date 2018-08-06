//using NUnit.Framework;
//using System;
//using CustomList;
//namespace CustomListTest
//{
//    [TestFixture]
//    public class CustomList_Remove_Test
//    {
//        [Test]
//        public void RemoveItemFromList()
//        {
//            int item1 = 1;
//            int item2 = 2;
//            NList<int> newItems;

//            NList<int> items = new NList<int>() { item1, item2 };

//            newItems = items.Remove(item2);

//            Assert.AreNotEqual(items[1], newItems[1]);
//        }

//        [Test]
//        public void ItemIndexDecreases()
//        {
//            int item1 = 1;
//            int item2 = 2;

//            NList<int> items = new NList<int>() { item1, item2 };
//            items.Remove(item1);

//            Assert.AreEqual(0, items.IndexOf(item2));
//        }

//        [Test]
//        public void ListCountChanges()
//        {
//            int item1 = 1;
//            int item2 = 2;
//            int firstCount;
//            int secondCount;

//            NList<int> items = new NList<int>() { item1, item2 };
//            firstCount = items.Count;

//            items.Remove(item1);
//            secondCount = items.Count;

//            Assert.AreNotEqual(firstCount, secondCount);
//        }

//        [Test]
//        public void ListCountDecreases()
//        {
//            int item1 = 1;
//            int item2 = 2;
//            int firstCount;
//            int secondCount;

//            NList<int> items = new NList<int>() { item1, item2 };
//            firstCount = items.Count;

//            items.Remove(item1);
//            secondCount = items.Count;

//            Assert.Less(secondCount, firstCount);
//        }

//        [Test]
//        public void ListCountDecreasesBy1()
//        {
//            int item1 = 1;
//            int item2 = 2;
//            int firstCount;
//            int secondCount;

//            NList<int> items = new NList<int>() { item1, item2 };
//            firstCount = items.Count;

//            items.Remove(item1);
//            secondCount = items.Count;

//            Assert.AreEqual(1, secondCount);
//        }
//    }
//}
