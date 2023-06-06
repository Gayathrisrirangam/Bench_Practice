using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _49_twoStrings_Characters
    {
        public static void Main()
        {
            Console.WriteLine("enter first string");
            string str = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            char[] str3 = str2.ToCharArray();
            //for (int i = 0; i < str2.Length; i++) {
            for (int i = 0; i < str3.Length; i++)
            {
                if (str[0] == str3[i])
                    Console.WriteLine(" given string starts with the contents of another string.");
            }
           
        }
    }
}
