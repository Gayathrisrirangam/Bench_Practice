using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _16_Loop_Avg
    {
        public static void Main()
        {
            int[] num = new int[10];
            int sum = 0;
            Console.WriteLine("Enter the numbers");
             
            for(int i = 0;i<10;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + num[i];
            }
            int avg = sum / 10;
            Console.WriteLine("The avg is");
            Console.WriteLine(avg);
        }
    }
}
