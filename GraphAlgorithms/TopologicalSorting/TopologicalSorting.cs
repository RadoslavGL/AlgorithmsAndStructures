using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopologicalSorting
{
    public class TopologicalSorting
    {
        public static void Main(string[] args)
        {
            var matrix = new int[,]
                             {
                                 { 0, 1, 0, 0, 1, 0 },
                                 { 0, 0, 1, 1, 0, 0 },
                                 { 0, 0, 0, 1, 0, 0 },
                                 { 0, 0, 0, 0, 1, 1 },
                                 { 0, 0, 0, 0, 0, 1 },
                                 { 0, 0, 0, 0, 0, 0 },
                             };

            var graph = new Graph(matrix);
            graph.TestDFS();
            graph.ShowSort();

        }
    }
}
