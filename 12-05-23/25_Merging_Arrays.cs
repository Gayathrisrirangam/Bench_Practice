using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _25_Merging_Arrays
    {
        public static void Main()
        {
            Console.WriteLine("eneter the arrays length");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr1 = new int[n];
            Console.WriteLine("The first array elements are");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The second array elements are");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr3 = new int[arr.Length + arr1.Length];
            int count = 0;
           for(int i = 0; i < arr.Length; i++)
            {
                arr3[i] = arr[i];
                count++;
            }
           for(int j = 0; j < arr1.Length; j++)
            {
                arr3[count++] = arr1[j];
            }
            Console.WriteLine("The merging oif two arrays is");
            for (int i = 0; i < arr3.Length; i++)
                Console.WriteLine(arr3[i] + "  ");

        }
    }
}
