using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _26_Primefactors
    {
        public static void Main()
        {
           
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num /= i;
                }
            }
            Console.WriteLine();
        }
    }
}
