using Linalg.Interfaces;
using System.Text;

namespace Linalg
{
    public class Sle
    {
        public Matrix A { get; set; }
        public Vector X { get; set; }
        public Vector B { get; set; }


        public ISolver Solver { get; set; }

        public Sle()
        {
            A = new Matrix();
            X = new Vector();
            B = new Vector();
        }

        public Sle(Matrix a_, Vector x_, Vector b_)
        {
            if (a_.Columns != b_.Size || a_.Columns != x_.Size)
            {
                throw new ArgumentException("Invalid dimensions for the system of linear equations");
            }

            A = new Matrix(a_);
            X = new Vector(x_);
            B = new Vector(b_);
        }

        public Sle(Matrix a_, Vector b_)
        {
            if (a_.Columns != b_.Size)
            {
                throw new ArgumentException("Invalid dimensions for the system of linear equations");
            }

            A = new Matrix(a_);
            B = new Vector(b_);
            X = new Vector(b_.Size);
        }

        public Sle(string matrixFilePath, string vectorFilePath)
        {
            A = new Matrix(matrixFilePath);
            B = new Vector(vectorFilePath);
            X = new Vector(B.Size);
        }

        public Sle(string filePath)
        {
            Sle sle = SleFileHandler.ReadFromFile(filePath);
            A = sle.A;
            X = sle.X;
            B = sle.B;
        }

        public void WriteTofile(string filePath)
        {
            SleFileHandler.WriteToFile(filePath, this);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Columns; j++)
                {
                    result.Append(A[i, j].ToString("F2"));

                    if (j == A.Columns - 1)
                    {
                        result.Append(';');
                        result.Append(X[i].ToString("F2"));
                        result.Append(';');
                        result.Append(B[i].ToString("F2"));
                    }
                    else
                    {
                        result.Append(",");
                    }
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
