using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.CodeForces
{
    static class CalculatingFunction_486_A
    {
        public static void Run() 
        {
            long n = long.Parse(Console.ReadLine());
            long result = (n % 2) == 0 ? (n / 2) : -(n + 1) / 2;
            Console.WriteLine(result);
        }
    }
}