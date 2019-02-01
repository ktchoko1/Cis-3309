using System;
using System.Windows.Forms;

namespace FactorialCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number;
            int i;
            long factorial = 1;
            number = Convert.ToInt32(txtNumber.Text);
            // case where number equal 0
            if(number == 0)
            {
                factorial = 1;
                txtFactorial.Text = factorial.ToString();
            }
            else
            {   // Case where number is greater than 0
                for (i = 1; i <= number; i++)
                {
                    factorial = factorial * i;
                    txtFactorial.Text = factorial.ToString("n0");
                }// end for
            }// end if
            txtNumber.Focus();
            
            

        }// end btnCalculate

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
