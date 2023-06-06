using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _40_Greatest_Array_Pair
    {
        static int FindLargestSumPair(int[] arr, int n)
        {
            int maxSum = int.MinValue;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++) 
                {
                    int sum = arr[i] + arr[j];
                    if (sum > maxSum)
                    {

                        maxSum = sum; 
                    }
                }
            }
            return maxSum;
        }

        // Driver code
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr =new int[n];
            for(int j= 0; j < arr.Length; j++)
            {
                arr[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Max Pair Sum is " + FindLargestSumPair(arr, n));
        }
    }
}
