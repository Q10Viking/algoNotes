using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VariationsWithoutRepetition
{
    class VariationsWithoutRepetition
    {
        static int[] array;
        static bool[] used;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            array = new int[k];
            used = new bool[n + 1];
            GenerateVariationsWithoutRepetition(n, k, 0);
        }

        static void GenerateVariationsWithoutRepetition(int n, int k, int index = 0)
        {
            if (index == k)
            {
                Print();
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    array[index] = i;
                    GenerateVariationsWithoutRepetition(n, k, index + 1);
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
