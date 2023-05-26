namespace HackerRank
{
    class Solution
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int maxConsecutiveOnes = GetMaxConsecutiveOnes(num);
            Console.WriteLine(maxConsecutiveOnes);
        }
        static int GetMaxConsecutiveOnes(int n)
        {
            int maxCount = 0;
            int currentCount = 0;
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else 
                {
                    currentCount = 0;
                }
                n  /= 2;
            }
            return maxCount;
        }
    }
}