namespace ScoreArray
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
            this.LblScore = new System.Windows.Forms.Label();
            this.LblScoreTotal = new System.Windows.Forms.Label();
            this.LblScoreCount = new System.Windows.Forms.Label();
            this.LblAverage = new System.Windows.Forms.Label();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.TxtSoreTotal = new System.Windows.Forms.TextBox();
            this.TxtScoreCount = new System.Windows.Forms.TextBox();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDisplayScore = new System.Windows.Forms.Button();
            this.BtnClearScore = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(27, 19);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(45, 17);
            this.LblScore.TabIndex = 0;
            this.LblScore.Text = "Score";
            // 
            // LblScoreTotal
            // 
            this.LblScoreTotal.AutoSize = true;
            this.LblScoreTotal.Location = new System.Drawing.Point(27, 57);
            this.LblScoreTotal.Name = "LblScoreTotal";
            this.LblScoreTotal.Size = new System.Drawing.Size(81, 17);
            this.LblScoreTotal.TabIndex = 1;
            this.LblScoreTotal.Text = "Score Total";
            // 
            // LblScoreCount
            // 
            this.LblScoreCount.AutoSize = true;
            this.LblScoreCount.Location = new System.Drawing.Point(27, 92);
            this.LblScoreCount.Name = "LblScoreCount";
            this.LblScoreCount.Size = new System.Drawing.Size(86, 17);
            this.LblScoreCount.TabIndex = 2;
            this.LblScoreCount.Text = "Score Count";
            // 
            // LblAverage
            // 
            this.LblAverage.Location = new System.Drawing.Point(27, 132);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(100, 23);
            this.LblAverage.TabIndex = 3;
            this.LblAverage.Text = "Average";
            // 
            // TxtScore
            // 
            this.TxtScore.Location = new System.Drawing.Point(130, 19);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(51, 22);
            this.TxtScore.TabIndex = 0;
            // 
            // TxtSoreTotal
            // 
            this.TxtSoreTotal.Location = new System.Drawing.Point(130, 57);
            this.TxtSoreTotal.Name = "TxtSoreTotal";
            this.TxtSoreTotal.ReadOnly = true;
            this.TxtSoreTotal.Size = new System.Drawing.Size(51, 22);
            this.TxtSoreTotal.TabIndex = 5;
            // 
            // TxtScoreCount
            // 
            this.TxtScoreCount.Location = new System.Drawing.Point(130, 92);
            this.TxtScoreCount.Name = "TxtScoreCount";
            this.TxtScoreCount.ReadOnly = true;
            this.TxtScoreCount.Size = new System.Drawing.Size(51, 22);
            this.TxtScoreCount.TabIndex = 6;
            // 
            // TxtAverage
            // 
            this.TxtAverage.Location = new System.Drawing.Point(130, 132);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.ReadOnly = true;
            this.TxtAverage.Size = new System.Drawing.Size(51, 22);
            this.TxtAverage.TabIndex = 7;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(205, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 29);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "A&dd";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDisplayScore
            // 
            this.BtnDisplayScore.Location = new System.Drawing.Point(12, 185);
            this.BtnDisplayScore.Name = "BtnDisplayScore";
            this.BtnDisplayScore.Size = new System.Drawing.Size(115, 38);
            this.BtnDisplayScore.TabIndex = 2;
            this.BtnDisplayScore.Text = "&Display Code";
            this.BtnDisplayScore.UseVisualStyleBackColor = true;
            this.BtnDisplayScore.Click += new System.EventHandler(this.BtnDisplayScore_Click);
            // 
            // BtnClearScore
            // 
            this.BtnClearScore.Location = new System.Drawing.Point(155, 185);
            this.BtnClearScore.Name = "BtnClearScore";
            this.BtnClearScore.Size = new System.Drawing.Size(125, 38);
            this.BtnClearScore.TabIndex = 3;
            this.BtnClearScore.Text = "&Clear Score";
            this.BtnClearScore.UseVisualStyleBackColor = true;
            this.BtnClearScore.Click += new System.EventHandler(this.BtnClearScore_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(205, 239);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 34);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(358, 301);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClearScore);
            this.Controls.Add(this.BtnDisplayScore);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtAverage);
            this.Controls.Add(this.TxtScoreCount);
            this.Controls.Add(this.TxtSoreTotal);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.LblAverage);
            this.Controls.Add(this.LblScoreCount);
            this.Controls.Add(this.LblScoreTotal);
            this.Controls.Add(this.LblScore);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label LblScoreTotal;
        private System.Windows.Forms.Label LblScoreCount;
        private System.Windows.Forms.Label LblAverage;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.TextBox TxtSoreTotal;
        private System.Windows.Forms.TextBox TxtScoreCount;
        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDisplayScore;
        private System.Windows.Forms.Button BtnClearScore;
        private System.Windows.Forms.Button BtnExit;
    }
}

