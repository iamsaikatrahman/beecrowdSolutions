using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Beecrowd
{
    //Arrays
    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int[] rev = Enumerable.Reverse(arr.Take(n)).ToArray();
            Console.WriteLine(string.Join(" ", rev));

        }
    }
}