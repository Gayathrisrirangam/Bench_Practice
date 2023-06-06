using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _38_Palindrome
    {
        public static void Main()
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            char[] str1 = str.ToCharArray();
            Array.Reverse(str1);
            string str2 = new string(str1);
            Console.WriteLine("The reverse of given string is\n" + str2);
            if (str == str2)
            {
                Console.WriteLine("The given string is Palindrome");
            }
            else
                Console.WriteLine("The given string is not a palindrome");
        }


        //public static void Main(){
        // Console.WriteLine("Enter a number");
        //int num = Convert.ToInt32(Console.ReadLine());
        //            string num1 = num.ToString();
        //            char[] num2 = num1.ToCharArray();
        //Array.Reverse(num2);
        //string num3 = new string(num2);

        //Console.WriteLine("The reverse of given number is\n"+num3);
        //if(num1==num3)
        //{
        //Console.WriteLine("The given number is Palindrome");
        //}
        //else
        //Console.WriteLine("The given number is not a palindrome");
        //}
    }
}
