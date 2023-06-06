using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_basic_programs
{
    class Reverse_of_string
    {
        public static void Main()
        {
            string name;
            Console.WriteLine("enter the string");
            name = Console.ReadLine();
            Reverse_of_string str = new Reverse_of_string();
            string rev = str.Reverse(name);
            Console.WriteLine("Reverse of a string is " + rev);
            
        }

        private string Reverse(string name)
        {
            if (name.Length > 0)
                return name[name.Length - 1] + Reverse(name.Substring(0, name.Length - 1));
            else
                return name;
        }
    }
}
