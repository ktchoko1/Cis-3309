using System;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmSalesTax : Form
    {

        public frmSalesTax()
        {
            InitializeComponent();
        }

        public bool IsValidData()
        {
            return
                IsPresent(TxtInput, "Input") &&
                IsDecimal(TxtInput, "Input") &&
                IsWithinRange(TxtInput, "Input", 0, 10);
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number <= min || number >= max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            if (IsValidData())
            {
                decimal salesTax = Convert.ToDecimal(TxtInput.Text);
                Tag = salesTax;
            }
            else
            {
                TxtInput.Clear();
                TxtInput.Focus();
            }
            
            
            
        }
    }
}
