namespace HackerRank
{
    class Solution
    {
        static int factorial(int n)
        { 
            if(n <= 1)
                return 1; 

            return n * factorial(n - 1);
        }
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int result = factorial(num);
            Console.WriteLine(result);
            
        }
    }
}