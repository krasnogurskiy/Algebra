using System.Text;
using Linalg;
using Linalg.Interfaces;
using Linalg.Task4;
using System.Windows.Forms;

namespace UI
{
    public partial class LinAlgForm : Form
    {
        private Sle? sle;
        private ISolver solver;
        private SparseToTapeMatrixConverter converter;

        public LinAlgForm()
        {
            InitializeComponent();
        }

        private void UpdateMatrixDataGridView(Matrix matrix)
        {
            int rows = matrix.Rows;
            int columns = matrix.Columns;

            MatrixGridView.RowCount = rows;
            MatrixGridView.ColumnCount = columns;

            MatrixGridView.CellValueChanged -= MatrixGridView_CellValueChanged!;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    MatrixGridView.Rows[i].Cells[j].Value = matrix[i, j].ToString("F2");
                }
            }
            MatrixGridView.CellValueChanged += MatrixGridView_CellValueChanged!;

            MatrixGridView.ClearSelection();
        }

        private void UpdateXDataGridView(Vector vector)
        {
            int size = vector.Size;

            XGridView.RowCount = size;
            XGridView.ColumnCount = 1;

            for (int i = 0; i < size; i++)
            {
                XGridView.Rows[i].Cells[0].Value = vector[i].ToString("F2");
            }

            XGridView.ClearSelection();
        }

        private void UpdateBDataGridView(Vector vector)
        {
            int size = vector.Size;

            BGridView.RowCount = size;
            BGridView.ColumnCount = 1;

            for (int i = 0; i < size; i++)
            {
                BGridView.Rows[i].Cells[0].Value = vector[i].ToString("F2");
            }

            BGridView.ClearSelection();
        }

        private void CreateEquitionButton_Click(object sender, EventArgs e)
        {
            int rows = (int)DimRowsNumericUpDown.Value;
            int columns = (int)DimColumnsNumericUpDown.Value;
            int size = columns;
            Matrix A;
            Vector X, B;
            try
            {
                if (RandGenCheckBox.Checked)
                {
                    int min = (int)RandGenMinNumericUpDown.Value;
                    int max = (int)RandGenMaxNumericUpDown.Value;
                    A = new Matrix(rows, columns, min, max);
                    X = new Vector(size);
                    B = new Vector(size, min, max);
                }
                else
                {
                    A = new Matrix(rows, columns);
                    X = new Vector(size);
                    B = new Vector(size);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sle = new Sle(A, X, B);
            UpdateMatrixDataGridView(A);
            UpdateXDataGridView(X);
            UpdateBDataGridView(B);
            ConvertButton.Enabled = true;
            ConvertButton.Enabled = true;
            findPathButton.Enabled = true;
            diameterButton.Enabled = true;

        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    sle = SleFileHandler.ReadFromFile(filePath);
                    UpdateMatrixDataGridView(sle.A);
                    UpdateXDataGridView(sle.X);
                    UpdateBDataGridView(sle.B);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ConvertButton.Enabled = true;
            findPathButton.Enabled = true;
            diameterButton.Enabled = true;
        }

        private void WriteFileButton_Click(object sender, EventArgs e)
        {
            if (sle is null)
            {
                MessageBox.Show($"Linear equition is not initialized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    SleFileHandler.WriteToFile(filePath, sle);
                    MessageBox.Show("File written successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MatrixGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string s = String.Empty;
            try
            {
                s = MatrixGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                sle.A[e.RowIndex, e.ColumnIndex] = double.Parse(s);
            }
            catch (FormatException)
            {
                MessageBox.Show($"{s} is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MatrixGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = sle.A[e.RowIndex, e.ColumnIndex].ToString("F2");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"Cell can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MatrixGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = sle.A[e.RowIndex, e.ColumnIndex].ToString("F2");
            }
        }

        private void BGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string s = String.Empty;
            try
            {
                s = BGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                sle.B[e.RowIndex] = double.Parse(s);
            }
            catch (FormatException)
            {
                MessageBox.Show($"{s} is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = sle.B[e.RowIndex].ToString("F2");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"Cell can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = sle.B[e.RowIndex].ToString("F2");
            }
        }



        private void ConvertButton_Click(object sender, EventArgs e)
        {
            //converter = new SparseToTapeMatrixConverter(sle.A);
            //sle.A = converter.ConvertMatrix();
            //UpdateMatrixDataGridView(sle.A);
            //MethodLabel.Text = "Method: Convert";

            if (YesRadioButton.Checked)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                            {
                                converter = new SparseToTapeMatrixConverter(sle.A, writer);
                                sle.A = converter.ConvertMatrix();
                            }

                            MessageBox.Show("Results saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show($"Error saving results: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error solving sytem: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                UpdateMatrixDataGridView(sle.A);
            }
            else if (NoRadioButton.Checked)
            {
                try
                {
                    converter = new SparseToTapeMatrixConverter(sle.A);
                    sle.A = converter.ConvertMatrix();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error converting sytem: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateMatrixDataGridView(sle.A);
            }
        }

        private void diameterButton_Click(object sender, EventArgs e)
        {
            converter = new SparseToTapeMatrixConverter(sle.A);
            converter.CalcDiametr();
            var d = converter.Diametr;
            diameterLabel.Text = $"Diameter: {d}";
        }

        private void findPathButton_Click(object sender, EventArgs e)
        {
            int fromVeretex = -1;
            int toVeretex = -1;
            int distance = -1; 
            converter = new SparseToTapeMatrixConverter(sle.A);
            try
            {
                fromVeretex = int.Parse(fromTextBox.Text);
                toVeretex = int.Parse(toTextBox.Text);
                distance = int.Parse(distanceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Wrong data in textbox", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            try
            {
                Graph g = new Graph(converter.Matrix.Elements);
                g.FindAllPaths(fromVeretex - 1, toVeretex - 1);
                
                pathExistsResultLabel.Text = g.Npaths.Contains(distance) ? "Yes" : "No";

                StringBuilder sb = new StringBuilder();
                foreach (var path in g.paths)
                {
                    if (path.Count - 1 == distance)
                    {
                        foreach (var elem in path)
                        {
                            sb.Append($"{elem + 1} -> ");
                        }
                    }
                }

                if (pathExistsResultLabel.Text == "Yes")
                {
                    MessageBox.Show(sb.ToString(), "Path");
                }
            }
            catch
            {
                MessageBox.Show("Wrong number of vertex", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
