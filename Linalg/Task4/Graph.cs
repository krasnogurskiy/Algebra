using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linalg.Task4
{
    public class Graph
    {
        private double[,] matrix;
        private bool[] visited;
        public List<List<int>> paths;
        public List<int> Npaths { get; set; }

        public Graph(double[,] adjacencyMatrix)
        {
            matrix = adjacencyMatrix;
            visited = new bool[matrix.GetLength(0)];
            paths = new List<List<int>>();
        }

        private void DFS(int fromVertex, int toVertex, List<int> path)
        {
            visited[fromVertex] = true;
            path.Add(fromVertex);

            if (fromVertex == toVertex)
            {
                paths.Add(new List<int>(path));
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[fromVertex, i] == 1 && !visited[i])
                    {
                        DFS(i, toVertex, path);
                    }
                }
            }

            visited[fromVertex] = false;
            path.RemoveAt(path.Count - 1);
        }

        public List<int> FindAllPaths(int fromVertex, int toVertex)
        {
            paths.Clear();
            DFS(fromVertex, toVertex, new List<int>());
            ConvertePaths();
            return Npaths;
        }

        public void ConvertePaths()
        {
            Npaths = new List<int>();
            foreach (var row in paths)
            {
                Npaths.Add(row.Count - 1);
            }
        }
    }
}
