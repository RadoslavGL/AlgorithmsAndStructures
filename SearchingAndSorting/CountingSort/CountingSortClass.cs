using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort
{
    class CountingSortClass
    {
        public static List<int> CountingSort(List<int> numbers, int min, int max)
        {
            int[] positions = new int[max - min + 1];
            for (int i = 0; i < numbers.Count; i++)
            {
                positions[numbers[i] - min]++;

            }

            List<int> result = new List<int>();
            for (int i = 0; i < positions.Length; i++)
            {
                int j = positions[i];
                while (j > 0)
                {
                    result.Add(i + min);
                    j--;
                }
            }

            return result;
        }
    }
}
