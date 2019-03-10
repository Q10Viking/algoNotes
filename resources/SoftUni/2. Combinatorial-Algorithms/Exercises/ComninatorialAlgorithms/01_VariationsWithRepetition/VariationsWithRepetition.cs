using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_VariationsWithRepetition
{
    class VariationsWithRepetition
    {
        static int[] array;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            array = new int[k];
            GenerateVariationsWithRepetition(n, k, 0);
        }

        static void GenerateVariationsWithRepetition(int n, int k, int index = 0)
        {
            if (index == k)
            {
                Print();
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                GenerateVariationsWithRepetition(n, k, index + 1);
            }
        }

        static void Print()
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
