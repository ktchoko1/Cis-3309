namespace ProcessLunchOrder
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
            this.RdbHumberger = new System.Windows.Forms.RadioButton();
            this.RdbPizza = new System.Windows.Forms.RadioButton();
            this.RdbSalad = new System.Windows.Forms.RadioButton();
            this.ChbLettuceTomate = new System.Windows.Forms.CheckBox();
            this.ChbKetchMustard = new System.Windows.Forms.CheckBox();
            this.ChbFrienchFries = new System.Windows.Forms.CheckBox();
            this.GboMainCourse = new System.Windows.Forms.GroupBox();
            this.GboAddOn = new System.Windows.Forms.GroupBox();
            this.GboOrderTotal = new System.Windows.Forms.GroupBox();
            this.LblSubtotalCalcualted = new System.Windows.Forms.Label();
            this.LblOrderTotalCalculated = new System.Windows.Forms.Label();
            this.LblTaxCalculated = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.LblTax = new System.Windows.Forms.Label();
            this.BtnPlaceOrder = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GboMainCourse.SuspendLayout();
            this.GboAddOn.SuspendLayout();
            this.GboOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // RdbHumberger
            // 
            this.RdbHumberger.AutoSize = true;
            this.RdbHumberger.Location = new System.Drawing.Point(6, 30);
            this.RdbHumberger.Name = "RdbHumberger";
            this.RdbHumberger.Size = new System.Drawing.Size(149, 21);
            this.RdbHumberger.TabIndex = 1;
            this.RdbHumberger.TabStop = true;
            this.RdbHumberger.Text = "Humburger - $6.95";
            this.RdbHumberger.UseVisualStyleBackColor = true;
            this.RdbHumberger.CheckedChanged += new System.EventHandler(this.RdbHumberger_CheckedChanged);
            // 
            // RdbPizza
            // 
            this.RdbPizza.AutoSize = true;
            this.RdbPizza.Location = new System.Drawing.Point(6, 57);
            this.RdbPizza.Name = "RdbPizza";
            this.RdbPizza.Size = new System.Drawing.Size(112, 21);
            this.RdbPizza.TabIndex = 2;
            this.RdbPizza.TabStop = true;
            this.RdbPizza.Text = "Pizza - $5.95";
            this.RdbPizza.UseVisualStyleBackColor = true;
            this.RdbPizza.CheckedChanged += new System.EventHandler(this.RdbPizza_CheckedChanged);
            // 
            // RdbSalad
            // 
            this.RdbSalad.AutoSize = true;
            this.RdbSalad.Location = new System.Drawing.Point(6, 84);
            this.RdbSalad.Name = "RdbSalad";
            this.RdbSalad.Size = new System.Drawing.Size(114, 21);
            this.RdbSalad.TabIndex = 3;
            this.RdbSalad.TabStop = true;
            this.RdbSalad.Text = "Salad - $4.95";
            this.RdbSalad.UseVisualStyleBackColor = true;
            this.RdbSalad.CheckedChanged += new System.EventHandler(this.RdbSalad_CheckedChanged);
            // 
            // ChbLettuceTomate
            // 
            this.ChbLettuceTomate.AutoSize = true;
            this.ChbLettuceTomate.Location = new System.Drawing.Point(6, 26);
            this.ChbLettuceTomate.Name = "ChbLettuceTomate";
            this.ChbLettuceTomate.Size = new System.Drawing.Size(206, 21);
            this.ChbLettuceTomate.TabIndex = 6;
            this.ChbLettuceTomate.Text = "Lettuce, tomate, and onions";
            this.ChbLettuceTomate.UseVisualStyleBackColor = true;
            // 
            // ChbKetchMustard
            // 
            this.ChbKetchMustard.AutoSize = true;
            this.ChbKetchMustard.Location = new System.Drawing.Point(6, 53);
            this.ChbKetchMustard.Name = "ChbKetchMustard";
            this.ChbKetchMustard.Size = new System.Drawing.Size(207, 21);
            this.ChbKetchMustard.TabIndex = 7;
            this.ChbKetchMustard.Text = "Kechup, mustard, and mayo";
            this.ChbKetchMustard.UseVisualStyleBackColor = true;
            // 
            // ChbFrienchFries
            // 
            this.ChbFrienchFries.AutoSize = true;
            this.ChbFrienchFries.Location = new System.Drawing.Point(6, 79);
            this.ChbFrienchFries.Name = "ChbFrienchFries";
            this.ChbFrienchFries.Size = new System.Drawing.Size(105, 21);
            this.ChbFrienchFries.TabIndex = 8;
            this.ChbFrienchFries.Text = "French fries";
            this.ChbFrienchFries.UseVisualStyleBackColor = true;
            // 
            // GboMainCourse
            // 
            this.GboMainCourse.Controls.Add(this.RdbSalad);
            this.GboMainCourse.Controls.Add(this.RdbHumberger);
            this.GboMainCourse.Controls.Add(this.RdbPizza);
            this.GboMainCourse.Location = new System.Drawing.Point(29, 12);
            this.GboMainCourse.Name = "GboMainCourse";
            this.GboMainCourse.Size = new System.Drawing.Size(180, 129);
            this.GboMainCourse.TabIndex = 10;
            this.GboMainCourse.TabStop = false;
            this.GboMainCourse.Text = "Main course";
            // 
            // GboAddOn
            // 
            this.GboAddOn.Controls.Add(this.ChbLettuceTomate);
            this.GboAddOn.Controls.Add(this.ChbKetchMustard);
            this.GboAddOn.Controls.Add(this.ChbFrienchFries);
            this.GboAddOn.Location = new System.Drawing.Point(224, 17);
            this.GboAddOn.Name = "GboAddOn";
            this.GboAddOn.Size = new System.Drawing.Size(270, 124);
            this.GboAddOn.TabIndex = 11;
            this.GboAddOn.TabStop = false;
            this.GboAddOn.Text = "Add - on ($.75/each)";
            // 
            // GboOrderTotal
            // 
            this.GboOrderTotal.Controls.Add(this.LblSubtotalCalcualted);
            this.GboOrderTotal.Controls.Add(this.LblOrderTotalCalculated);
            this.GboOrderTotal.Controls.Add(this.LblTaxCalculated);
            this.GboOrderTotal.Controls.Add(this.label1);
            this.GboOrderTotal.Controls.Add(this.label3);
            this.GboOrderTotal.Controls.Add(this.LblSubtotal);
            this.GboOrderTotal.Controls.Add(this.LblTax);
            this.GboOrderTotal.Location = new System.Drawing.Point(29, 167);
            this.GboOrderTotal.Name = "GboOrderTotal";
            this.GboOrderTotal.Size = new System.Drawing.Size(306, 142);
            this.GboOrderTotal.TabIndex = 12;
            this.GboOrderTotal.TabStop = false;
            this.GboOrderTotal.Text = "Order total";
            // 
            // LblSubtotalCalcualted
            // 
            this.LblSubtotalCalcualted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSubtotalCalcualted.Location = new System.Drawing.Point(107, 23);
            this.LblSubtotalCalcualted.Name = "LblSubtotalCalcualted";
            this.LblSubtotalCalcualted.Size = new System.Drawing.Size(100, 23);
            this.LblSubtotalCalcualted.TabIndex = 19;
            // 
            // LblOrderTotalCalculated
            // 
            this.LblOrderTotalCalculated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOrderTotalCalculated.Location = new System.Drawing.Point(107, 91);
            this.LblOrderTotalCalculated.Name = "LblOrderTotalCalculated";
            this.LblOrderTotalCalculated.Size = new System.Drawing.Size(100, 23);
            this.LblOrderTotalCalculated.TabIndex = 18;
            // 
            // LblTaxCalculated
            // 
            this.LblTaxCalculated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTaxCalculated.Location = new System.Drawing.Point(107, 55);
            this.LblTaxCalculated.Name = "LblTaxCalculated";
            this.LblTaxCalculated.Size = new System.Drawing.Size(100, 23);
            this.LblTaxCalculated.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Order total:";
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Location = new System.Drawing.Point(17, 24);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(64, 17);
            this.LblSubtotal.TabIndex = 13;
            this.LblSubtotal.Text = "Subtotal:";
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.Location = new System.Drawing.Point(12, 55);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(89, 17);
            this.LblTax.TabIndex = 14;
            this.LblTax.Text = "Tax (7.75%):";
            // 
            // BtnPlaceOrder
            // 
            this.BtnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnPlaceOrder.Location = new System.Drawing.Point(362, 176);
            this.BtnPlaceOrder.Name = "BtnPlaceOrder";
            this.BtnPlaceOrder.Size = new System.Drawing.Size(132, 32);
            this.BtnPlaceOrder.TabIndex = 13;
            this.BtnPlaceOrder.Text = "&Place Order";
            this.BtnPlaceOrder.UseVisualStyleBackColor = true;
            this.BtnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(362, 280);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(132, 29);
            this.BtnExit.TabIndex = 14;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(557, 344);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnPlaceOrder);
            this.Controls.Add(this.GboOrderTotal);
            this.Controls.Add(this.GboAddOn);
            this.Controls.Add(this.GboMainCourse);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
          //  this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GboMainCourse.ResumeLayout(false);
            this.GboMainCourse.PerformLayout();
            this.GboAddOn.ResumeLayout(false);
            this.GboAddOn.PerformLayout();
            this.GboOrderTotal.ResumeLayout(false);
            this.GboOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbHumberger;
        private System.Windows.Forms.RadioButton RdbPizza;
        private System.Windows.Forms.RadioButton RdbSalad;
        private System.Windows.Forms.CheckBox ChbLettuceTomate;
        private System.Windows.Forms.CheckBox ChbKetchMustard;
        private System.Windows.Forms.CheckBox ChbFrienchFries;
        private System.Windows.Forms.GroupBox GboMainCourse;
        private System.Windows.Forms.GroupBox GboAddOn;
        private System.Windows.Forms.GroupBox GboOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.Label LblTax;
        private System.Windows.Forms.Button BtnPlaceOrder;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblOrderTotalCalculated;
        private System.Windows.Forms.Label LblTaxCalculated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSubtotalCalcualted;
    }
}

