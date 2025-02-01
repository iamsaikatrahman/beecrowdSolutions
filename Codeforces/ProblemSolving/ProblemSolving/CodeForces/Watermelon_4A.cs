using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces
{
    static class Watermelon_4A
    {
        public static void Run() 
        {
            int a = int.Parse(Console.ReadLine());
            string output = (a % 2 == 0) ? "YES" : "NO";
            Console.WriteLine(output);
        }
    }
}
