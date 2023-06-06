using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_basic_programs
{
    class Power_Of_Number
    {
        public static void Main()
        {
            int result = 1;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the power");
            int pow = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <pow; i++)
            {
                result *= num;
            }
            Console.WriteLine(result);
        }
    }
}
