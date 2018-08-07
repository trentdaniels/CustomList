using System;

namespace CustomList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            NList<int> nums = new NList<int>();

            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.Remove(3);
            Console.WriteLine(nums[1]);
            Console.WriteLine(nums[2]);
            Console.WriteLine(nums[1]);
            Console.ReadLine();

        }
    }
}
