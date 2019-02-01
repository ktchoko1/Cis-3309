using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // Method that calculate differents values entered
        private decimal Calculate(decimal operand1, decimal operand2, string oper)
        {
            switch (oper)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    return Math.Round(operand1 / operand2, 4);
                default:
                    return 0;
            }

        }
      
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            
               // get operands and operator from the user
                decimal operand1 = Convert.ToDecimal(TxtOperand1.Text);
                decimal operande2 = Convert.ToDecimal(TxtOperand2.Text);
                string oper = Convert.ToString(TxtOperator.Text);

                //Calculate the result
                    TxtResult.Text = Calculate(operand1, operande2, oper).ToString();
                    TxtOperand1.Focus();
        }

        //Clear teh result text box if operands changed
        private void TxtResult_TextChanged(object sender, EventArgs e)
        {
            TxtResult.Text = "";

        }

        // Method that close the form
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
