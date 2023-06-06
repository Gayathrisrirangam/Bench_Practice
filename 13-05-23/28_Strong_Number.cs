using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _28_Strong_Number
    {
        public static void Main()
        {
            int r, sum = 0;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int str = num;
            while (str != 0)
            {
                r = str % 10;
                int f = fact(r);
                str = str / 10;
                sum = sum + f;
            }
            if (sum == num)
            {
                Console.WriteLine("The given number is a strong number");
            }
            else
            {
                Console.WriteLine("The given number is not a strong number");
            }
            Console.WriteLine();

            int fact(int r)
            {
                int mul = 1;
                for (int i = 1; i <= r; i++)
                {
                    mul = mul * i;
                }
                return mul;
            }
        }
           
    }
}

