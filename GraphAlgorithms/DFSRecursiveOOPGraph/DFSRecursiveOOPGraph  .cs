using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSRecursiveOOPGraph
{
    public class DFSRecursiveOOPGraph
    {
        public static void Main(string[] args)
        {
            var graph = new Graph(
               new[]
                   {
                        new[] { 3, 6 }, // successors of vertice 0
                        new[] { 2, 3, 4, 5, 6 }, // successors of vertice 1
                        new[] { 1, 4, 5 }, // successors of vertice 2
                        new[] { 0, 1, 5 }, // successors of vertice 3
                        new[] { 1, 2, 6 }, // successors of vertice 4
                        new[] { 1, 2, 3 }, // successors of vertice 5
                        new[] { 0, 1, 4 } // successors of vertice 6
               });

            graph.DFSRecursive(0);

        }
    }
}
