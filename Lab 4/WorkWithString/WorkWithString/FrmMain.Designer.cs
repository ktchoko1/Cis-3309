namespace WorkWithString
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
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblState = new System.Windows.Forms.Label();
            this.LblZipCode = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.TxtZipCode = new System.Windows.Forms.TextBox();
            this.BtnParse = new System.Windows.Forms.Button();
            this.BtnFormat = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(35, 39);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(46, 17);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "Email:";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(35, 157);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(35, 17);
            this.LblCity.TabIndex = 1;
            this.LblCity.Text = "City:";
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(25, 225);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(45, 17);
            this.LblState.TabIndex = 2;
            this.LblState.Text = "State:";
            // 
            // LblZipCode
            // 
            this.LblZipCode.AutoSize = true;
            this.LblZipCode.Location = new System.Drawing.Point(3, 276);
            this.LblZipCode.Name = "LblZipCode";
            this.LblZipCode.Size = new System.Drawing.Size(67, 17);
            this.LblZipCode.TabIndex = 3;
            this.LblZipCode.Text = "Zip code:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(98, 36);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(310, 22);
            this.TxtEmail.TabIndex = 0;
          //  this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(98, 157);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(310, 22);
            this.TxtCity.TabIndex = 1;
            // 
            // TxtState
            // 
            this.TxtState.Location = new System.Drawing.Point(98, 220);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(56, 22);
            this.TxtState.TabIndex = 2;
            // 
            // TxtZipCode
            // 
            this.TxtZipCode.Location = new System.Drawing.Point(98, 273);
            this.TxtZipCode.Name = "TxtZipCode";
            this.TxtZipCode.Size = new System.Drawing.Size(100, 22);
            this.TxtZipCode.TabIndex = 3;
            // 
            // BtnParse
            // 
            this.BtnParse.Location = new System.Drawing.Point(449, 33);
            this.BtnParse.Name = "BtnParse";
            this.BtnParse.Size = new System.Drawing.Size(97, 25);
            this.BtnParse.TabIndex = 4;
            this.BtnParse.Text = "&Parse";
            this.BtnParse.UseVisualStyleBackColor = true;
            this.BtnParse.Click += new System.EventHandler(this.BtnParse_Click);
            // 
            // BtnFormat
            // 
            this.BtnFormat.Location = new System.Drawing.Point(449, 270);
            this.BtnFormat.Name = "BtnFormat";
            this.BtnFormat.Size = new System.Drawing.Size(75, 23);
            this.BtnFormat.TabIndex = 5;
            this.BtnFormat.Text = "Format";
            this.BtnFormat.UseVisualStyleBackColor = true;
            this.BtnFormat.Click += new System.EventHandler(this.BtnFormat_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(449, 322);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 367);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnFormat);
            this.Controls.Add(this.BtnParse);
            this.Controls.Add(this.TxtZipCode);
            this.Controls.Add(this.TxtState);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblZipCode);
            this.Controls.Add(this.LblState);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblEmail);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.Label LblZipCode;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.TextBox TxtZipCode;
        private System.Windows.Forms.Button BtnParse;
        private System.Windows.Forms.Button BtnFormat;
        private System.Windows.Forms.Button BtnExit;
    }
}

