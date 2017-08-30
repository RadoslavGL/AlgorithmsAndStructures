using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort
{
    public class CountingSortGenClass
    {
        public static List<T> CountingSort<T>(List<T> elements, int min, int max, Func<T, int> getValue)
        {
            int positionsCount = max - min + 1;
            List<List<T>> positions = new List<List<T>>(positionsCount);
            for (int i = 0; i < positionsCount; i++)
            {
                positions.Add(new List<T>());
            }

            for (int i = 0; i < elements.Count; i++)
            {
                int elementPosition = getValue(elements[i]) - min;
                positions[elementPosition].Add(elements[i]);
            }

            List<T> result = positions.SelectMany(p => p).ToList();

            return result;
        }
    }
}
