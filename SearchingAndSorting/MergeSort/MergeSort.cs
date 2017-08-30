using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            //Comparison Based
            //Average O(n log n)
        }

        public static List<int> MergeSortest(List<int> numbers)
        {
            if (numbers.Count < 2)
            {
                return numbers;
            }

            List<int> left = numbers.Take(numbers.Count / 2).ToList();
            List<int> right = numbers.Skip(numbers.Count / 2).ToList();

            left = MergeSortest(left);
            left = MergeSortest(right);

            return MergeSortedLists(left, right);
        }

        public static List<int> MergeSortedLists(List<int> left, List<int> right)
        {
            int i = 0;
            int j = 0;
            List<int> result = new List<int>();

            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Count)
            {
                result.Add(left[i]);
                i++;
            }

            while (j < right.Count)
            {
                result.Add(right[j]);
                j++;
            }

            return result;
        }

    }
}
