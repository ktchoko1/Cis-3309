namespace CalculateReservations
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
            this.LblArrivalDate = new System.Windows.Forms.Label();
            this.LblDepartureDate = new System.Windows.Forms.Label();
            this.LblNumberOfNights = new System.Windows.Forms.Label();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.LblAvgPrice = new System.Windows.Forms.Label();
            this.TxtArrivalDate = new System.Windows.Forms.TextBox();
            this.TxtDepartureDate = new System.Windows.Forms.TextBox();
            this.TxtNumberOfNights = new System.Windows.Forms.TextBox();
            this.TxtTotalPrice = new System.Windows.Forms.TextBox();
            this.TxtAvgPricePerNight = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblArrivalDate
            // 
            this.LblArrivalDate.AutoSize = true;
            this.LblArrivalDate.Location = new System.Drawing.Point(26, 24);
            this.LblArrivalDate.Name = "LblArrivalDate";
            this.LblArrivalDate.Size = new System.Drawing.Size(84, 17);
            this.LblArrivalDate.TabIndex = 7;
            this.LblArrivalDate.Text = "Arrival date:";
            // 
            // LblDepartureDate
            // 
            this.LblDepartureDate.AutoSize = true;
            this.LblDepartureDate.Location = new System.Drawing.Point(26, 62);
            this.LblDepartureDate.Name = "LblDepartureDate";
            this.LblDepartureDate.Size = new System.Drawing.Size(108, 17);
            this.LblDepartureDate.TabIndex = 8;
            this.LblDepartureDate.Text = "Departure date;";
            // 
            // LblNumberOfNights
            // 
            this.LblNumberOfNights.AutoSize = true;
            this.LblNumberOfNights.Location = new System.Drawing.Point(26, 98);
            this.LblNumberOfNights.Name = "LblNumberOfNights";
            this.LblNumberOfNights.Size = new System.Drawing.Size(120, 17);
            this.LblNumberOfNights.TabIndex = 9;
            this.LblNumberOfNights.Text = "Number of nights:";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Location = new System.Drawing.Point(26, 133);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(79, 17);
            this.LblTotalPrice.TabIndex = 10;
            this.LblTotalPrice.Text = "Total price:";
            // 
            // LblAvgPrice
            // 
            this.LblAvgPrice.AutoSize = true;
            this.LblAvgPrice.Location = new System.Drawing.Point(26, 169);
            this.LblAvgPrice.Name = "LblAvgPrice";
            this.LblAvgPrice.Size = new System.Drawing.Size(135, 17);
            this.LblAvgPrice.TabIndex = 11;
            this.LblAvgPrice.Text = "Avg. price per night:";
            // 
            // TxtArrivalDate
            // 
            this.TxtArrivalDate.Location = new System.Drawing.Point(159, 24);
            this.TxtArrivalDate.Name = "TxtArrivalDate";
            this.TxtArrivalDate.Size = new System.Drawing.Size(100, 22);
            this.TxtArrivalDate.TabIndex = 0;
            // 
            // TxtDepartureDate
            // 
            this.TxtDepartureDate.Location = new System.Drawing.Point(159, 62);
            this.TxtDepartureDate.Name = "TxtDepartureDate";
            this.TxtDepartureDate.Size = new System.Drawing.Size(100, 22);
            this.TxtDepartureDate.TabIndex = 1;
            // 
            // TxtNumberOfNights
            // 
            this.TxtNumberOfNights.Location = new System.Drawing.Point(159, 98);
            this.TxtNumberOfNights.Name = "TxtNumberOfNights";
            this.TxtNumberOfNights.ReadOnly = true;
            this.TxtNumberOfNights.Size = new System.Drawing.Size(100, 22);
            this.TxtNumberOfNights.TabIndex = 4;
            // 
            // TxtTotalPrice
            // 
            this.TxtTotalPrice.Location = new System.Drawing.Point(159, 130);
            this.TxtTotalPrice.Name = "TxtTotalPrice";
            this.TxtTotalPrice.ReadOnly = true;
            this.TxtTotalPrice.Size = new System.Drawing.Size(100, 22);
            this.TxtTotalPrice.TabIndex = 5;
            // 
            // TxtAvgPricePerNight
            // 
            this.TxtAvgPricePerNight.Location = new System.Drawing.Point(159, 166);
            this.TxtAvgPricePerNight.Name = "TxtAvgPricePerNight";
            this.TxtAvgPricePerNight.ReadOnly = true;
            this.TxtAvgPricePerNight.Size = new System.Drawing.Size(100, 22);
            this.TxtAvgPricePerNight.TabIndex = 6;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(44, 221);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(90, 32);
            this.BtnCalculate.TabIndex = 2;
            this.BtnCalculate.Text = "&Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(174, 221);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(85, 32);
            this.BtnExit.TabIndex = 3;
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
            this.ClientSize = new System.Drawing.Size(300, 285);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TxtAvgPricePerNight);
            this.Controls.Add(this.TxtTotalPrice);
            this.Controls.Add(this.TxtNumberOfNights);
            this.Controls.Add(this.TxtDepartureDate);
            this.Controls.Add(this.TxtArrivalDate);
            this.Controls.Add(this.LblAvgPrice);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.LblNumberOfNights);
            this.Controls.Add(this.LblDepartureDate);
            this.Controls.Add(this.LblArrivalDate);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblArrivalDate;
        private System.Windows.Forms.Label LblDepartureDate;
        private System.Windows.Forms.Label LblNumberOfNights;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.Label LblAvgPrice;
        private System.Windows.Forms.TextBox TxtArrivalDate;
        private System.Windows.Forms.TextBox TxtDepartureDate;
        private System.Windows.Forms.TextBox TxtNumberOfNights;
        private System.Windows.Forms.TextBox TxtTotalPrice;
        private System.Windows.Forms.TextBox TxtAvgPricePerNight;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnExit;
    }
}

