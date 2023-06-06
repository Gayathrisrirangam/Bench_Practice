using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Questoins
{
    class _46_Sum_of_array_pairs
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number");
            int targetnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the array length");
            int ln = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[ln];
            Console.WriteLine("The array elements are");
            for (int i = 0; i <arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            List<Tuple<int, int>> pairs = FindPairsWithSum(arr, targetnum);
            Console.WriteLine($"Pairs with sum {targetnum}:");
            foreach(var pair in pairs)
            {
                Console.WriteLine($"{pair.Item1},{pair.Item2}");
            }
        }

        private static List<Tuple<int, int>> FindPairsWithSum(int[] arr, int targetnum)
        {
            List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();


            Dictionary<int, int> complements = new Dictionary<int, int>();
            foreach(int num in arr)
            {
                int complement = targetnum - num;
                if (!complements.ContainsKey(complement))
                {
                    pairs.Add(Tuple.Create(num, complement));
                }
            }
            return pairs;
        }
    }
}