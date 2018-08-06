using System;
namespace CustomList
{
    public class NList<T>
    {
        // Members
        private int count;
        private T[] array;

        public T this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public int Count { get => count; }

        // Constructor
        public NList()
        {
            count = 0;
        }
        // Methods
        public void Add(T item)
        {
            count = GetCount();
            array = new T[Count];
            array[Count - 1] = item;
        }

        private int GetCount()
        {
            int counter = 0;
            for (int i = 0; i <= count; i++)
            {
                counter++;
            }
            return counter;
        }
        private void IncreaseCount()
        {
            count++;
        }



    }
}
