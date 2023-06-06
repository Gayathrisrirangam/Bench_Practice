using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _41_Right_Angle_Traingle
    {
        public static void Main()
        {
            int Space, Number;
            Console.WriteLine("Pyramid of number");
            int numberoflayer = 6;

            for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid
            {
                for (Number = 1; Number <= i; Number++) //increase the value
                    Console.Write(Number);
                for (Number = (i - 1); Number >= 1; Number--) //decrease the value
                    Console.Write(Number);
                Console.WriteLine();
            }
        }
    }
}
