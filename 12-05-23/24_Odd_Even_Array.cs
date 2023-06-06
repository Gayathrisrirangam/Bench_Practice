using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _24_Odd_Even_Array
    {
        public static void Main()
        {
            Console.WriteLine("please enter the length of the array elements");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[l];
            Console.WriteLine("the array elements are");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The even numbers are");
            for (int i = 0; i < arr.Length; i++) 
            { 

                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);

                }
            }
            Console.WriteLine("The odd numbers in the given array");
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine(arr[i]);

                }
            }




        }
    }
}
