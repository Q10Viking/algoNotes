using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Permutations
{
    class Permutations
    {
        static int count = 0;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var array = Enumerable.Range(1, n).ToArray();
            GeneratePermutations(array, 0);
            Console.WriteLine("Total permutations: {0}", count);
        }

        static void GeneratePermutations(int[] array, int index)
        {
            if (index >= array.Length - 1)
            {
                count++;
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = index; i < array.Length; i++)
            {
                Swap(ref array[index], ref array[i]);
                GeneratePermutations(array, index + 1);
                Swap(ref array[index], ref array[i]);
            }
        }

        private static void Swap(ref int i, ref int j)
        {
            if (i == j)
            {
                return;
            }

            i ^= j;
            j ^= i;
            i ^= j;             
        }
    }
}
