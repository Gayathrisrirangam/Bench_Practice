using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _21_Non_reapeated_digits
    {
        public static void Main()
        {
            int[] arr = new int[5];
            int j, k;
            Console.WriteLine("Enter the digits");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (j = 0; j < arr.Length; j++)
            {
                for(k = 0; k < arr.Length; k++)
                {
                    if (arr[j] == arr[k] && (j != k))
                        break;
                }
                if (k == arr.Length)
                    Console.WriteLine("non repeated digits are" + arr[j]);

            }
           
        }
    }
}
