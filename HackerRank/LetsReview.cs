using System;
using System.Collections.Generic;
using System.IO;

namespace Beecrowd
{
    //Let's Review
    class Solution
    {
        string evenChars = "";
        string oddChars = "";
        public Solution(string str) 
        {
            int N = str.Length;
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    evenChars += str[i];
                }
                else
                { 
                    oddChars += str[i];
                }
                
            }
            Console.Write(evenChars + " " + oddChars);
        }
        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string chars = Console.In.ReadLine();
                Solution sln = new Solution(chars);
                Console.WriteLine();
            }  
        }
    }
}