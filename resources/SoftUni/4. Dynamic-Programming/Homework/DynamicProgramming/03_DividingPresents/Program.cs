using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DividingPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = "7,17,45,91,11,32,102,33,6,3";
            var input = Console.ReadLine();
            var elements = input.Split(',').Select(int.Parse).ToList();
            var target = elements.Sum() / 2;
            var possibleSums = CalculatePossibleSumsEqualOrLessThanTheTarget(elements, target);
            var alanSum = possibleSums.Keys.OrderByDescending(e => e).First();
            var alanPresents = new List<int>();
            var sum = alanSum;
            while (sum > 0)
            {
                int element = possibleSums[sum];
                alanPresents.Add(element);
                sum -= element;
                elements.Remove(element);
            }

            var bobSum = elements.Sum();
            Console.WriteLine("Difference:{0}", bobSum - alanSum);
            Console.WriteLine("Alan:{0} Bob:{1}", alanSum, bobSum);
            Console.WriteLine("Alan takes: {0}", string.Join(" ", alanPresents));
            Console.WriteLine("Bob takes the rest.");
        }

        static IDictionary<int, int> CalculatePossibleSumsEqualOrLessThanTheTarget(List<int> elements, int target)
        {
            var possibleSums = new Dictionary<int, int>();
            possibleSums.Add(0, 0);

            for (int i = 0; i < elements.Count; i++)
            {
                var newSums = new Dictionary<int, int>();
                foreach (var sum in possibleSums.Keys)
                {
                    int newSum = sum + elements[i];
                    if (!possibleSums.ContainsKey(newSum) && newSum <= target)
                    {
                        newSums.Add(newSum, elements[i]);
                    }  
                }

                foreach (var newSum in newSums)
                {
                    possibleSums.Add(newSum.Key, newSum.Value);
                }
            }

            return possibleSums;
        }
    }
}
