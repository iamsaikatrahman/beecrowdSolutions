using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.GeeksForGeeks.ArrayProblems
{
    static class ReverseEx
    {
        //Given an array arr[], the task is to reverse the array.
        //Reversing an array means rearranging the elements such that the first element
        //becomes the last, the second element becomes second last and so on.

        /*
         Input: arr[] = {1, 4, 3, 2, 6, 5}  
         Output: {5, 6, 2, 3, 4, 1}
         Explanation: The first element 1 moves to last position, 
                      the second element 4 moves to second-last and so on.


        Input: arr[] = {4, 5, 1, 2} 
        Output: {2, 1, 5, 4}
        Explanation: The first element 4 moves to last position, 
                     the second element 5 moves to second last and so on.
       */
        public static void Run()
        {
            int[] arr = { 1, 4, 3, 2, 6, 5 };
            int n = arr.Length;

            #region NaiveApproach
            //[Naive Approach] Using a temporary array – O(n) Time and O(n) Space
            //NaiveApproach(arr, n);
            #endregion

            #region Expected Approach – 1
            //[Expected Approach – 1] Using Two Pointers – O(n) Time and O(1) Space
            //TwoPointerApproach(arr, n);
            #endregion

            #region Expected Approach – 2
            //[Expected Approach – 2] By Swapping Elements – O(n) Time and O(1) Space
            //SwappingElements(arr, n);
            #endregion

            #region Alternate Approach
            //[Alternate Approach] Using Recursion – O(n) Time and O(n) Space
            RecursionApproach(arr, n);
            #endregion

            #region Inbuilt Method
            //Using Inbuilt Methods – O(n) Time and O(1) Space
            //InbuiltApproch(arr);
            #endregion
        }

        private static void RecursionApproach(int[] arr, int n)
        {
            reverseArrayRec(arr, 0, n - 1);
            PrintResult(arr);
        }

        private static void reverseArrayRec(int[] arr, int l, int r)
        {
            if (l > r)
                return;
            int temp = arr[l];
            arr[l] = arr[r];
            arr[r] = temp;

            reverseArrayRec(arr, l + 1, r - 1);
        }

        private static void SwappingElements(int[] arr, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }
            PrintResult(arr);
        }

        private static void TwoPointerApproach(int[] arr, int n)
        {
            int left = 0; int right = n - 1;
            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
            PrintResult(arr);
        }

        private static void NaiveApproach(int[] arr, int n)
        {
            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
                temp[i] = arr[n - i - 1];

            for (int i = 0; i < n; i++)
                arr[i] = temp[i];

            PrintResult(arr);
        }

        private static void InbuiltApproch(int[] arr)
        {
            Array.Reverse(arr);
            PrintResult(arr);
        }

        private static void PrintResult(int[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
        }
    }
}
