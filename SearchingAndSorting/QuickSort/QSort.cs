using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QS
    {
        public static void Main(string[] args)
        {
            //comparison Sort;
            //average O(n log n)

        }

        public static List<int> QuickSorter(List<int> numbers)
        {
            if (numbers.Count < 2)
            {
                return numbers;
            }

            int[] pivotCandidates = new int[3] { numbers[0], numbers[numbers.Count / 2], numbers[numbers.Count - 1] };
            int pivotValue = pivotCandidates.OrderBy(x => x).Skip(1).First();
            int pivotIndex = numbers.IndexOf(pivotValue);

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == pivotIndex)
                {
                    continue;
                }

                if (numbers[i] < numbers[pivotIndex])
                {
                    left.Add(numbers[i]);
                }
                else
                {
                    right.Add(numbers[i]);
                }
            }

            List<int> result = new List<int>();

            List<int> sortedLeft = QuickSorter(left);
            List<int> sortedRight = QuickSorter(right);

            result.AddRange(sortedLeft);
            result.Add(numbers[pivotIndex]);
            result.AddRange(sortedRight);

            return result;
        }
    }
}
