using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _31_Amstrong_Number_range
    {

        public static void Main()
        {
            int count;
            int j, b, a, r, i;
            Console.WriteLine("Enter the starting range");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the ending range");

            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The amstrong numbers in the given range");
            for (i = a; i <= b; i++)
            {
                int K = i;
                count = 0;
                while (K != 0)
                {
                    r = (K % 10);
                    int nums = (int)Math.Pow(r, (int)Math.Log10(i) + 1);
                    K = K / 10;
                    count = count + nums;
                }

                if (count == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

