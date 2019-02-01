namespace ChangesCalculator
{
    partial class frmMain
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
            this.lblAmountOfChange = new System.Windows.Forms.Label();
            this.lblQuaters = new System.Windows.Forms.Label();
            this.lblDimes = new System.Windows.Forms.Label();
            this.lblNickels = new System.Windows.Forms.Label();
            this.lblPennies = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtQuaters = new System.Windows.Forms.TextBox();
            this.txtDimes = new System.Windows.Forms.TextBox();
            this.txtNikels = new System.Windows.Forms.TextBox();
            this.txtPennies = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmountOfChange
            // 
            this.lblAmountOfChange.AutoSize = true;
            this.lblAmountOfChange.Location = new System.Drawing.Point(24, 18);
            this.lblAmountOfChange.Name = "lblAmountOfChange";
            this.lblAmountOfChange.Size = new System.Drawing.Size(186, 17);
            this.lblAmountOfChange.TabIndex = 0;
            this.lblAmountOfChange.Text = "Amount of change du (0-99)";
            // 
            // lblQuaters
            // 
            this.lblQuaters.AutoSize = true;
            this.lblQuaters.Location = new System.Drawing.Point(143, 51);
            this.lblQuaters.Name = "lblQuaters";
            this.lblQuaters.Size = new System.Drawing.Size(59, 17);
            this.lblQuaters.TabIndex = 1;
            this.lblQuaters.Text = "Quaters";
            // 
            // lblDimes
            // 
            this.lblDimes.AutoSize = true;
            this.lblDimes.Location = new System.Drawing.Point(155, 84);
            this.lblDimes.Name = "lblDimes";
            this.lblDimes.Size = new System.Drawing.Size(47, 17);
            this.lblDimes.TabIndex = 2;
            this.lblDimes.Text = "Dimes";
            // 
            // lblNickels
            // 
            this.lblNickels.AutoSize = true;
            this.lblNickels.Location = new System.Drawing.Point(149, 115);
            this.lblNickels.Name = "lblNickels";
            this.lblNickels.Size = new System.Drawing.Size(53, 17);
            this.lblNickels.TabIndex = 3;
            this.lblNickels.Text = "Nickels";
            // 
            // lblPennies
            // 
            this.lblPennies.AutoSize = true;
            this.lblPennies.Location = new System.Drawing.Point(143, 147);
            this.lblPennies.Name = "lblPennies";
            this.lblPennies.Size = new System.Drawing.Size(59, 17);
            this.lblPennies.TabIndex = 4;
            this.lblPennies.Text = "Pennies";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(216, 18);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 0;
            // 
            // txtQuaters
            // 
            this.txtQuaters.Location = new System.Drawing.Point(216, 51);
            this.txtQuaters.Name = "txtQuaters";
            this.txtQuaters.ReadOnly = true;
            this.txtQuaters.Size = new System.Drawing.Size(100, 22);
            this.txtQuaters.TabIndex = 6;
            // 
            // txtDimes
            // 
            this.txtDimes.Location = new System.Drawing.Point(216, 84);
            this.txtDimes.Name = "txtDimes";
            this.txtDimes.ReadOnly = true;
            this.txtDimes.Size = new System.Drawing.Size(100, 22);
            this.txtDimes.TabIndex = 7;
            // 
            // txtNikels
            // 
            this.txtNikels.Location = new System.Drawing.Point(216, 115);
            this.txtNikels.Name = "txtNikels";
            this.txtNikels.ReadOnly = true;
            this.txtNikels.Size = new System.Drawing.Size(100, 22);
            this.txtNikels.TabIndex = 8;
            // 
            // txtPennies
            // 
            this.txtPennies.Location = new System.Drawing.Point(216, 142);
            this.txtPennies.Name = "txtPennies";
            this.txtPennies.ReadOnly = true;
            this.txtPennies.Size = new System.Drawing.Size(100, 22);
            this.txtPennies.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(206, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(40, 209);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 28);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(392, 277);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPennies);
            this.Controls.Add(this.txtNikels);
            this.Controls.Add(this.txtDimes);
            this.Controls.Add(this.txtQuaters);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblPennies);
            this.Controls.Add(this.lblNickels);
            this.Controls.Add(this.lblDimes);
            this.Controls.Add(this.lblQuaters);
            this.Controls.Add(this.lblAmountOfChange);
            this.Name = "frmMain";
            this.Text = "Change Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmountOfChange;
        private System.Windows.Forms.Label lblQuaters;
        private System.Windows.Forms.Label lblDimes;
        private System.Windows.Forms.Label lblNickels;
        private System.Windows.Forms.Label lblPennies;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtQuaters;
        private System.Windows.Forms.TextBox txtDimes;
        private System.Windows.Forms.TextBox txtNikels;
        private System.Windows.Forms.TextBox txtPennies;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
    }
}

