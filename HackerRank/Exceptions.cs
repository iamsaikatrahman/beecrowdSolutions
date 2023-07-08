//Exceptions - String to Integer

using System;
class Solution
{
    public static void Main(string[] args)
    {
        try
        {
            string S = Console.ReadLine();
            int convertString = Convert.ToInt32(S);
            Console.WriteLine(convertString);
        }
        catch (Exception)
        {
            Console.WriteLine("Bad String");
        }
    }
}
