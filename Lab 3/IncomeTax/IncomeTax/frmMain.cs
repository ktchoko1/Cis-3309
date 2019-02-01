using System;
using System.Windows.Forms;

namespace IncomeTax
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
         // method that calculate the income tax
         private decimal CalculateTax(decimal amount)
        {
            if(amount > 0m && amount < 9225m)
            {
                return 0 + (amount * .10m);

            }else if(amount > 9225m && amount < 37450m)
            {
                return 922.50m + (amount - 9225m) * 0.15m; 
            }
            else
            {
                return 0;
            }

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal income = Convert.ToDecimal(TxtIncome.Text);
                decimal taxed = CalculateTax(income);
                TxtTaxed.Text = taxed.ToString();
                TxtIncome.Focus();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        // Method that clear the taxed text box if the income field changed
        private void TxtTaxed_TextChanged(object sender, EventArgs e)
        {

            TxtTaxed.Text = "";
        }

         
        // Method that close the form
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
