using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_basic_programs
{
    class Repeated_chars_string
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            Console.WriteLine("The repeated characters in the given string");
           while(str.Length>0)
            {
                Console.WriteLine(str[0] + " = ");
                int count = 0;
                for(int j=0; j <str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                       count ++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
                
            }
            Console.ReadLine();
        }
    }
}
