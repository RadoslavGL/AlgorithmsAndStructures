using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        private const int NoPrevious = -1;

        static void Main(string[] args)
        {
            var sequence = new[] { 1, 8, 2, 7, 3, 4, 1, 6 };
            var length = new int[sequence.Length];
            var predecessor = new int[sequence.Length];

            CalculateLongestIncreasingSubsequence(sequence, length, predecessor);
        }

        private static int CalculateLongestIncreasingSubsequence(int[] sequence, int[] length, int[] predecessor)
        {
            var bestEnd = 0;
            var bestIndex = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                length[i] = i;
                predecessor[i] = NoPrevious;

                for (int k = 0; k < i - 1; k++)
                {
                    if (sequence[k] < sequence[i])
                    {
                        if (length[k] + 1 > length[i])
                        {
                            length[i] = length[k] + 1;
                            predecessor[i] = k;

                            if (length[i] > bestEnd)
                            {
                                bestEnd = length[i];
                                bestIndex = i;
                            }
                        }
                    }
                }
            }


            return bestIndex;
        }


    }
}
