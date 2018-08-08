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
            // loop through list1 and add values into list3 before remove function
        }
    }
}
