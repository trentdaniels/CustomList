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
            array = new T[count];
        }
        // Methods
        public void Add(T item)
        {
            Console.WriteLine("Adding Item");

            count = GetCount();

            array[count] = item;
            count++;
        }

        private int GetCount()
        {
            count = 0;
            foreach(T item in array)
            {
                count++;
            }
            return count;
        }


    }
}
