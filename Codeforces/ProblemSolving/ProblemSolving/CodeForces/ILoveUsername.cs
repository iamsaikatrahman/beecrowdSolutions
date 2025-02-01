using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces
{
    static class ILoveUsername
    {
        public static void Run() 
        {
            int t = Int32.Parse(Console.ReadLine());
            int[] arr = new int[t];
            arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int max = arr[0];
            int min = arr[0];
            int count = 0;
            for (int i = 0; i < t; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    count++;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    count++;
                }
            }
            Console.WriteLine($"{count}");
        }
    }
}
