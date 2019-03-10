using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LongestZigzagSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = "8,3,5,7,0,8,9,10,20,20,20,12,19,11";
            var input = Console.ReadLine();
            var seq = input.Split(',').Select(int.Parse).ToArray();

            List<int> seqBigEven = new List<int>();
            List<int> seqSmallEven = new List<int>();

            seqBigEven.Add(seq[0]);
            seqSmallEven.Add(seq[0]);

            for (int i = 1; i < seq.Length; i++)
            {
                //Check whether to add it to the big even list
                if (seqBigEven.Count % 2 == 0)
                {
                    if (seq[i] > seqBigEven.Last())
                    {
                        seqBigEven.Add(seq[i]);
                    }
                    else
                    {
                        seqBigEven[seqBigEven.Count - 1] = seq[i];
                    }
                } 
                else
                {
                    if (seq[i] < seqBigEven.Last())
                    {
                        seqBigEven.Add(seq[i]);
                    }
                    else
                    {
                        seqBigEven[seqBigEven.Count - 1] = seq[i];
                    }
                }

                //Check whether to add it to the small even list
                if (seqSmallEven.Count % 2 == 0)
                {
                    if (seq[i] < seqSmallEven.Last())
                    {
                        seqSmallEven.Add(seq[i]);
                    }
                    else
                    {
                        seqSmallEven[seqSmallEven.Count - 1] = seq[i];
                    }
                }
                else
                {
                    if (seq[i] > seqSmallEven.Last())
                    {
                        seqSmallEven.Add(seq[i]);
                    }
                    else
                    {
                        seqSmallEven[seqSmallEven.Count - 1] = seq[i];
                    }
                }
            }

            if (seqSmallEven.Count >= seqBigEven.Count)
            {
                Console.WriteLine(string.Join(",", seqSmallEven));
            }
            else
            {
                Console.WriteLine(string.Join(",", seqBigEven));
            }
        }
    }
}
