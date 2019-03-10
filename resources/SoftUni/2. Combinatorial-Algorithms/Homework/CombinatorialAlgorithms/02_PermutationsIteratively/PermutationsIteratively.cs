using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PermutationsIteratively
{
    class PermutationsIteratively
    {
        static int count = 1;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var elements = Enumerable.Range(1, n).ToArray();
            var array = Enumerable.Range(0, elements.Length + 1).ToArray();

            Console.WriteLine(string.Join(" ", elements));
            var i = 1;
            while (i < n)
            {
                array[i]--;
                var j = 0;
                if (i % 2 == 1)
                {
                    j = array[i];
                }
                Swap(ref elements[j], ref elements[i]);
                i = 1;
                while (array[i] == 0)
                {
                    array[i] = i;
                    i++;
                }
                Console.WriteLine(string.Join(" ", elements));
                count++;
            }

            Console.WriteLine("Total permutations: {0}", count);
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
