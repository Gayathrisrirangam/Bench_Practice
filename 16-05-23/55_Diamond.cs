using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _55_Diamond
    {
        public static void Main()
        {
            int Space, Number;
            Console.WriteLine("Pyramid of number");
            int numberoflayer = 1, firstrows;
            Console.WriteLine("Please enter the number of layers");
            firstrows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= firstrows; i++) // Total number of layer for pramid
            {
                for (Space = 1; Space <= (firstrows - i); Space++) // Loop For Space
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++) //increase the value
                    Console.Write("*");
                for (Number = (i - 1); Number >= 1; Number--) //decrease the value
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int j = firstrows - 1; j >= numberoflayer; j--)
            {
                for (Space = j; Space <= firstrows - numberoflayer; Space++) // Loop For Space
                    Console.Write(" ");

                for (Number = 1; Number <= j; Number++) //increase the value
                    Console.Write("*");

                for (Number = (j - 1); Number >= 1; Number--) //decrease the value
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}