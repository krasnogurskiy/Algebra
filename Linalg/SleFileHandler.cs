namespace Linalg
{
    public static class SleFileHandler
    {
        public static Sle ReadFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length == 0)
            {
                throw new InvalidOperationException("File is empty");
            }

            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;

            Matrix matrix = new Matrix(rows, columns);
            Vector x = new Vector(columns);
            Vector b = new Vector(columns);

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                string[] matrixValues = values[0].Split(",");

                //if (values.Length != columns - 1)
                //{
                //    throw new InvalidOperationException("Invalid data in the file");
                //}

                for (int j = 0; j < columns; j++)
                {
                    try
                    {
                        matrix[i, j] = double.Parse(matrixValues[j]);
                    }
                    catch
                    {
                        throw new InvalidOperationException("Invalid numeric value in the file");
                    }
                }

                try
                {
                    x[i] = double.Parse(values[1]);
                    b[i] = double.Parse(values[2]);
                }
                catch
                {
                    throw new InvalidOperationException("Invalid numeric value in the file");
                }
            }
            return new Sle(matrix, x, b);
        }

        public static void WriteToFile(string filePath, Sle sle)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < sle.A.Rows; i++)
                {
                    for (int j = 0; j < sle.A.Columns; j++)
                    {
                        writer.Write(sle.A[i, j]);
                        if (j == sle.A.Columns - 1)
                        {
                            writer.Write(';');
                            writer.Write(sle.X[i]);
                            writer.Write(';');
                            writer.Write(sle.B[i]);
                        }
                        else
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}
