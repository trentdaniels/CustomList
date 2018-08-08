using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomList
{
    public class NList<T> : IEnumerable
    {
        // Members
        private int count;
        private T[] storedValues;
        private int capacity;
        private int capacityIncreaser;

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    ArgumentException argument = new ArgumentOutOfRangeException();
                    throw argument;
                }
                return storedValues[index];
            }
            set 
            {
                if (index >= count)
                {
                    ArgumentException argument = new ArgumentOutOfRangeException();
                    throw argument;
                }
                storedValues[index] = value;
            }
        }

        public int Count { get => count; }


        // Constructor
        public NList()
        {
            count = 0;
            capacity = 1;
            storedValues = new T[capacity];
            capacityIncreaser = 0;

        }

        public static NList<T> operator + (NList<T> list1, NList<T> list2)
        {
            NList<T> newList = new NList<T>();

            for (int i = 0; i < list1.count; i++)
            {
                newList.Add(list1[i]);
            }
            for(int i = 0; i < list2.count; i++)
            {
                newList.Add(list2[i]);
            }
            return newList;

        }
        public static NList<T> operator - (NList<T>list1, NList<T> list2)
        {
            NList<T> newList = new NList<T>();

            for (int i = 0; i < list1.count; i++)
            {
                newList.Add(list1[i]);
            }
      
            for (int i = 0; i < list1.count; i++)
            {
                for (int j = 0; j < list2.count; j++)
                {
                    if (list1[i].Equals(list2[j]))
                    {
                        newList.Remove(list2[j]);

                    }
                }
               
            }

            return newList;
        }


        // Methods
        public void Add(T item)
        {
            count = UpdateCount();

            storedValues[count - 1] = item;

            if (CountReachedCapacity())
            {
                capacity *= (2 + (2 * capacityIncreaser));
                capacityIncreaser++;
            }
            storedValues = StoreNewValues();

        }

        private T[] StoreNewValues()
        {
            T[] newStoredArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                newStoredArray[i] = storedValues[i];
            }

            return newStoredArray;
        }

      
        public bool Remove(T item)
        {
            bool didRemoveItem = false;
            int skipCounter = 0;
            T[] newStoredArray = new T[capacity];

            for (int i = 0; i < count; i++)
            {
                T currentValue = storedValues[i];
                if(Equals(currentValue, item))
                {
                    skipCounter++;
                    didRemoveItem = true;
                }
                storedValues[i] = storedValues[i + skipCounter];

            }
            count = UpdateCountDown();
            return didRemoveItem;
        }

        private int UpdateCount()
        {
            int counter = 0;
            for (int i = 0; i <= count; i++)
            {
                counter++;
            }
            return counter;
        }
        private int UpdateCountDown()
        {
            int counter = 0;
            if (count == 0)
            {
                return counter;
            }


            foreach(T item in storedValues)
            {
                if (EqualityComparer<T>.Default.Equals(item, default(T)))
                {
                    continue;
                }
                counter++;
            }
            return counter;
        }

        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < count; i++)
            {
                newString += $"{storedValues[i]}";
            }
            return newString;
        }

        public string ToString(string separator)
        {
            string newString = "";
            for (int i = 0; i < count; i++)
            {
                
                newString += i == count - 1 ? $"{storedValues[i]}" : $"{storedValues[i]}{separator}";
               
            }
            return newString;
        }

        public void Zip (NList<T>list1, NList<T>list2)
        {
            int listWithGreaterCount = list1.count > list2.count ? list1.count : list2.count;


            for (int i = 0; i < listWithGreaterCount; i++)
            {
                if (i < list1.count && i < list2.count)
                {
                    Add(list1[i]);
                    Add(list2[i]);
                }
                else if (i >= list1.count && i >= list2.count)
                {
                    break;
                }
                else if (i >= list1.count)
                {
                    Add(list2[i]);
                }
                else if (i >= list2.count)
                {
                    Add(list1[i]);
                }
                else
                {
                    break;
                }
            }

        }

       

        private bool CountReachedCapacity()
        {
            return count == capacity;
        }




        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return storedValues[i];
            }
        }



    }


}
