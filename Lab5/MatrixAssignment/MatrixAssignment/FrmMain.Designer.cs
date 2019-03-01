namespace MatrixAssignment
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMatrixA = new System.Windows.Forms.Label();
            this.LblMaitrixB = new System.Windows.Forms.Label();
            this.LblMatrixC = new System.Windows.Forms.Label();
            this.LblMatrixAText = new System.Windows.Forms.Label();
            this.LblMatrixBText = new System.Windows.Forms.Label();
            this.LblMatrixCText = new System.Windows.Forms.Label();
            this.LblRows = new System.Windows.Forms.Label();
            this.LblCols = new System.Windows.Forms.Label();
            this.BtnMakeMatrixB = new System.Windows.Forms.Button();
            this.LblMakeMatrixA = new System.Windows.Forms.Button();
            this.TxtMatrixBCols = new System.Windows.Forms.TextBox();
            this.TxtMatrixACols = new System.Windows.Forms.TextBox();
            this.TxtMatrixBRows = new System.Windows.Forms.TextBox();
            this.TxtMatrixARows = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSubstract = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.rdbMultiply = new System.Windows.Forms.RadioButton();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnClearMatrix = new System.Windows.Forms.Button();
            this.BtnMakeBIdentity = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMatrixA
            // 
            this.LblMatrixA.AutoSize = true;
            this.LblMatrixA.Location = new System.Drawing.Point(12, 18);
            this.LblMatrixA.Name = "LblMatrixA";
            this.LblMatrixA.Size = new System.Drawing.Size(58, 17);
            this.LblMatrixA.TabIndex = 0;
            this.LblMatrixA.Text = "Matrix A";
            // 
            // LblMaitrixB
            // 
            this.LblMaitrixB.AutoSize = true;
            this.LblMaitrixB.Location = new System.Drawing.Point(177, 18);
            this.LblMaitrixB.Name = "LblMaitrixB";
            this.LblMaitrixB.Size = new System.Drawing.Size(58, 17);
            this.LblMaitrixB.TabIndex = 1;
            this.LblMaitrixB.Text = "Matrix B";
            // 
            // LblMatrixC
            // 
            this.LblMatrixC.AutoSize = true;
            this.LblMatrixC.Location = new System.Drawing.Point(346, 18);
            this.LblMatrixC.Name = "LblMatrixC";
            this.LblMatrixC.Size = new System.Drawing.Size(58, 17);
            this.LblMatrixC.TabIndex = 2;
            this.LblMatrixC.Text = "Matrix C";
            // 
            // LblMatrixAText
            // 
            this.LblMatrixAText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMatrixAText.Location = new System.Drawing.Point(12, 51);
            this.LblMatrixAText.Name = "LblMatrixAText";
            this.LblMatrixAText.Size = new System.Drawing.Size(150, 150);
            this.LblMatrixAText.TabIndex = 3;
            // 
            // LblMatrixBText
            // 
            this.LblMatrixBText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMatrixBText.Location = new System.Drawing.Point(180, 51);
            this.LblMatrixBText.Name = "LblMatrixBText";
            this.LblMatrixBText.Size = new System.Drawing.Size(150, 150);
            this.LblMatrixBText.TabIndex = 4;
            // 
            // LblMatrixCText
            // 
            this.LblMatrixCText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMatrixCText.Location = new System.Drawing.Point(349, 51);
            this.LblMatrixCText.Name = "LblMatrixCText";
            this.LblMatrixCText.Size = new System.Drawing.Size(150, 150);
            this.LblMatrixCText.TabIndex = 5;
            // 
            // LblRows
            // 
            this.LblRows.AutoSize = true;
            this.LblRows.Location = new System.Drawing.Point(153, 218);
            this.LblRows.Name = "LblRows";
            this.LblRows.Size = new System.Drawing.Size(42, 17);
            this.LblRows.TabIndex = 6;
            this.LblRows.Text = "Rows";
            // 
            // LblCols
            // 
            this.LblCols.AutoSize = true;
            this.LblCols.Location = new System.Drawing.Point(330, 218);
            this.LblCols.Name = "LblCols";
            this.LblCols.Size = new System.Drawing.Size(35, 17);
            this.LblCols.TabIndex = 7;
            this.LblCols.Text = "Cols";
            // 
            // BtnMakeMatrixB
            // 
            this.BtnMakeMatrixB.Location = new System.Drawing.Point(12, 277);
            this.BtnMakeMatrixB.Name = "BtnMakeMatrixB";
            this.BtnMakeMatrixB.Size = new System.Drawing.Size(131, 23);
            this.BtnMakeMatrixB.TabIndex = 5;
            this.BtnMakeMatrixB.Text = "Make matrix B";
            this.BtnMakeMatrixB.UseVisualStyleBackColor = true;
            this.BtnMakeMatrixB.Click += new System.EventHandler(this.BtnMakeMatrixB_Click);
            // 
            // LblMakeMatrixA
            // 
            this.LblMakeMatrixA.Location = new System.Drawing.Point(12, 248);
            this.LblMakeMatrixA.Name = "LblMakeMatrixA";
            this.LblMakeMatrixA.Size = new System.Drawing.Size(131, 23);
            this.LblMakeMatrixA.TabIndex = 4;
            this.LblMakeMatrixA.Text = "Make matrix A";
            this.LblMakeMatrixA.UseVisualStyleBackColor = true;
            this.LblMakeMatrixA.Click += new System.EventHandler(this.BtnMakeMatrixA_Click);
            // 
            // TxtMatrixBCols
            // 
            this.TxtMatrixBCols.Location = new System.Drawing.Point(279, 281);
            this.TxtMatrixBCols.Name = "TxtMatrixBCols";
            this.TxtMatrixBCols.Size = new System.Drawing.Size(112, 22);
            this.TxtMatrixBCols.TabIndex = 3;
            // 
            // TxtMatrixACols
            // 
            this.TxtMatrixACols.Location = new System.Drawing.Point(279, 248);
            this.TxtMatrixACols.Name = "TxtMatrixACols";
            this.TxtMatrixACols.Size = new System.Drawing.Size(112, 22);
            this.TxtMatrixACols.TabIndex = 2;
            // 
            // TxtMatrixBRows
            // 
            this.TxtMatrixBRows.Location = new System.Drawing.Point(156, 281);
            this.TxtMatrixBRows.Name = "TxtMatrixBRows";
            this.TxtMatrixBRows.Size = new System.Drawing.Size(117, 22);
            this.TxtMatrixBRows.TabIndex = 1;
            // 
            // TxtMatrixARows
            // 
            this.TxtMatrixARows.Location = new System.Drawing.Point(156, 248);
            this.TxtMatrixARows.Name = "TxtMatrixARows";
            this.TxtMatrixARows.Size = new System.Drawing.Size(117, 22);
            this.TxtMatrixARows.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSubstract);
            this.groupBox1.Controls.Add(this.rdbAdd);
            this.groupBox1.Controls.Add(this.rdbMultiply);
            this.groupBox1.Location = new System.Drawing.Point(31, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select operation";
            // 
            // rdbSubstract
            // 
            this.rdbSubstract.AutoSize = true;
            this.rdbSubstract.Location = new System.Drawing.Point(168, 31);
            this.rdbSubstract.Name = "rdbSubstract";
            this.rdbSubstract.Size = new System.Drawing.Size(82, 21);
            this.rdbSubstract.TabIndex = 9;
            this.rdbSubstract.Text = "Substract";
            this.rdbSubstract.UseCompatibleTextRendering = true;
            this.rdbSubstract.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(99, 31);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(50, 21);
            this.rdbAdd.TabIndex = 8;
            this.rdbAdd.Text = "Add";
            this.rdbAdd.UseCompatibleTextRendering = true;
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // rdbMultiply
            // 
            this.rdbMultiply.AutoSize = true;
            this.rdbMultiply.Location = new System.Drawing.Point(6, 31);
            this.rdbMultiply.Name = "rdbMultiply";
            this.rdbMultiply.Size = new System.Drawing.Size(71, 21);
            this.rdbMultiply.TabIndex = 7;
            this.rdbMultiply.TabStop = true;
            this.rdbMultiply.Text = "Multiply";
            this.rdbMultiply.UseCompatibleTextRendering = true;
            this.rdbMultiply.UseVisualStyleBackColor = true;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCalculate.Location = new System.Drawing.Point(31, 395);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(97, 27);
            this.BtnCalculate.TabIndex = 10;
            this.BtnCalculate.Text = "&Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnClearMatrix
            // 
            this.BtnClearMatrix.Location = new System.Drawing.Point(273, 395);
            this.BtnClearMatrix.Name = "BtnClearMatrix";
            this.BtnClearMatrix.Size = new System.Drawing.Size(109, 27);
            this.BtnClearMatrix.TabIndex = 12;
            this.BtnClearMatrix.Text = "Clear &Matrix";
            this.BtnClearMatrix.UseVisualStyleBackColor = true;
            this.BtnClearMatrix.Click += new System.EventHandler(this.BtnClearMatrix_Click);
            // 
            // BtnMakeBIdentity
            // 
            this.BtnMakeBIdentity.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMakeBIdentity.Location = new System.Drawing.Point(403, 277);
            this.BtnMakeBIdentity.Name = "BtnMakeBIdentity";
            this.BtnMakeBIdentity.Size = new System.Drawing.Size(125, 26);
            this.BtnMakeBIdentity.TabIndex = 11;
            this.BtnMakeBIdentity.Text = "Make B identity";
            this.BtnMakeBIdentity.UseVisualStyleBackColor = true;
            this.BtnMakeBIdentity.Click += new System.EventHandler(this.BtnMakeBIdentity_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(403, 395);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 27);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(540, 432);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnMakeBIdentity);
            this.Controls.Add(this.BtnClearMatrix);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtMatrixARows);
            this.Controls.Add(this.TxtMatrixBRows);
            this.Controls.Add(this.TxtMatrixACols);
            this.Controls.Add(this.TxtMatrixBCols);
            this.Controls.Add(this.LblMakeMatrixA);
            this.Controls.Add(this.BtnMakeMatrixB);
            this.Controls.Add(this.LblCols);
            this.Controls.Add(this.LblRows);
            this.Controls.Add(this.LblMatrixCText);
            this.Controls.Add(this.LblMatrixBText);
            this.Controls.Add(this.LblMatrixAText);
            this.Controls.Add(this.LblMatrixC);
            this.Controls.Add(this.LblMaitrixB);
            this.Controls.Add(this.LblMatrixA);
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix Ops";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMatrixA;
        private System.Windows.Forms.Label LblMaitrixB;
        private System.Windows.Forms.Label LblMatrixC;
        private System.Windows.Forms.Label LblMatrixAText;
        private System.Windows.Forms.Label LblMatrixBText;
        private System.Windows.Forms.Label LblMatrixCText;
        private System.Windows.Forms.Label LblRows;
        private System.Windows.Forms.Label LblCols;
        private System.Windows.Forms.Button BtnMakeMatrixB;
        private System.Windows.Forms.Button LblMakeMatrixA;
        private System.Windows.Forms.TextBox TxtMatrixBCols;
        private System.Windows.Forms.TextBox TxtMatrixACols;
        private System.Windows.Forms.TextBox TxtMatrixBRows;
        private System.Windows.Forms.TextBox TxtMatrixARows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSubstract;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.RadioButton rdbMultiply;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnClearMatrix;
        private System.Windows.Forms.Button BtnMakeBIdentity;
        private System.Windows.Forms.Button BtnExit;
    }
}

