using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _51_Pyramid_Of_Characters
    {
        public static void Main()
        {
            int i, j;
            char input, alphabet = 'A';
            Console.WriteLine("Enter an uppercase character you want to print in the last row: ");
            input = Convert.ToChar(Console.ReadLine());
            for (i = 1; i <= (input - 'A' + 1); i++)
            {
                for (int Space = 0; Space <= (input - i); Space++) // Loop For Space
                    Console.Write(" ");
                for (j = 1; j <= i; j++) //Increase the value
                    Console.Write(alphabet);
               alphabet++;
                for (j = (i - 1); j >= 1; j--) //decrease the value
                    Console.Write(alphabet);
                Console.WriteLine("");
            }
        }
    }
}