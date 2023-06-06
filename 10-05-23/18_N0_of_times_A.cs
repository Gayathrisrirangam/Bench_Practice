using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _18_N0_of_times_A
    {
        public static void Main()
        {
            int count = 0;
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            for(int i = 0; i < ch.Length; i++)
            {
                if(ch[i] == 'a' || ch[i] == 'A')
                {
                    count++;
                }
            }
            if(count>0)
            Console.WriteLine("The no of 'a' charcters is "+count);
        }
    }
}
