using System;
using System.Collections.Generic;

namespace CustomList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            NList<string> list2 = new NList<string>() { "Aly", "Trent", "Marco", "Mike", "Paul", "Chu", "Tiara" };
            list2.Sort();
        }
    }
}
