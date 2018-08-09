using System;
using System.Collections.Generic;

namespace CustomList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            NList<int> nums = new NList<int>() { 20, 40, 15, 2, 45, 67, 80 };
            NList<int> sortedNums = new NList<int>();


            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
