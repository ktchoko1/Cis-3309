using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangesCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare variables
            const decimal QUATER = 25m;
            const decimal DIME = 10m;
            const decimal NICKEL = 5m;
            
            decimal amount;
            decimal leftOver;
            
            
            amount = Convert.ToDecimal(txtAmount.Text);
           
            if((amount > 0) && (amount <= 99)) {
                //Calculate the number of quater
                leftOver = amount;
                int numQuaters = (int)(leftOver / QUATER);
                leftOver = leftOver % QUATER;
                txtQuaters.Text = numQuaters.ToString();

                //calculate the number of dimes
                int numDimes = (int)(leftOver / DIME);
                leftOver = leftOver % DIME;
                txtDimes.Text = numDimes.ToString();

                // Calculate the number of nickles
                int numNickels = (int)(leftOver / NICKEL);
                leftOver = leftOver % NICKEL;
                txtNikels.Text = numNickels.ToString();

                // Calculate the number of pennies
                int numPennies = (int)leftOver;
                txtPennies.Text = numPennies.ToString();
                txtAmount.Focus();

            }
            else
            {
                MessageBox.Show("Enter a number between 0 and 99 !");
            }

        }// end btnCalculate_Click(object sender, EventArgs e)

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }//end btnExit_Click(object sender, EventArgs e)
    }
}
