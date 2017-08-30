using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    public class ProperShuffle
    {
        static void Main(string[] args)
        {
        }

        public static void Random(List<int> numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Count; i++)
            {
                int newIndex = random.Next(i + 1, numbers.Count - 1);
                int temp = numbers[newIndex];
                numbers[newIndex] = numbers[i];
                numbers[i] = temp;
            }
        }
    }
}
