using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _17_Sum_even_Odd
    {
        public static void Main()
        {
            int[] num = new int[10];
            int sum = 0,sum1=0;
            Console.WriteLine("Enter the integers");
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());

                if (num[i]%2 == 0)
                {
                    sum = sum + num[i]; 
                }
                else
                    sum1 = sum1 + num[i];
               
            }
            Console.WriteLine("Even numbers sum is" + sum);
            Console.WriteLine("Odd numbers sum is" + sum1);
        }
    }
}
