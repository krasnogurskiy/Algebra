using System.Text;

namespace Linalg
{
    public class Matrix
    {
        public double[,] Elements { get; private set; } = null!;

        public int Rows { get; }

        public int Columns { get; }

        public Matrix()
        {
            Rows = 0;
            Columns = 0;
            Elements = new double[,] { };
        }

        public Matrix(int  rows, int columns)
        {
            if (rows <= 0 || columns <= 0) throw new ArgumentException("Invalid matrix dimensions");
            Rows = rows;
            Columns = columns;
            Elements = new double[rows, columns];
        }

        public Matrix(int rows, int columns, int minValue, int maxValue)
        {
            if (rows <= 0 || columns <= 0) throw new ArgumentException("Invalid matrix dimensions");
            Rows = rows;
            Columns = columns;
            Elements = GenerateRandomMatrix(minValue, maxValue);
        }

        public Matrix(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("Invalid file path");
            }

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length == 0)
            {
                throw new InvalidOperationException("File is empty");
            }

            Rows = lines.Length;
            Columns = lines[0].Split(',').Length;
            Elements = new double[Rows, Columns];

            for (int i = 0; i < Rows; i++)
            {
                string[] values = lines[i].Split(',');

                if (values.Length != Columns)
                {
                    throw new InvalidOperationException("Invalid matrix data in the file");
                }

                for (int j = 0; j < Columns; j++)
                {
                    if (!double.TryParse(values[j], out Elements[i, j]))
                    {
                        throw new InvalidOperationException("Invalid numeric value in the file");
                    }
                }
            }
        }

        public Matrix(double[,] elements)
        {
            Rows = elements.GetLength(0);
            Columns = elements.GetLength(1);
            Elements = Copy(elements);
        }

        public Matrix(Matrix matrix)
        {
            Rows = matrix.Rows;
            Columns = matrix.Columns;
            Elements = Copy(matrix.Elements);
        }

        private double[,] GenerateRandomMatrix(int minValue, int maxValue) 
        {
            if (maxValue < minValue)
            {
                throw new ArgumentException("Invalid min max values: max should be greater");
            }

            double[,] elements = new double[Rows, Columns];
            Random rand = new();
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    elements[i, j] = Math.Round(rand.NextDouble() * (maxValue - minValue) + minValue, 2);
                }
            }
            return elements;
        }

        public double[,] Copy(double[,] matrix)
        {
            double[,] result_matrix = new double[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    result_matrix[i, j] = matrix[i, j];
                }
            }

            return result_matrix;
        }

        public void WriteToFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("Invalid file path");
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        writer.Write(this[i, j]);
                        if (j < Columns - 1)
                        {
                            writer.Write(',');
                        }
                    }
                    writer.WriteLine();
                }
            }
        }

        //public void Transpose()
        //{
        //    double[,] result = new double[Columns, Rows];

        //    for (int i = 0; i < Rows; i++)
        //    {
        //        for (int j = 0; j < Columns; j++)
        //        {
        //            result[j, i] = this[i, j];
        //        }
        //    }
        //    Elements = result;
        //}

        //public void SwapRows(int rowIndex1, int rowIndex2)
        //{
        //    for (int i = 0; i < Columns; ++i)
        //    {
        //        (this[rowIndex2, i], this[rowIndex1, i]) = (this[rowIndex1, i], this[rowIndex2, i]);
        //    }
        //}


        public static Matrix CreateIdentityMatrix(int rows, int columns)
        {
            if (rows != columns)
            {
                throw new ArgumentException("Invalid matrix dimensions");
            }

            double[,] identityMatrix = new double[rows, columns];

            for (int i = 0; i < rows; ++i)
            {
                identityMatrix[i, i] = 1;
            }

            return new Matrix(identityMatrix);
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new InvalidOperationException("Matrix dimensions mismatch for addition");
            }

            Matrix result = new(a.Rows, a.Columns);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result.Elements[i, j] = a.Elements[i, j] + b.Elements[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new InvalidOperationException("Matrix dimensions mismatch for subtraction");
            }

            Matrix result = new(a.Rows, a.Columns);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result.Elements[i, j] = a.Elements[i, j] - b.Elements[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
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
                        result.Elements[i, j] += a.Elements[i, k] * b.Elements[k, j];
                    }
                }
            }

            return result;
        }

        public double this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= Rows || col < 0 || col >= Columns)
                {
                    throw new IndexOutOfRangeException("Invalid matrix indices");
                }

                return Elements[row, col];
            }
            set
            {
                if (row < 0 || row >= Rows || col < 0 || col >= Columns)
                {
                    throw new IndexOutOfRangeException("Invalid matrix indices");
                }

                Elements[row, col] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    sb.Append(this[i, j].ToString());
                    if (j < Columns - 1)
                        sb.Append(", ");
                }

                sb.AppendLine();
            }

            return sb.ToString( );
        }
    }
}
