using System;
namespace CustomList
{
    public class NList<T>
    {
        // Members
        private int count;
        private T value;
        private T[] array;

        public int Count { get => count; }

        // Constructor
        public NList()
        {
            count = GetCount();
        }
        // Methods
        public void Add(T item)
        {
            array = new T[count];
            array[count] = item;
            count++;
        }

        public int GetCount()
        {
            count = 0;
            foreach(T item in array)
            {
                count++;
            }
            return count;
        }

        public T this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }
    }
}
