using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _54_Traingle
    {
        public static void Main()
        {
            int i, j, k, rows = 4;
            for (i = 1; i <= rows; i++)
            {
                for (j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= (2 * i - 1); k++)
                {
                    if (k == 1 || i == rows || k == (2 * i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}

