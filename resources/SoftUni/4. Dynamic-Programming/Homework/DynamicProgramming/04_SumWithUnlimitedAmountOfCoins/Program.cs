using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SumWithUnlimitedAmountOfCoins
{
    class Program
    {
        private static int totalCount;

        static void Main(string[] args)
        {
            var s = 100;
            var coins = new int[] { 1, 2, 5, 10, 20, 50, 100 };
            //GeneratCombinations(s, coins);
            totalCount = MyGenerateCombinations(s, coins);
            Console.WriteLine(totalCount);

            // Slow solution, but it shows the actual combinations, not just the number
            //var possibleSums = CalculatePossibleSums(coins, s);
            //var combinations = FindCombinations(coins, s, possibleSums, new List<int>(), new List<List<int>>());
            //Console.WriteLine("The {0} combinations are:", combinations.Count);
            //foreach (var combination in combinations)
            //{
            //    Console.WriteLine("{0} = {1}", s, string.Join(" + ", combination));
            //}
        }

        static bool[] CalculatePossibleSums(int[] coins, int targetSum)
        {
            var possible = new bool[targetSum + 1];
            possible[0] = true;
            for (int sum = 0; sum < possible.Length; sum++)
            {
                if (possible[sum])
                {
                    for (int i = 0; i < coins.Length; i++)
                    {
                        int newSum = sum + coins[i];
                        if (newSum <= targetSum)
                        {
                            possible[newSum] = true;
                        }
                    }
                }
            }

            return possible;
        }

        static List<List<int>> FindCombinations(int[] coins, int targetSum, bool[] possibleSums, List<int> combination, List<List<int>> allCombinations)
        {
            if (targetSum < 0)
            {
                return allCombinations;
            }

            if (targetSum == 0)
            {
                var newCollection = combination.OrderByDescending(i => i).ToList();
                var findCombination = allCombinations.Any(l => l.SequenceEqual(newCollection));
                if (!findCombination)
                {
                    allCombinations.Add(newCollection);
                }

                return allCombinations;
            }

            for (int i = 0; i < coins.Length; i++)
            {
                int newSum = targetSum - coins[i];
                if (newSum >= 0 && possibleSums[newSum])
                {
                    combination.Add(coins[i]);
                    allCombinations = FindCombinations(coins, newSum, possibleSums, combination, allCombinations);
                    combination.RemoveAt(combination.Count - 1);                    
                }
            }

            return allCombinations;
        }

        private static int MyGenerateCombinations(int targetSum, int[] coins)
        {
            var columns = targetSum + 1;
            var rows = coins.Length + 1;
            var combinations = new int[rows, columns];

            for (int row = 1; row < rows; row++)
            {
                for (int col = 1; col < columns; col++)
                {
                    var currentCoin = coins[row - 1];
                    if (currentCoin == col)
                    {
                        combinations[row, col] = combinations[row - 1, col] + 1;
                    }
                    else
                    {
                        if (coins[row - 1] < col)
                        {
                            combinations[row, col] = combinations[row - 1, col] + combinations[row, col - currentCoin];
                        }
                        else
                        {
                            combinations[row, col] = combinations[row - 1, col];
                        }
                    }
                }
            }

            return combinations[coins.Length, targetSum];
        }
    }
}
