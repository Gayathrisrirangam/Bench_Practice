using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _22_Second_Largest
    {
        public static void Main()
        {
            Console.WriteLine("Enter the array size");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int sndlar;
            Console.WriteLine("Enter the array elements");
            for(int i= 0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("The second largest number is" + arr[n - 2]);


        }
    }
}
