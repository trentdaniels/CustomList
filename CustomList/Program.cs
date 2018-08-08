using System;
using System.Collections.Generic;

namespace CustomList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            NList<string> nums = new NList<string>() { "Trent", "Marco", "Aly" };
            string numsToString = nums.ToString();
            string numsToStringWithSeparator = nums.ToString(", ");
            Console.WriteLine(numsToString);
            Console.WriteLine(numsToStringWithSeparator);

            NList<int> nums1 = new NList<int>();

            string num1ToString = nums1.ToString("");

            Console.WriteLine(num1ToString);
            // loop through list1 and add values into list3 before remove function


            NList<int> list1 = new NList<int>() { 1 };
            NList<int> list2 = new NList<int>() {  };
            NList<int> list3 = new NList<int>() { 10, 11, 12, 13 };

            list3.Zip(list1, list2);
            for (int i = 0; i < list3.Count; i++)
            {
                Console.WriteLine(list3[i]);
            }


        }
    }
}
