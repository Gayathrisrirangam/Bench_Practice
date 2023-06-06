using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_basic_programs
{
    class Two_strings
    {
        public static void Main()
        {
            Console.WriteLine("enter the two strings");
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string reversedname1 = new string(name1.Reverse().ToArray());
            if (reversedname1==name2)
            {
                Console.WriteLine("equal strings");
            }
            else
                Console.WriteLine("not equal");

        }
    }
}
