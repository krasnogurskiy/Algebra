using Linalg;
using Linalg.Solvers;
using Linalg.Task4;
using System.Security.Cryptography;

namespace LinAlgConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] adjacencyMatrix = {
                {1,0,0,0,0,1,0,0,0,1,0},
                {0,1,0,1,0,0,0,0,1,0,0},
                {0,0,1,0,1,0,1,0,0,0,1},
                {0,1,0,1,0,0,1,0,0,0,0},
                {0,0,1,0,1,0,0,1,0,0,0},
                {1,0,0,0,0,1,0,0,1,0,0},
                {0,0,1,1,0,0,1,0,0,0,1},
                {0,0,0,0,1,0,0,1,0,0,1},
                {0,1,0,0,0,1,0,0,1,0,1},
                {1,0,0,0,0,0,0,0,0,1,1},
                {0,0,1,0,0,0,1,1,1,1,1}
            };

            Graph graph = new Graph(adjacencyMatrix);
            int fromVertex = 0;
            int toVertex = 5;

            List<List<int>> allPaths = graph.FindAllPaths(fromVertex, toVertex);

            Console.WriteLine($"All possible paths from vertex {fromVertex} to vertex {toVertex}:");
            foreach (var path in allPaths)
            {
                Console.WriteLine(string.Join(" -> ", path));
            }




            //Matrix a = new Matrix(matrix);
            //SparseToTapeMatrixConverter s = new SparseToTapeMatrixConverter(a);
            //Dictionary<int, int> dict = s.DijkstraAllDistances(0);
            //foreach (var kvp in dict)
            //{
            //    Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
            //}
            //Console.WriteLine("-------------------------------");
            //s.ConvertMatrix();

            //SortedSet<int> ss = new SortedSet<int> { 1, 2, 3 };
            //Console.WriteLine(ss);
            //Console.WriteLine(s.MatrixMultiplication(a,a));
            //Console.WriteLine(a);
            //Console.WriteLine(a.MaxNorm());
            //GaussTapeMatrix gaussTapeMatrix = new GaussTapeMatrix();
            //gaussTapeMatrix.MatrixToTape(a, 3);
            //Console.WriteLine(gaussTapeMatrix.Tape);
            //Console.WriteLine();
            //Console.WriteLine(gaussTapeMatrix.TapeToMatrix(a.Rows, 3));
            //double[,] m = new double[,] { { 1, 2, 3, 4 }, { 2, 5, 8, 7 }, { 3, 8, 15, 14 }, { 4, 7, 14, 27 } };
            ////double[] v = new double[] { 10, 22, 40, 52 };
            //double[] v = new double[] { 1, 0, 0, 0 };
            ////double[] v = new double[] { 0, 1, 0, 0 };


            ////double[,] m = new double[,] { { 4, 1, 0, 2 }, { 1, 2, 0, 0 }, { 0, 0, 4, 1 }, { 2, 0, 1, 4 } };
            ////double[] v = new double[] { 7, 3, 5, 7 };
            ////double[,] m = new double[,] { { 10, 5, 3, -4 }, { 3, 7, -2, 0 }, { 5, -7, 10, 0 }, { 0, 3, 0, -5 } };
            ////double[] v = new double[] { 20, 9, -9, 1 };
            //Matrix a = new Matrix(m);
            //Vector x = new Vector(4);
            //Vector b = new Vector(v);
            //Sle sle = new Sle(a, x, b);
            //GaussSolver sd = new GaussSolver(a, b);
            //sd.Solve();
            //Console.WriteLine(sd.X);
            //Console.WriteLine(sd.InverseMatrix);
            //Console.WriteLine("--------------------");
            //Console.WriteLine(sd.GetInverseMatrix());


            //Vector v11 = new Vector(new double[] { 1, 0, 0, 0 });
            //Vector v1 = new Vector(new double[] { 0, 1, 0, 0 });
            //Vector v2 = new Vector(new double[] { 0, 0, 1, 0 });
            //Vector v3 = new Vector(new double[] { 0, 0, 0, 1 });



            //for(int i = 0; i < sd.DecomposedMatrix.Rows; ++i)
            //{
            //    sd.DecomposedMatrix[i, i] = 0;
            //}
            //Console.WriteLine(sd.DecomposedMatrix * v1);

            //GaussSolver sd2 = new GaussSolver(sd.DecomposedMatrix, new Vector(new double[] { 4, 5.5, -5.45, -2.89 }));
            //sd2.Solve();
            //Console.WriteLine(sd2.X);

            //Console.WriteLine("Matrix A:");
            //Console.WriteLine(sle.A);
            //Console.WriteLine("Decomposed Matrix:");
            //Console.WriteLine(sle.DecomposedMatrix);
            //Console.WriteLine("Inverse Matrix:");
            //Console.WriteLine(sle.InverseMatrix);
            //Console.WriteLine();
            //Matrix q = sle.InverseMatrix * sle.A;
            //Console.WriteLine(q);
            //SeidelSolver sd = new SeidelSolver(a, b, 0.00000001, new Vector(new double[] { 2, 1.3, -0.9, -0.2 })) ;
            //sd.Solve();
            //Console.WriteLine(sd.X);
            //Console.WriteLine(sd.ResidualNorm());
        }
    }

    


}
