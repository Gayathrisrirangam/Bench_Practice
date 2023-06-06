using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_basic_programs
{
    class Unique_Character_of_String
    {
        public static void Main()
        {
            string input;
            Console.WriteLine("Enter the string");
            input = Console.ReadLine();
            char uniqueChar = '\0';
            foreach(char c in input)
            {
                if(input.IndexOf(c) == input.LastIndexOf(c))
                {
                    uniqueChar = c;
                    break;
                }
            }
            if(uniqueChar == '\0')
            {
                Console.WriteLine("No unique character found");
            }
            else
            {
                Console.WriteLine("The unique character is:" + uniqueChar);
            }
        }
    }
}
