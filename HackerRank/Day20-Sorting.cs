//Sorting
class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Write your code here
        int[] intarray = a.ToArray();
        
        var arrayLength = intarray.Length;
        int totalSortCount = 0;
        for (int i = 0; i < arrayLength - 1; i++)
        {
            for (int j = 0; j < arrayLength - 1; j++)
            {
                if (intarray[j] > intarray[j + 1])
                {
                    var tempVar = intarray[j];
                    intarray[j] = intarray[j + 1];
                    intarray[j + 1] = tempVar;
                    totalSortCount += 1;

                }
            }
        }

        Console.WriteLine($"Array is sorted in {totalSortCount} swaps.");
        Console.WriteLine($"First Element: {intarray.First()}");
        Console.WriteLine($"Last Element: {intarray.Last()}");

    }
}
