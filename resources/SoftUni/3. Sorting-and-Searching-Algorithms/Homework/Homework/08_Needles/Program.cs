using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _08_Needles
{
    class Program
    {
        static void Main(string[] args)
        {
            var c_n = Console.ReadLine();
            var c_n_array = c_n.Split(' ').Select(int.Parse).ToArray();
            var c = c_n_array[0];
            var n = c_n_array[1];  
            var c_string = Console.ReadLine();
            //var c_string = "3 5 11 0 0 0 12 12 0 0 0 12 12 70 71 0 90 123 140 150 166 190 0";
            var n_string = Console.ReadLine();
            //var n_string = "5 13 90 1 70 75 7 188 12";
            int[] array = c_string.Split(' ').Select(int.Parse).ToArray();
            int[] needles = n_string.Split(' ').Select(int.Parse).ToArray();
            SortedDictionary<int, int> foundPlaces = new SortedDictionary<int, int>();
            List<int> result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var needle = needles[i];
                var lastNotZeroElement = -1;
                if (foundPlaces.ContainsKey(needle))
                {
                    result.Add(foundPlaces[needle]);
                    continue;
                }

                var startRange = foundPlaces.Where(d => d.Key < needle);
                var start = 0;
                if (startRange.Any())
                {
                    start = startRange.Last().Value - 1;
                    lastNotZeroElement = start;
                }

                for (int j = start; j < c; j++)
                {
                    var element = array[j];

                    if (element >= needle)
                    {
                        if (lastNotZeroElement == -1)
                        {
                            result.Add(0);
                            foundPlaces[needle] = 0;
                        } 
                        else
                        {
                            result.Add(lastNotZeroElement + 1);
                            foundPlaces[needle] = lastNotZeroElement + 1;
                        }

                        break;
                    }

                    if (element != 0)
                    {
                        lastNotZeroElement = j;
                    }

                    if (j == array.Count() - 1)
                    {
                        result.Add(lastNotZeroElement + 1);
                        foundPlaces[needle] = lastNotZeroElement + 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
