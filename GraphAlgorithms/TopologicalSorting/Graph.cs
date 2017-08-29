using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopologicalSorting
{
    public class Graph
    {
        private readonly int[,] edges;

        private readonly int count;

        private bool[] visitedElements;

        public List<int> sordedElements = new List<int>();

        public Graph(int[,] e)
        {
            this.edges = e;
            this.count = e.GetLength(0);
            this.visitedElements = new bool[this.count];
        }

        public void DFS(int startIndex)
        {
            this.visitedElements[startIndex] = true;

            for (int k = 0; k < this.count; k++)
            {
                if (this.edges[startIndex, k] == 1 && !this.visitedElements[k])
                {
                    this.DFS(k);
                }
            }

            this.sordedElements.Add(startIndex);
        }

        public void TestDFS()
        {
            for (int i = 0; i < this.count; i++)
            {
                if (!visitedElements[i])
                {
                    this.DFS(i);
                }
            }
        }


        public void ShowSort()
        {
            this.sordedElements.Reverse();
            foreach (var node in this.sordedElements)
            {
                Console.WriteLine("{0} ", node);
            }

        }
    }
}
