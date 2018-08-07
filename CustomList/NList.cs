using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomList
{
    public class NList<T>
    {
        // Members
        private int count;
        private T[] storedValues;
        private int capacity;

        public T this[int index]
        {
            get => storedValues[index];
            set => storedValues[index] = value;
        }

        public int Count { get => count; }


        // Constructor
        public NList()
        {
            count = 0;
            capacity = 1;
            storedValues = new T[capacity];
        }


        // Methods
        public void Add(T item)
        {
            count = UpdateCount();

            storedValues[count - 1] = item;

            if (CountReachedCapacity())
            {
                capacity *= 2;
            }
            storedValues = StoreNewValues();

        }

        public bool Remove(T item)
        {
            bool didRemoveItem = false;
            int skipCounter = 0;

            for (int i = 0; i < count; i++)
            {
                if(storedValues[i].Equals(item))
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
        private T[] StoreNewValues()
        {
            T[] newStoredArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                newStoredArray[i] = storedValues[i];
            }

            return newStoredArray;
        }

        private T[] StoreNewValuesAfterRemoval(T item)
        {
            T[] newStoredArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                if (storedValues[i].Equals(item))
                {
                    continue;
                }
                newStoredArray[i] = storedValues[i];
            }

            return newStoredArray;
        }

        private bool CountReachedCapacity()
        {
            return count == capacity;
        }
        //public void Remove(T item)
        //{
        //    for (int i = 0; i <= count; i++)
        //    {
        //        bool matchedItem = array[i] == item;
                
        //        if (array[i] == item)
        //        {
                    
        //        }
        //    }

        //}



    }
}
