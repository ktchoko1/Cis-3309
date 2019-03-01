using System; 
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        decimal SalesTaxPct = 7.75m;

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                decimal productTotal = Convert.ToDecimal(TxtProductTotal.Text);
                decimal discountPercent = .0m;

                if (productTotal < 100)
                    discountPercent = .0m;
                else if (productTotal >= 100 && productTotal < 250)
                    discountPercent = .1m;
                else if (productTotal >= 250)
                    discountPercent = .25m;

                decimal discountAmount = productTotal * discountPercent;
                decimal subtotal = productTotal - discountAmount;
                decimal tax = subtotal * SalesTaxPct / 100;
                decimal total = subtotal + tax;

                txtDiscountAmount.Text = discountAmount.ToString("c");
                txtSubtotal.Text = subtotal.ToString("c");
                txtTax.Text = tax.ToString("c");
                txtTotal.Text = total.ToString("c");

                TxtProductTotal.Focus();
            }
            
        }

        public bool IsValidData()
        {
            return
                IsPresent(TxtProductTotal, "Subtotal") &&
                IsDecimal(TxtProductTotal, "Subtotal") &&
                IsWithinRange(TxtProductTotal, "Subtotal", 0, 1000000);
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

        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            frmSalesTax f = new frmSalesTax();
            //f.Show();

            if (f.ShowDialog() == DialogResult.OK)
            {
                SalesTaxPct = Convert.ToDecimal(f.Tag);
                f.Close();
            }
        }

       
    }
}