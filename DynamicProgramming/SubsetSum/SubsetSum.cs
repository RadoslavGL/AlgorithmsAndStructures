using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSum
{
    class SubsetSum
    {
        static void Main(string[] args)
        {
            var set = new[] { 3, 34, 4, 12, 5, 2 };
            var sum = 45;
            if (IsSubsetSum(set, sum))
            {
                Console.WriteLine("Found a subset with given sum");
            }
            else
            {
                Console.WriteLine("No subset with given sum");
            }

        }

        private static bool IsSubsetSumRecursive(int[] set, int n, int sum)
        {
            if (sum == 0)
            {
                return true;
            }

            if (n == 0 && sum != 0)
            {
                return false;
            }

            if (set[n - 1] > sum)
            {
                return IsSubsetSumRecursive(set, n - 1, sum);
            }

            return IsSubsetSumRecursive(set, n - 1, sum) || IsSubsetSumRecursive(set, n - 1, sum - set[n - 1]);
        }

        private static bool IsSubsetSum(int[] set, int sum)
        {
            const int NotSet = -1;
            var sumOfAll = set.Sum();
            var last = new int[sumOfAll + 1];
            var currentSum = 0;

            for (int i = 1; i < sumOfAll; i++)
            {
                last[i] = NotSet;
            }

            for (int i = 0; i < set.Length; i++)
            {
                for (int j = currentSum; j > - 1; j--)
                {
                    if (last[j] != NotSet && last[j + set[i]] == NotSet)
                    {
                        last[j + set[i]] = i;
                    }
                }

                currentSum += set[i];
            }

            if (last[sum] != NotSet)
            {
                Console.Write("{0} = ", sum);
                while (sum > 0)
                {
                    var number = set[last[sum]];
                    sum -= number;

                    if (sum > 0)
                    {
                        Console.Write("{0} + ", number);
                    }
                    else
                    {
                        Console.Write(number);
                    }
                }

                Console.WriteLine();
            }

            return last[sum] != NotSet;
        }

    }
}
