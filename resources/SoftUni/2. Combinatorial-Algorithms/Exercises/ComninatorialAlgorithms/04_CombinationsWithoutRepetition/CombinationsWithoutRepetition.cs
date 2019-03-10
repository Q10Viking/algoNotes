using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CombinationsWithoutRepetition
{
    class CombinationsWithoutRepetition
    {
        static int[] array;
        static bool[] used;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            array = new int[k];
            used = new bool[n + 1];
            GenerateCombinationsWithRepetition(n, k, 0, 1);
        }

        static void GenerateCombinationsWithRepetition(int n, int k, int index, int startIndex)
        {
            if (index == k)
            {
                Print();
                return;
            }

            for (int i = startIndex; i <= n; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    array[index] = i;
                    GenerateCombinationsWithRepetition(n, k, index + 1, i);
                    used[i] = false;
                }
            }
        }

        static void Print()
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
