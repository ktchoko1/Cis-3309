using System;
using System.Windows.Forms;

namespace IncomeTax
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
         
       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            
                decimal amount = Convert.ToDecimal(txtIncome.Text);

               // decimal taxed = calculateTax(income);
                decimal taxed;

                if (amount > 0m && amount < 9225m)
                {
                    taxed = 0 + (amount * .10m);

                }
                else if (amount > 9225m && amount < 37450m)
                {
                    taxed = 922.50m + (amount - 9225m) * 0.15m;
                }
                else if (amount > 37450m && amount < 90750m)
                {
                    taxed = taxed = 5156.25m + (amount - 90750m) * 0.25m;
                }
                else
                {
                       taxed = 0;
                 }

                    txtTaxed.Text = taxed.ToString();

                    txtIncome.Clear();
                    txtIncome.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
