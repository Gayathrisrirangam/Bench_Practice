using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _20_Largest_smallest_Array
    {
        public static void Main()
        {
            int[] arr = new int[5];
            int largest, smallest;
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
                
            }
            largest = arr.Max();
            smallest = arr.Min();
            Console.WriteLine("Largest number is " + largest);
            Console.WriteLine("smallest number is " + smallest);
        }
    }
}
