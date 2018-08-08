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
                list1.Add(i);
                list2.Add(i);
            }
            list3 = list1 + list2;
            Console.WriteLine(list3.Count);


        }
    }
}
