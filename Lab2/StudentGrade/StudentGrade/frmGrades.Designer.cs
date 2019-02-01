namespace StudentGrade
{
    partial class frmGrades
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
            this.bntCalculate = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.lblNumberGrade = new System.Windows.Forms.Label();
            this.txtNumberGrade = new System.Windows.Forms.TextBox();
            this.txtLetterGrade = new System.Windows.Forms.TextBox();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntCalculate
            // 
            this.bntCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCalculate.Location = new System.Drawing.Point(68, 229);
            this.bntCalculate.Name = "bntCalculate";
            this.bntCalculate.Size = new System.Drawing.Size(110, 35);
            this.bntCalculate.TabIndex = 2;
            this.bntCalculate.Text = "&Calculate";
            this.bntCalculate.UseVisualStyleBackColor = true;
            this.bntCalculate.Click += new System.EventHandler(this.bntCalculate_Click);
            // 
            // bntExit
            // 
            this.bntExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntExit.Location = new System.Drawing.Point(283, 229);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(95, 35);
            this.bntExit.TabIndex = 3;
            this.bntExit.Text = "&Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // lblNumberGrade
            // 
            this.lblNumberGrade.AutoSize = true;
            this.lblNumberGrade.Location = new System.Drawing.Point(89, 63);
            this.lblNumberGrade.Name = "lblNumberGrade";
            this.lblNumberGrade.Size = new System.Drawing.Size(102, 17);
            this.lblNumberGrade.TabIndex = 2;
            this.lblNumberGrade.Text = "Number Grade";
            // 
            // txtNumberGrade
            // 
            this.txtNumberGrade.Location = new System.Drawing.Point(207, 60);
            this.txtNumberGrade.Name = "txtNumberGrade";
            this.txtNumberGrade.Size = new System.Drawing.Size(96, 22);
            this.txtNumberGrade.TabIndex = 0;
            // 
            // txtLetterGrade
            // 
            this.txtLetterGrade.Location = new System.Drawing.Point(207, 126);
            this.txtLetterGrade.Name = "txtLetterGrade";
            this.txtLetterGrade.ReadOnly = true;
            this.txtLetterGrade.Size = new System.Drawing.Size(100, 22);
            this.txtLetterGrade.TabIndex = 1;
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.AutoSize = true;
            this.lblLetterGrade.Location = new System.Drawing.Point(89, 131);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(89, 17);
            this.lblLetterGrade.TabIndex = 5;
            this.lblLetterGrade.Text = "Letter Grade";
            // 
            // frmGrades
            // 
            this.AcceptButton = this.bntCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntExit;
            this.ClientSize = new System.Drawing.Size(423, 298);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.txtLetterGrade);
            this.Controls.Add(this.txtNumberGrade);
            this.Controls.Add(this.lblNumberGrade);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntCalculate);
            this.Name = "frmGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Letter Grade";
            this.Load += new System.EventHandler(this.Grades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCalculate;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Label lblNumberGrade;
        private System.Windows.Forms.TextBox txtNumberGrade;
        private System.Windows.Forms.TextBox txtLetterGrade;
        private System.Windows.Forms.Label lblLetterGrade;
    }
}

