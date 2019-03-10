using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BinomialCoefficient
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int k = 5;

            Console.WriteLine(CalculateBinominalCoeficients(n, k, new Dictionary<Tuple<int, int>, int>()));
        }

        static int CalculateBinominalCoeficients(int n, int k, Dictionary<Tuple<int, int>, int> coeficients)
        {
            if (k == 0 || n == k)
            {
                return 1;
            }

            var newTuple = new Tuple<int, int>(n, k);
            if (coeficients.ContainsKey(newTuple))
            {
                return coeficients[newTuple];
            }

            int firstElement = CalculateBinominalCoeficients(n - 1, k - 1, coeficients);
            coeficients[new Tuple<int, int>(n - 1, k - 1)] = firstElement;

            int secondElement = CalculateBinominalCoeficients(n - 1, k, coeficients);
            coeficients[new Tuple<int, int>(n - 1, k)] = secondElement;

            return firstElement + secondElement;
        }
    }
}
