using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CombinationsWithRepetition
{
    class CombinationsWithRepetition
    {
        static int[] array;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            array = new int[k];
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
                array[index] = i;
                GenerateCombinationsWithRepetition(n, k, index + 1, i);
            }
        }

        static void Print()
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
