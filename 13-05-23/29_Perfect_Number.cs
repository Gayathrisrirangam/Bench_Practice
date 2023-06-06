using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _29_Perfect_Number
    {
        public static void Main()
        {
            int sum = 0;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }

            }
            Console.WriteLine("The sum of factors of given number is "+sum);
            if (sum == num)
            {
                Console.WriteLine("The given number is Perfect number");
            }
            else
            {
                Console.WriteLine("The given number is not a perfect number");
            }

        }
    }
}
