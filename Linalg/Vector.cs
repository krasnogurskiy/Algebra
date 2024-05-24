using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Linalg
{
    public class Vector
    {
        public List<double> Elements { get; private set; }

        public int Size => Elements.Count;

        public Vector()
        {
            Elements = new List<double>();
        }

        public Vector(IEnumerable<double> elements)
        {
            Elements = new List<double>(elements);
        }

        public Vector(Vector vector)
        {
            Elements = new List<double>(vector.Elements);
        }


        public Vector(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Invalid vector size");
            }
            Elements = new List<double>(Enumerable.Repeat(0.0, size));
        }

        public Vector(int size, int minValue, int maxValue)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Invalid vector size");
            }
            Elements = GenerateRandomVector(size, minValue, maxValue);
        }

        public Vector(string filePath)
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

            Elements = lines[0].Split(',')
                .Select(str => double.TryParse(str, out double result) ? result : throw new FormatException("Invalid format in file"))
                .ToList();
        }

        private List<double> GenerateRandomVector(int size, int minValue, int maxValue)
        {
            if (maxValue < minValue)
            {
                throw new ArgumentException("Invalid vector dimensions");
            }
            List<double> elements = new List<double>(size);
            Random rand = new Random();
            for (int i = 0; i < size; ++i)
            {
                elements.Add(Math.Round(rand.NextDouble() * (maxValue - minValue) + minValue, 2));
            }
            return elements;
        }

        public void WriteToFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("Invalid file path");
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < Size; i++)
                {
                    writer.Write(Elements[i]);
                    if (i < Size - 1)
                    {
                        writer.Write(',');
                    }
                }
            }
        }

        public void SwapElements(int index1, int index2)
        {
            double temp = Elements[index1];
            Elements[index1] = Elements[index2];
            Elements[index2] = temp;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            if (a.Size != b.Size)
            {
                throw new InvalidOperationException("Vector dimensions mismatch for addition");
            }

            List<double> resultElements = new List<double>(a.Size);

            for (int i = 0; i < a.Size; i++)
            {
                resultElements.Add(a.Elements[i] + b.Elements[i]);
            }

            return new Vector(resultElements);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            if (a.Size != b.Size)
            {
                throw new InvalidOperationException("Vector dimensions mismatch for subtraction");
            }

            List<double> resultElements = new List<double>(a.Size);

            for (int i = 0; i < a.Size; i++)
            {
                resultElements.Add(a.Elements[i] - b.Elements[i]);
            }

            return new Vector(resultElements);
        }

        public static Vector operator *(double scalar, Vector v)
        {
            List<double> resultElements = v.Elements.Select(x => x * scalar).ToList();
            return new Vector(resultElements);
        }

        public static Vector operator *(Vector v, double scalar)
        {
            return scalar * v;
        }

        public static Vector operator *(Matrix matrix, Vector vector)
        {
            if (matrix.Columns != vector.Size)
            {
                throw new InvalidOperationException("Invalid matrix and vector dimensions for multiplication");
            }

            List<double> resultElements = new List<double>(matrix.Rows);

            for (int i = 0; i < matrix.Rows; i++)
            {
                double sum = 0.0;
                for (int j = 0; j < matrix.Columns; j++)
                {
                    sum += matrix.Elements[i, j] * vector.Elements[j];
                }
                resultElements.Add(sum);
            }

            return new Vector(resultElements);
        }

        public static Vector operator *(Vector vector, Matrix matrix)
        {
            if (vector.Size != matrix.Rows)
            {
                throw new InvalidOperationException("Invalid vector and matrix dimensions for multiplication");
            }

            List<double> resultElements = new List<double>(matrix.Columns);

            for (int i = 0; i < matrix.Columns; i++)
            {
                double sum = 0.0;
                for (int j = 0; j < vector.Size; j++)
                {
                    sum += vector.Elements[j] * matrix.Elements[j, i];
                }
                resultElements.Add(sum);
            }

            return new Vector(resultElements);
        }

        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= Size)
                {
                    throw new IndexOutOfRangeException("Invalid vector index");
                }

                return Elements[index];
            }
            set
            {
                if (index < 0 || index >= Size)
                {
                    throw new IndexOutOfRangeException("Invalid vector index");
                }

                Elements[index] = value;
            }
        }

        public void Append(double element)
        {
            Elements.Add(element);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Size; i++)
            {
                sb.Append(Elements[i].ToString());
                if (i < Size - 1)
                    sb.Append(", ");
            }

            return sb.ToString();
        }
    }
}
