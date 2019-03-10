using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PermutationsWithRepetition
{
    class Program
    {
        static int count = 0;

        static void Main(string[] args)
        {
            //var array = new int[] { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            var array = new int[] { 1, 3, 5, 5 };
            GeneratePermutations(array, 0, array.Length);
        }

        static void GeneratePermutations(int[] array, int start, int n)
        {
            Console.WriteLine(string.Join(" ", array));

            for (int i = n - 2; i >= start; i--)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] != array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                        GeneratePermutations(array, i + 1, n);
                    }
                }

                var tmp = array[i];
                for (int k = i; k < n - 1; k++)
                {
                    array[k] = array[k + 1];
                }

                array[n - 1] = tmp;
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
