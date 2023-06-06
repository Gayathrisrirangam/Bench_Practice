using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_basic_programs
{
    class Sum_of_Array
    {
        //static void Main()
        //{
        //    int[] nums = { 11, 20, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    int minsum = FindSmallestSum(nums);
        //    Console.WriteLine("The smallest sum of Consecutive numbers is :" + minsum);
        //}


        //static int FindSmallestSum(int[] nums)
        //{
        //    int minsum = int.MaxValue;
        //    for(int i = 0; i< nums.Length;i++)
        //    {
        //        int sum = 0;
        //        for(int j = i; j < nums.Length; j++)
        //        {
        //            sum += nums[j];
        //            if(sum < minsum)
        //            {
        //                minsum = sum;
        //            }
        //        }
        //    }
        //    return minsum;
        //}
        static void Main()
        {
            int[] arr = new int[5];
            int i;
            int[] j = new int[4];
            Console.WriteLine("Enter Elements Into an Array:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Sum of all the elements in the array was {arr.Sum()}");
            for (i = 0; i < arr.Length - 1; i++)
            {
                j[i] = arr[i] + arr[i + 1];
            }
            Console.WriteLine($"Smallest Sum Of Consecutive Numbers In An Array Was: {j.Min()} ");
        }
    }
}

