namespace UI
{
    partial class LinAlgForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MatrixGridView = new DataGridView();
            XGridView = new DataGridView();
            BGridView = new DataGridView();
            MatrixLabel = new Label();
            XLabel = new Label();
            BLabel = new Label();
            RandGenMaxNumericUpDown = new NumericUpDown();
            RandGenMinNumericUpDown = new NumericUpDown();
            RandGenCheckBox = new CheckBox();
            RandomGenGroupBox = new GroupBox();
            RandGenMaxLabel = new Label();
            RandGenMinLabel = new Label();
            DimensionalityGroupBox = new GroupBox();
            DimColumnLabel = new Label();
            DimRowsNumericUpDown = new NumericUpDown();
            DimRowLabel = new Label();
            DimColumnsNumericUpDown = new NumericUpDown();
            ReadFileButton = new Button();
            WriteFileButton = new Button();
            WorkWithFileGroupBox = new GroupBox();
            CreateEquitionButton = new Button();
            SolvingGroupBox = new GroupBox();
            shortPathGroupBox = new GroupBox();
            pathExistsResultLabel = new Label();
            distanceTextBox = new TextBox();
            distanceLabel = new Label();
            pathLabel = new Label();
            toLabel = new Label();
            toTextBox = new TextBox();
            fromLabel = new Label();
            fromTextBox = new TextBox();
            findPathButton = new Button();
            diameterButton = new Button();
            diameterLabel = new Label();
            ConvertButton = new Button();
            convertSparseMatrixLabel = new Label();
            SolvingRadioButtonsGroupBox = new GroupBox();
            YesRadioButton = new RadioButton();
            NoRadioButton = new RadioButton();
            SolvingLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)MatrixGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)XGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RandGenMaxNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RandGenMinNumericUpDown).BeginInit();
            RandomGenGroupBox.SuspendLayout();
            DimensionalityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DimRowsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DimColumnsNumericUpDown).BeginInit();
            WorkWithFileGroupBox.SuspendLayout();
            SolvingGroupBox.SuspendLayout();
            shortPathGroupBox.SuspendLayout();
            SolvingRadioButtonsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MatrixGridView
            // 
            MatrixGridView.AllowUserToAddRows = false;
            MatrixGridView.AllowUserToDeleteRows = false;
            MatrixGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MatrixGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            MatrixGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MatrixGridView.ColumnHeadersVisible = false;
            MatrixGridView.Location = new Point(137, 64);
            MatrixGridView.Margin = new Padding(2);
            MatrixGridView.Name = "MatrixGridView";
            MatrixGridView.RowHeadersVisible = false;
            MatrixGridView.RowHeadersWidth = 82;
            MatrixGridView.Size = new Size(320, 249);
            MatrixGridView.TabIndex = 0;
            MatrixGridView.CellValueChanged += MatrixGridView_CellValueChanged;
            // 
            // XGridView
            // 
            XGridView.AllowUserToAddRows = false;
            XGridView.AllowUserToDeleteRows = false;
            XGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            XGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            XGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            XGridView.ColumnHeadersVisible = false;
            XGridView.Location = new Point(547, 64);
            XGridView.Margin = new Padding(2);
            XGridView.Name = "XGridView";
            XGridView.ReadOnly = true;
            XGridView.RowHeadersVisible = false;
            XGridView.RowHeadersWidth = 82;
            XGridView.Size = new Size(66, 249);
            XGridView.TabIndex = 1;
            // 
            // BGridView
            // 
            BGridView.AllowUserToAddRows = false;
            BGridView.AllowUserToDeleteRows = false;
            BGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BGridView.ColumnHeadersVisible = false;
            BGridView.Location = new Point(690, 64);
            BGridView.Margin = new Padding(2);
            BGridView.Name = "BGridView";
            BGridView.RowHeadersVisible = false;
            BGridView.RowHeadersWidth = 82;
            BGridView.Size = new Size(66, 249);
            BGridView.TabIndex = 2;
            BGridView.CellValueChanged += BGridView_CellValueChanged;
            // 
            // MatrixLabel
            // 
            MatrixLabel.AutoSize = true;
            MatrixLabel.Font = new Font("Segoe UI", 15F);
            MatrixLabel.Location = new Point(102, 169);
            MatrixLabel.Margin = new Padding(2, 0, 2, 0);
            MatrixLabel.Name = "MatrixLabel";
            MatrixLabel.Size = new Size(31, 35);
            MatrixLabel.TabIndex = 3;
            MatrixLabel.Text = "A";
            // 
            // XLabel
            // 
            XLabel.AutoSize = true;
            XLabel.Font = new Font("Segoe UI", 15F);
            XLabel.Location = new Point(514, 169);
            XLabel.Margin = new Padding(2, 0, 2, 0);
            XLabel.Name = "XLabel";
            XLabel.Size = new Size(30, 35);
            XLabel.TabIndex = 4;
            XLabel.Text = "X";
            // 
            // BLabel
            // 
            BLabel.AutoSize = true;
            BLabel.Font = new Font("Segoe UI", 15F);
            BLabel.Location = new Point(658, 169);
            BLabel.Margin = new Padding(2, 0, 2, 0);
            BLabel.Name = "BLabel";
            BLabel.Size = new Size(30, 35);
            BLabel.TabIndex = 5;
            BLabel.Text = "b";
            // 
            // RandGenMaxNumericUpDown
            // 
            RandGenMaxNumericUpDown.Location = new Point(213, 25);
            RandGenMaxNumericUpDown.Margin = new Padding(2);
            RandGenMaxNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            RandGenMaxNumericUpDown.Name = "RandGenMaxNumericUpDown";
            RandGenMaxNumericUpDown.Size = new Size(62, 27);
            RandGenMaxNumericUpDown.TabIndex = 7;
            // 
            // RandGenMinNumericUpDown
            // 
            RandGenMinNumericUpDown.Location = new Point(82, 24);
            RandGenMinNumericUpDown.Margin = new Padding(2);
            RandGenMinNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            RandGenMinNumericUpDown.Name = "RandGenMinNumericUpDown";
            RandGenMinNumericUpDown.Size = new Size(62, 27);
            RandGenMinNumericUpDown.TabIndex = 8;
            // 
            // RandGenCheckBox
            // 
            RandGenCheckBox.AutoSize = true;
            RandGenCheckBox.Location = new Point(290, 27);
            RandGenCheckBox.Margin = new Padding(2);
            RandGenCheckBox.Name = "RandGenCheckBox";
            RandGenCheckBox.Size = new Size(50, 24);
            RandGenCheckBox.TabIndex = 10;
            RandGenCheckBox.Text = "On";
            RandGenCheckBox.UseVisualStyleBackColor = true;
            // 
            // RandomGenGroupBox
            // 
            RandomGenGroupBox.Controls.Add(RandGenMaxLabel);
            RandomGenGroupBox.Controls.Add(RandGenMinLabel);
            RandomGenGroupBox.Controls.Add(RandGenMinNumericUpDown);
            RandomGenGroupBox.Controls.Add(RandGenCheckBox);
            RandomGenGroupBox.Controls.Add(RandGenMaxNumericUpDown);
            RandomGenGroupBox.Location = new Point(457, 336);
            RandomGenGroupBox.Margin = new Padding(2);
            RandomGenGroupBox.Name = "RandomGenGroupBox";
            RandomGenGroupBox.Padding = new Padding(2);
            RandomGenGroupBox.Size = new Size(348, 74);
            RandomGenGroupBox.TabIndex = 11;
            RandomGenGroupBox.TabStop = false;
            RandomGenGroupBox.Text = "Random Generation";
            // 
            // RandGenMaxLabel
            // 
            RandGenMaxLabel.AutoSize = true;
            RandGenMaxLabel.Location = new Point(159, 25);
            RandGenMaxLabel.Margin = new Padding(2, 0, 2, 0);
            RandGenMaxLabel.Name = "RandGenMaxLabel";
            RandGenMaxLabel.Size = new Size(37, 20);
            RandGenMaxLabel.TabIndex = 12;
            RandGenMaxLabel.Text = "max";
            // 
            // RandGenMinLabel
            // 
            RandGenMinLabel.AutoSize = true;
            RandGenMinLabel.Location = new Point(28, 25);
            RandGenMinLabel.Margin = new Padding(2, 0, 2, 0);
            RandGenMinLabel.Name = "RandGenMinLabel";
            RandGenMinLabel.Size = new Size(34, 20);
            RandGenMinLabel.TabIndex = 11;
            RandGenMinLabel.Text = "min";
            // 
            // DimensionalityGroupBox
            // 
            DimensionalityGroupBox.Controls.Add(DimColumnLabel);
            DimensionalityGroupBox.Controls.Add(DimRowsNumericUpDown);
            DimensionalityGroupBox.Controls.Add(DimRowLabel);
            DimensionalityGroupBox.Controls.Add(DimColumnsNumericUpDown);
            DimensionalityGroupBox.Location = new Point(60, 336);
            DimensionalityGroupBox.Margin = new Padding(2);
            DimensionalityGroupBox.Name = "DimensionalityGroupBox";
            DimensionalityGroupBox.Padding = new Padding(2);
            DimensionalityGroupBox.Size = new Size(365, 70);
            DimensionalityGroupBox.TabIndex = 12;
            DimensionalityGroupBox.TabStop = false;
            // 
            // DimColumnLabel
            // 
            DimColumnLabel.AutoSize = true;
            DimColumnLabel.Location = new Point(183, 27);
            DimColumnLabel.Margin = new Padding(2, 0, 2, 0);
            DimColumnLabel.Name = "DimColumnLabel";
            DimColumnLabel.Size = new Size(66, 20);
            DimColumnLabel.TabIndex = 14;
            DimColumnLabel.Text = "Columns";
            // 
            // DimRowsNumericUpDown
            // 
            DimRowsNumericUpDown.Location = new Point(94, 25);
            DimRowsNumericUpDown.Margin = new Padding(2);
            DimRowsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DimRowsNumericUpDown.Name = "DimRowsNumericUpDown";
            DimRowsNumericUpDown.Size = new Size(62, 27);
            DimRowsNumericUpDown.TabIndex = 14;
            DimRowsNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DimRowLabel
            // 
            DimRowLabel.AutoSize = true;
            DimRowLabel.Location = new Point(17, 25);
            DimRowLabel.Margin = new Padding(2, 0, 2, 0);
            DimRowLabel.Name = "DimRowLabel";
            DimRowLabel.Size = new Size(44, 20);
            DimRowLabel.TabIndex = 13;
            DimRowLabel.Text = "Rows";
            // 
            // DimColumnsNumericUpDown
            // 
            DimColumnsNumericUpDown.Location = new Point(273, 26);
            DimColumnsNumericUpDown.Margin = new Padding(2);
            DimColumnsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DimColumnsNumericUpDown.Name = "DimColumnsNumericUpDown";
            DimColumnsNumericUpDown.Size = new Size(62, 27);
            DimColumnsNumericUpDown.TabIndex = 13;
            DimColumnsNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ReadFileButton
            // 
            ReadFileButton.BackColor = Color.MintCream;
            ReadFileButton.Location = new Point(30, 24);
            ReadFileButton.Margin = new Padding(2);
            ReadFileButton.Name = "ReadFileButton";
            ReadFileButton.Size = new Size(92, 29);
            ReadFileButton.TabIndex = 13;
            ReadFileButton.Text = "Read";
            ReadFileButton.UseVisualStyleBackColor = false;
            ReadFileButton.Click += ReadFileButton_Click;
            // 
            // WriteFileButton
            // 
            WriteFileButton.BackColor = Color.MintCream;
            WriteFileButton.Cursor = Cursors.SizeAll;
            WriteFileButton.Location = new Point(30, 66);
            WriteFileButton.Margin = new Padding(2);
            WriteFileButton.Name = "WriteFileButton";
            WriteFileButton.Size = new Size(92, 29);
            WriteFileButton.TabIndex = 14;
            WriteFileButton.Text = "Write";
            WriteFileButton.UseVisualStyleBackColor = false;
            WriteFileButton.Click += WriteFileButton_Click;
            // 
            // WorkWithFileGroupBox
            // 
            WorkWithFileGroupBox.Controls.Add(WriteFileButton);
            WorkWithFileGroupBox.Controls.Add(ReadFileButton);
            WorkWithFileGroupBox.Location = new Point(796, 199);
            WorkWithFileGroupBox.Margin = new Padding(2);
            WorkWithFileGroupBox.Name = "WorkWithFileGroupBox";
            WorkWithFileGroupBox.Padding = new Padding(2);
            WorkWithFileGroupBox.Size = new Size(150, 114);
            WorkWithFileGroupBox.TabIndex = 15;
            WorkWithFileGroupBox.TabStop = false;
            // 
            // CreateEquitionButton
            // 
            CreateEquitionButton.BackColor = Color.MintCream;
            CreateEquitionButton.Location = new Point(816, 377);
            CreateEquitionButton.Margin = new Padding(2);
            CreateEquitionButton.Name = "CreateEquitionButton";
            CreateEquitionButton.Size = new Size(137, 29);
            CreateEquitionButton.TabIndex = 16;
            CreateEquitionButton.Text = "Generate";
            CreateEquitionButton.UseVisualStyleBackColor = false;
            CreateEquitionButton.Click += CreateEquitionButton_Click;
            // 
            // SolvingGroupBox
            // 
            SolvingGroupBox.Controls.Add(shortPathGroupBox);
            SolvingGroupBox.Controls.Add(diameterButton);
            SolvingGroupBox.Controls.Add(diameterLabel);
            SolvingGroupBox.Controls.Add(ConvertButton);
            SolvingGroupBox.Controls.Add(convertSparseMatrixLabel);
            SolvingGroupBox.Controls.Add(SolvingRadioButtonsGroupBox);
            SolvingGroupBox.Controls.Add(SolvingLabel);
            SolvingGroupBox.Location = new Point(23, 410);
            SolvingGroupBox.Margin = new Padding(2);
            SolvingGroupBox.Name = "SolvingGroupBox";
            SolvingGroupBox.Padding = new Padding(2);
            SolvingGroupBox.Size = new Size(973, 183);
            SolvingGroupBox.TabIndex = 26;
            SolvingGroupBox.TabStop = false;
            // 
            // shortPathGroupBox
            // 
            shortPathGroupBox.Controls.Add(pathExistsResultLabel);
            shortPathGroupBox.Controls.Add(distanceTextBox);
            shortPathGroupBox.Controls.Add(distanceLabel);
            shortPathGroupBox.Controls.Add(pathLabel);
            shortPathGroupBox.Controls.Add(toLabel);
            shortPathGroupBox.Controls.Add(toTextBox);
            shortPathGroupBox.Controls.Add(fromLabel);
            shortPathGroupBox.Controls.Add(fromTextBox);
            shortPathGroupBox.Controls.Add(findPathButton);
            shortPathGroupBox.Location = new Point(521, 51);
            shortPathGroupBox.Margin = new Padding(2);
            shortPathGroupBox.Name = "shortPathGroupBox";
            shortPathGroupBox.Padding = new Padding(2);
            shortPathGroupBox.Size = new Size(385, 83);
            shortPathGroupBox.TabIndex = 20;
            shortPathGroupBox.TabStop = false;
            shortPathGroupBox.Text = "Shortest path";
            // 
            // pathExistsResultLabel
            // 
            pathExistsResultLabel.AutoSize = true;
            pathExistsResultLabel.Location = new Point(306, 44);
            pathExistsResultLabel.Margin = new Padding(2, 0, 2, 0);
            pathExistsResultLabel.Name = "pathExistsResultLabel";
            pathExistsResultLabel.Size = new Size(0, 20);
            pathExistsResultLabel.TabIndex = 22;
            // 
            // distanceTextBox
            // 
            distanceTextBox.Location = new Point(255, 44);
            distanceTextBox.Margin = new Padding(2);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(29, 27);
            distanceTextBox.TabIndex = 21;
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Location = new Point(252, 12);
            distanceLabel.Margin = new Padding(2, 0, 2, 0);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new Size(35, 20);
            distanceLabel.TabIndex = 20;
            distanceLabel.Text = "Dist";
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(306, 12);
            pathLabel.Margin = new Padding(2, 0, 2, 0);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(88, 20);
            pathLabel.TabIndex = 17;
            pathLabel.Text = "Path exists? ";
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Location = new Point(212, 12);
            toLabel.Margin = new Padding(2, 0, 2, 0);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(25, 20);
            toLabel.TabIndex = 19;
            toLabel.Text = "To";
            // 
            // toTextBox
            // 
            toTextBox.Location = new Point(209, 44);
            toTextBox.Margin = new Padding(2);
            toTextBox.Name = "toTextBox";
            toTextBox.Size = new Size(29, 27);
            toTextBox.TabIndex = 16;
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Location = new Point(146, 12);
            fromLabel.Margin = new Padding(2, 0, 2, 0);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(43, 20);
            fromLabel.TabIndex = 18;
            fromLabel.Text = "From";
            // 
            // fromTextBox
            // 
            fromTextBox.Location = new Point(151, 44);
            fromTextBox.Margin = new Padding(2);
            fromTextBox.Name = "fromTextBox";
            fromTextBox.Size = new Size(29, 27);
            fromTextBox.TabIndex = 15;
            // 
            // findPathButton
            // 
            findPathButton.BackColor = Color.Honeydew;
            findPathButton.Enabled = false;
            findPathButton.Location = new Point(26, 32);
            findPathButton.Margin = new Padding(2);
            findPathButton.Name = "findPathButton";
            findPathButton.Size = new Size(92, 29);
            findPathButton.TabIndex = 14;
            findPathButton.Text = "Find path";
            findPathButton.UseVisualStyleBackColor = false;
            findPathButton.Click += findPathButton_Click;
            // 
            // diameterButton
            // 
            diameterButton.BackColor = Color.Honeydew;
            diameterButton.Enabled = false;
            diameterButton.Location = new Point(18, 105);
            diameterButton.Margin = new Padding(2);
            diameterButton.Name = "diameterButton";
            diameterButton.Size = new Size(110, 29);
            diameterButton.TabIndex = 13;
            diameterButton.Text = "Calc diameter";
            diameterButton.UseVisualStyleBackColor = false;
            diameterButton.Click += diameterButton_Click;
            // 
            // diameterLabel
            // 
            diameterLabel.AutoSize = true;
            diameterLabel.Location = new Point(201, 114);
            diameterLabel.Margin = new Padding(2, 0, 2, 0);
            diameterLabel.Name = "diameterLabel";
            diameterLabel.Size = new Size(78, 20);
            diameterLabel.TabIndex = 12;
            diameterLabel.Text = "Diameter: ";
            // 
            // ConvertButton
            // 
            ConvertButton.BackColor = Color.Honeydew;
            ConvertButton.Enabled = false;
            ConvertButton.Location = new Point(201, 70);
            ConvertButton.Margin = new Padding(2);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(92, 29);
            ConvertButton.TabIndex = 11;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = false;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // convertSparseMatrixLabel
            // 
            convertSparseMatrixLabel.AutoSize = true;
            convertSparseMatrixLabel.Location = new Point(13, 75);
            convertSparseMatrixLabel.Margin = new Padding(2, 0, 2, 0);
            convertSparseMatrixLabel.Name = "convertSparseMatrixLabel";
            convertSparseMatrixLabel.Size = new Size(161, 20);
            convertSparseMatrixLabel.TabIndex = 10;
            convertSparseMatrixLabel.Text = "Convert to tape matrix:";
            // 
            // SolvingRadioButtonsGroupBox
            // 
            SolvingRadioButtonsGroupBox.Controls.Add(YesRadioButton);
            SolvingRadioButtonsGroupBox.Controls.Add(NoRadioButton);
            SolvingRadioButtonsGroupBox.Location = new Point(74, 4);
            SolvingRadioButtonsGroupBox.Margin = new Padding(2);
            SolvingRadioButtonsGroupBox.Name = "SolvingRadioButtonsGroupBox";
            SolvingRadioButtonsGroupBox.Padding = new Padding(2);
            SolvingRadioButtonsGroupBox.Size = new Size(131, 38);
            SolvingRadioButtonsGroupBox.TabIndex = 3;
            SolvingRadioButtonsGroupBox.TabStop = false;
            // 
            // YesRadioButton
            // 
            YesRadioButton.AutoSize = true;
            YesRadioButton.Location = new Point(11, 14);
            YesRadioButton.Margin = new Padding(2);
            YesRadioButton.Name = "YesRadioButton";
            YesRadioButton.Size = new Size(51, 24);
            YesRadioButton.TabIndex = 1;
            YesRadioButton.Text = "Yes";
            YesRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoRadioButton
            // 
            NoRadioButton.AutoSize = true;
            NoRadioButton.Checked = true;
            NoRadioButton.Location = new Point(73, 14);
            NoRadioButton.Margin = new Padding(2);
            NoRadioButton.Name = "NoRadioButton";
            NoRadioButton.Size = new Size(50, 24);
            NoRadioButton.TabIndex = 2;
            NoRadioButton.TabStop = true;
            NoRadioButton.Text = "No";
            NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // SolvingLabel
            // 
            SolvingLabel.AutoSize = true;
            SolvingLabel.Location = new Point(14, 22);
            SolvingLabel.Margin = new Padding(2, 0, 2, 0);
            SolvingLabel.Name = "SolvingLabel";
            SolvingLabel.Size = new Size(52, 20);
            SolvingLabel.TabIndex = 0;
            SolvingLabel.Text = "Steps: ";
            // 
            // LinAlgForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1035, 604);
            Controls.Add(SolvingGroupBox);
            Controls.Add(CreateEquitionButton);
            Controls.Add(WorkWithFileGroupBox);
            Controls.Add(DimensionalityGroupBox);
            Controls.Add(RandomGenGroupBox);
            Controls.Add(BLabel);
            Controls.Add(XLabel);
            Controls.Add(MatrixLabel);
            Controls.Add(BGridView);
            Controls.Add(XGridView);
            Controls.Add(MatrixGridView);
            Margin = new Padding(2);
            Name = "LinAlgForm";
            Text = "Linear Algebra";
            ((System.ComponentModel.ISupportInitialize)MatrixGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)XGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)BGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)RandGenMaxNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)RandGenMinNumericUpDown).EndInit();
            RandomGenGroupBox.ResumeLayout(false);
            RandomGenGroupBox.PerformLayout();
            DimensionalityGroupBox.ResumeLayout(false);
            DimensionalityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DimRowsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)DimColumnsNumericUpDown).EndInit();
            WorkWithFileGroupBox.ResumeLayout(false);
            SolvingGroupBox.ResumeLayout(false);
            SolvingGroupBox.PerformLayout();
            shortPathGroupBox.ResumeLayout(false);
            shortPathGroupBox.PerformLayout();
            SolvingRadioButtonsGroupBox.ResumeLayout(false);
            SolvingRadioButtonsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MatrixGridView;
        private DataGridView XGridView;
        private DataGridView BGridView;
        private Label MatrixLabel;
        private Label XLabel;
        private Label BLabel;
        private NumericUpDown RandGenMaxNumericUpDown;
        private NumericUpDown RandGenMinNumericUpDown;
        private CheckBox RandGenCheckBox;
        private GroupBox RandomGenGroupBox;
        private Label RandGenMaxLabel;
        private Label RandGenMinLabel;
        private GroupBox DimensionalityGroupBox;
        private Label DimColumnLabel;
        private NumericUpDown DimRowsNumericUpDown;
        private Label DimRowLabel;
        private NumericUpDown DimColumnsNumericUpDown;
        private Button ReadFileButton;
        private Button WriteFileButton;
        private GroupBox WorkWithFileGroupBox;
        private Button CreateEquitionButton;
        private GroupBox SolvingGroupBox;
        private Label SolvingLabel;
        private RadioButton YesRadioButton;
        private RadioButton NoRadioButton;
        private GroupBox SolvingRadioButtonsGroupBox;
        private Button ConvertButton;
        private Label convertSparseMatrixLabel;
        private Button diameterButton;
        private Label diameterLabel;
        private Button findPathButton;
        private GroupBox shortPathGroupBox;
        private Label pathLabel;
        private Label toLabel;
        private TextBox toTextBox;
        private Label fromLabel;
        private TextBox fromTextBox;
        private Label distanceLabel;
        private Label pathExistsResultLabel;
        private TextBox distanceTextBox;
    }
}
