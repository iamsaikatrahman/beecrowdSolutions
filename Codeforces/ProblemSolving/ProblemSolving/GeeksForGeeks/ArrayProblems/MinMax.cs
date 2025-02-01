

namespace ProblemSolving.GeeksForGeeks.ArrayProblems;

static class MinMax
{
    //Maximum and minimum of an array using minimum number of comparisons
    //Given an array of size N. The task is to find the maximum and the minimum
    //element of the array using the minimum number of comparisons.

    //Input: arr[] = {3, 5, 4, 1, 9}
    //Output: Minimum element is: 1
    //          Maximum element is: 9

    //Input: arr[] = {22, 14, 8, 17, 35, 3}
    //Output:  Minimum element is: 3
    //          Maximum element is: 35

    public static void Run() 
    {
        int[] A = { 4, 9, 6, 5, 2, 3 };
        Console.WriteLine("Minimum element is: " + setmini(A, A.Length));
        Console.WriteLine("Maximum element is: " + setmaxi(A, A.Length));
    }

    private static int setmaxi(int[] a, int n)
    {
        int maxi = a[0];
        for (int i = 0; i < n; i++) 
        {
            if (a[i] > maxi) 
            {
                maxi = a[i];
            }
        }
        return maxi;
    }

    private static int setmini(int[] a, int n)
    {
        int mini = a[0];
        for (int i = 0; i < n; i++) 
        {
            if (a[i] < mini) 
            {
                mini = a[i];
            }
        }
        return mini;
    }
}
