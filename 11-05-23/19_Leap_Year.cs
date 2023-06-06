using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _19_Leap_Year
    {
        public static void Main()
        {
            Console.WriteLine("enter the year");
            int yr = Convert.ToInt32(Console.ReadLine());
            if (yr % 4 == 0 && (yr % 400 == 0 || yr % 100 != 0))
            {
                Console.WriteLine("The given year is Leap year");
            }
            else
                Console.WriteLine("The given year is not a leap year");
        }
    }
}
