using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SumWithLimitedAmountOfCoins
{
    class Program
    {
        private static int totalCount;

        static void Main(string[] args)
        {
            var s = 5;
            //var coins = new int[] { 1, 2, 2, 5, 5, 10 }.OrderBy(c => c).ToArray();
            //var coins = new int[] { 1, 2, 2, 3, 3, 4, 6 }.OrderBy(c => c).ToArray();
            var coins = new int[] { 1, 2, 2, 5 }.OrderBy(c => c).ToArray();
            //var coins = new int[] { 50, 20, 20, 20, 20, 20, 10 }.OrderBy(c => c).ToArray();
            //GeneratCombinations(s, coins);
            totalCount = MyGenerateCombinations(s, coins);
            Console.WriteLine(totalCount);
        }

        private static int MyGenerateCombinations(int targetSum, int[] coins)
        {
            var columns = targetSum + 1;
            var rows = coins.Length + 1;
            var combinations = new bool[rows, columns];
            var result = 0;

            for (int row = 1; row < rows; row++)
            {
                var currentCoin = coins[row - 1];
                for (int col = 1; col < columns; col++)
                {
                    if (currentCoin == col)
                    {
                        combinations[row, col] = true;
                    }
                    else
                    {
                        if (currentCoin < col)
                        {
                            combinations[row, col] = combinations[row - 1, col - currentCoin];
                        }
                        else
                        {
                            combinations[row, col] = combinations[row - 1, col];
                        }
                    }
                }
            }

            for (int i = rows - 1; i > 0; i--)
            {
                if (combinations[i, targetSum])
                {
                    result++;
                }
            }

            return result;
        }
    }
}