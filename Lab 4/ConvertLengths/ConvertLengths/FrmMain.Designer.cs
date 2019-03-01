namespace ConvertLengths
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
            this.CmbConversion = new System.Windows.Forms.ComboBox();
            this.LblConversion = new System.Windows.Forms.Label();
            this.TxtLength = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblFromLength = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCalculatedLength = new System.Windows.Forms.Label();
            this.LblToLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbConversion
            // 
            this.CmbConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbConversion.FormattingEnabled = true;
            this.CmbConversion.Location = new System.Drawing.Point(150, 23);
            this.CmbConversion.Name = "CmbConversion";
            this.CmbConversion.Size = new System.Drawing.Size(182, 24);
            this.CmbConversion.TabIndex = 0;
            this.CmbConversion.SelectedIndexChanged += new System.EventHandler(this.CmbConversion_SelectedIndexChanged);
            // 
            // LblConversion
            // 
            this.LblConversion.AutoSize = true;
            this.LblConversion.Location = new System.Drawing.Point(47, 23);
            this.LblConversion.Name = "LblConversion";
            this.LblConversion.Size = new System.Drawing.Size(83, 17);
            this.LblConversion.TabIndex = 5;
            this.LblConversion.Text = "Conversion:";
            // 
            // TxtLength
            // 
            this.TxtLength.Location = new System.Drawing.Point(150, 66);
            this.TxtLength.Name = "TxtLength";
            this.TxtLength.Size = new System.Drawing.Size(100, 22);
            this.TxtLength.TabIndex = 1;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCalculate.Location = new System.Drawing.Point(50, 171);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(89, 30);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "&Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(241, 171);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(91, 30);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblFromLength
            // 
            this.LblFromLength.AutoSize = true;
            this.LblFromLength.Location = new System.Drawing.Point(47, 66);
            this.LblFromLength.Name = "LblFromLength";
            this.LblFromLength.Size = new System.Drawing.Size(44, 17);
            this.LblFromLength.TabIndex = 8;
            this.LblFromLength.Text = "Miles:";
            this.LblFromLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 9;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCalculatedLength
            // 
            this.LblCalculatedLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCalculatedLength.Location = new System.Drawing.Point(150, 104);
            this.LblCalculatedLength.Name = "LblCalculatedLength";
            this.LblCalculatedLength.Size = new System.Drawing.Size(100, 24);
            this.LblCalculatedLength.TabIndex = 10;
            this.LblCalculatedLength.Text = " ";
            this.LblCalculatedLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblCalculatedLength.UseCompatibleTextRendering = true;
           // this.LblCalculatedLength.Click += new System.EventHandler(this.LblCalculatedLength_Click);
            // 
            // LblToLength
            // 
            this.LblToLength.AutoSize = true;
            this.LblToLength.Location = new System.Drawing.Point(47, 112);
            this.LblToLength.Name = "LblToLength";
            this.LblToLength.Size = new System.Drawing.Size(78, 17);
            this.LblToLength.TabIndex = 11;
            this.LblToLength.Text = "Kilometers:";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(397, 243);
            this.Controls.Add(this.LblToLength);
            this.Controls.Add(this.LblCalculatedLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblFromLength);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TxtLength);
            this.Controls.Add(this.LblConversion);
            this.Controls.Add(this.CmbConversion);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversions";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbConversion;
        private System.Windows.Forms.Label LblConversion;
        private System.Windows.Forms.TextBox TxtLength;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnExit;
        internal System.Windows.Forms.Label LblFromLength;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label LblCalculatedLength;
        private System.Windows.Forms.Label LblToLength;
    }
}

