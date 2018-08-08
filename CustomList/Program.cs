using System;
using System.Collections.Generic;

namespace CustomList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            NList<int> list3 = new NList<int>();
            NList<int> list1 = new NList<int>();
            NList<int> list2 = new NList<int>();

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    list1.Add(i);
                }
                if (i < 5)
                {
                    list2.Add(i);
                }
            }

            list3 = list1 - list2;
            for (int i = 0; i < list3.Count; i++)
            {
                Console.WriteLine(list3[i]);

            }
            Console.WriteLine(list3.Count);
            Console.WriteLine(list1.Count);

        }
    }
}
