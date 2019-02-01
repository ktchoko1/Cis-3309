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

        // Method that check for text field

        private bool IsPresent(TextBox t, string name)
        {
            if(t.Text == "")
            {
                MessageBox.Show(name + " is required");
                t.Focus();
                return false;
            }
            return true;
        }

        // Method that check for decimal
        private bool IsDecimal(TextBox t, string name)
        {
            decimal number = 0m;
            if(decimal.TryParse(t.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " is required filed");
                return false;
            }
        }
        // method that check for the right operator
        private bool IsOperator(TextBox t, string name)
        {
            if(t.Text != "+" && t.Text != "-" && t.Text != "*" && t.Text != "/")
            {
                MessageBox.Show(name = " is not a valide operantor!");
                return false;
            }
            return true;
        }

        // Method that check for the range of the decimal
        private bool IsWithinRange(TextBox t, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(t.Text);
            if(number < min || number > max)
            {
                MessageBox.Show(name + " must be between" + min.ToString() + " and" + max.ToString());
                t.Focus();
                return false;
            }
            return true;
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
        //Validation method

        private bool IsValidatData()
        {
            if (!IsPresent(TxtOperand1, "operand 1"))
                return false;
            if (!IsDecimal(TxtOperand1, "operand 1"))
                return false;
            if (!IsWithinRange(TxtOperand1, "operand 1", 1, 1000000))
                return false;
            // operand 2
            if (!IsPresent(TxtOperand2, "operand 2"))
                return false;
            if (!IsDecimal(TxtOperand2, "operand 2"))
                return false;
            if (!IsWithinRange(TxtOperand2, "operand 2", 1, 1000000))
                return false;
            // Operator
            if (!IsPresent(TxtOperator, "operator"))
                return false;
            if (!IsOperator(TxtOperator, "operator"))
                return false;

            return true;

        }

        // Method that calculate the results
        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            try {

                decimal operand1 = Convert.ToDecimal(TxtOperand1.Text);
                decimal operande2 = Convert.ToDecimal(TxtOperand2.Text);
                string oper = Convert.ToString(TxtOperator.Text);

                if (IsValidatData())
                {
                    TxtResult.Text = Calculate(operand1, operande2, oper).ToString();
                    TxtOperand1.Focus();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message , ex.GetType().ToString());
            }
        }
        
       // Method that clear the text box if operands changed
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
