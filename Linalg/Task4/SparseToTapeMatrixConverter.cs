using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linalg.Task4
{
    public class SparseToTapeMatrixConverter
    {
        public Matrix Matrix { get; set; }
        public Matrix RealMatrix { get; set; } 
        public int Diametr { get; set; }
        public StreamWriter? Writer { get; private set; }
        List<int> Powers { get; set; }

        public SparseToTapeMatrixConverter(Matrix matrix, StreamWriter writer = null)
        {
            RealMatrix = new(matrix);
            Matrix = FormMatrixForGibbs(matrix);
            Writer = writer;
        }

        public Dictionary<int, int> DijkstraAllDistances(int startV)
        {
            int vertexesNum = Matrix.Rows;
            SortedSet<Tuple<int, int>> ss = new SortedSet<Tuple<int, int>>();

            Dictionary<int, int> distances = new Dictionary<int, int>();
            for (int i = 0; i < vertexesNum; i++)
            {
                distances[i] = int.MaxValue;
            }

            ss.Add(Tuple.Create(0, startV));
            distances[startV] = 0;

            while (ss.Count != 0)
            {
                int fromV = ss.First().Item2;
                ss.Remove(ss.First());

                for (int j = 0; j < vertexesNum; j++)
                {
                    int toV, weight;
                    if (Matrix[fromV, j] == 1)
                    {
                        toV = j;
                        weight = 1;

                        if (distances[toV] > distances[fromV] + weight)
                        {
                            distances[toV] = distances[fromV] + weight;
                            ss.Add(Tuple.Create(distances[toV], toV));
                        }
                    }
                }
            }

            return distances;
        }


        public (bool distanceExists, int distance) DijkstraAlgorithm(int startV, int endV)
        {
            int vertexesNum = Matrix.Rows;
            SortedSet<Tuple<int, int>> ss = new SortedSet<Tuple<int, int>>();

            int[] distances = new int[vertexesNum];
            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = int.MaxValue;
            }

            ss.Add(Tuple.Create(0, startV));
            distances[startV] = 0;

            while (ss.Count != 0)
            {
                int fromV = ss.First().Item2;
                ss.Remove(ss.First());

                if (fromV == endV) break;

                for (int j = 0; j < vertexesNum; ++j)
                {
                    int toV, weight;
                    if (Matrix[fromV, j] == 1)
                    {
                        toV = j;
                        weight = 1;

                        if (distances[toV] > distances[fromV] + weight)
                        {
                            distances[toV] = distances[fromV] + weight;
                            ss.Add(Tuple.Create(distances[toV], toV));
                        }
                    }
                }
            }

            return distances[endV] == int.MaxValue ? (false, -1) : (true, distances[endV]);
        }



        public int CalcDiametr()
        {
            Matrix w = new Matrix(Matrix);
            Matrix nextW = new Matrix(Matrix);
            Diametr = 1;

            do
            {
                nextW = MatrixMultiplication(nextW, w);
                Diametr++;
            } while (nextW.Elements.Length != MatrixElementsSum(nextW));

            return Diametr;
        }

        public int Gibbs()
        {

            GetIndexFirstVertexWithMinPower();
            CalcDiametr();
            List<LevelsTable> tables = new();
            LevelsTable table = BuildLevels(9);

            Writer?.Write("Main table: \n" + table + "\n-----------------------------------------\n");
            do
            {
                if (tables.Count != 0)
                {
                    table = tables.Max();
                    Writer?.Write("Main table: \n" + table + "\n-----------------------------------------\n");
                }
                    

                foreach (var vertex in table[table.Count - 1])
                {
                    var table2 = BuildLevels(vertex);
                    tables.Add(table2);

                    Writer?.Write(table2.ToString() + '\n');
                }
            } while (tables.All((t) => t.Eccentricity != table.Eccentricity));
            
            return table[0].ElementAt(0);
        }

        public List<int> CutHillMckee()
        {
            int startVertex = Gibbs();
            List<int> vertexEnumeration = new();
            SortedSet<int> visitedVertexes = new();

            vertexEnumeration.Add(startVertex);
            visitedVertexes.Add(startVertex);
            List<Tuple<int, int>> vertexWithPower = new();
            int insertedCount = 1;

            do
            {
                List<int> range = vertexEnumeration.GetRange(visitedVertexes.Count - insertedCount, insertedCount);
                foreach (int vertex in range)
                {
                    for (int i = 0; i < Matrix.Columns; i++)
                    {
                        if (vertex != i && Matrix[vertex, i] == 1 && !visitedVertexes.Contains(i))
                        {
                            vertexWithPower.Add(new(i, Powers[i]));
                            visitedVertexes.Add(i);
                        }
                    }
                }

                vertexWithPower.Sort((a, b) => a.Item2.CompareTo(b.Item2));
                insertedCount = vertexWithPower.Count;
                foreach (var pair in vertexWithPower)
                {
                    vertexEnumeration.Add(pair.Item1);
                }
                vertexWithPower.Clear();

            } while (visitedVertexes.Count != Matrix.Rows);

            if (Writer != null)
            {
                Writer.WriteLine($"Vertexes enumeration");
                for (int i = 0; i < vertexEnumeration.Count; ++i)
                {
                    Writer.WriteLine($"{i}: {vertexEnumeration[i] + 1}");
                }
            }
            return vertexEnumeration;
        }

        public Matrix ConvertMatrix()
        {
            List<int> vertexEnumeration = CutHillMckee();
            Matrix resultMatrix = new(Matrix);
            for (int i = 0; i < resultMatrix.Rows; i++)
            {
                for (int j = 0; j < resultMatrix.Columns; ++j)
                {
                    resultMatrix[i, j] = RealMatrix[vertexEnumeration[i], vertexEnumeration[j]];
                }
            }

            //Console.WriteLine(resultMatrix);
            return resultMatrix;
        }

        public LevelsTable BuildLevels(int startVertex)
        {
            int level = 0;

            SortedSet<int> levelCandidates = new SortedSet<int> { startVertex };
            SortedSet<int> usedVertexes = new SortedSet<int> { startVertex };

            LevelsTable levels = new(startVertex);

            while (levelCandidates.Count != 0)
            {
                levelCandidates.Clear();
                foreach (var vertex in levels[level])
                {
                    for (int j = 0; j < Matrix.Columns; ++j)
                    {
                        if (vertex == j || usedVertexes.Contains(j))
                            continue;
                        if ((int)Matrix[vertex, j] == 1)
                        {
                            levelCandidates.Add(j);
                            usedVertexes.Add(j);
                        }
                    }


                }

                ++level;
                levels.Add(new SortedSet<int>(levelCandidates));
            }

            levels.RemoveAt(levels.Count - 1);

            return levels;
        }

        public static Matrix MatrixMultiplication(Matrix a, Matrix b)
        {
            if (a.Columns != b.Rows)
            {
                throw new InvalidOperationException("Invalid matrix dimensions for multiplication");
            }

            Matrix result = new(a.Rows, b.Columns);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    for (int k = 0; k < a.Columns; k++)
                    {
                        result.Elements[i, j] = (int)result.Elements[i, j] | (int)(a.Elements[i, k] * b.Elements[k, j]);
                    }
                }
            }

            return result;
        }

        public double MatrixElementsSum(Matrix matrix)
        {
            double sum = 0;
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; ++j)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        public int GetIndexFirstVertexWithMinPower()
        {
            List<int> vertexesPowers = new List<int>();
            int vertexPower = 0;
            for (int i = 0; i < Matrix.Rows; i++)
            {
                for (int j = 0; j < Matrix.Columns; ++j)
                {
                    if (i == j)
                        continue;
                    if ((int)Matrix[i, j] == 1)
                        ++vertexPower;
                }

                vertexesPowers.Add(vertexPower);
                vertexPower = 0;
            }

            Powers = vertexesPowers;
            return vertexesPowers.IndexOf(vertexesPowers.Min());
        }

        public Matrix FormMatrixForGibbs(Matrix matrix)
        {
            Matrix result = new Matrix(matrix);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; ++j)
                {
                    result[i,j] = matrix[i, j] != 0 ? 1: 0;
                }
            }
            return result;
        }
    }
}