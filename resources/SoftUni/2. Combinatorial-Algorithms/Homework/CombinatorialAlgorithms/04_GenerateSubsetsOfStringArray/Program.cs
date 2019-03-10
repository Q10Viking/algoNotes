using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_GenerateSubsetsOfStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new List<string>() { "test", "rock", "fun", "aba" };
            var k = 2;
            GenerateCombinations(s, new List<string>(), k, 0);
        }

        static void GenerateCombinations(List<string> s, List<string> result, int k, int index)
        {
            if (result.Count == k)
            {
                Print(result);
                return;
            }

            for (int i = index; i < s.Count; i++)
            {
                result.Add(s[i]);
                GenerateCombinations(s, result, k, i + 1);
                result.RemoveAt(result.Count - 1);
            }

        }

        private static void Print(List<string> result)
        {
            Console.WriteLine($"({result[0]} {result[1]})");
        }
    }
}
