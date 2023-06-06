using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _30_Amstrong_Number
    {
        public static void Main()
        {
            int r, sum = 0;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = num;
            while(num1 !=0)
            {
                r = num1 % 10;
                int fact = (int)Math.Pow(r,(int)Math.Log10(num)+1);
                num1 = num1 / 10;
                sum = sum + fact;

            }
            Console.WriteLine("The sum of the digits of the given number is  " + sum);
            if (sum == num)
            {
                Console.WriteLine("The given number is Amstrong number");
            }
            else
                Console.WriteLine("The given number is not an amstrong number");
           

        }
    }
}
