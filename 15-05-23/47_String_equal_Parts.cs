using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _47_String_equal_Parts
    {
        public static void Main()
        {
            int count;  
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            Console.WriteLine("The repeated characters in the given string");
           for(int i=0;i<str.Length;i++)
            {
                count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        count++;
                    }
                   
                }

                if (count > 1)
                    Console.Write(str[i]+" = "+count+"\n");
                   // Console.Write(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
           
           
        }
    }
}
