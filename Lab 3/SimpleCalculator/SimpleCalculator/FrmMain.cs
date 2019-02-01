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
        // Method that calculate the result

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                decimal operand1 = Convert.ToDecimal(TxtOperand1.Text);
                decimal operande2 = Convert.ToDecimal(TxtOperand2.Text);
                string oper = Convert.ToString(TxtOperator.Text);

                    TxtResult.Text = Calculate(operand1, operande2, oper).ToString();
                    TxtOperand1.Focus();
                

            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter the valide input", "Enty Error");
                 
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Please do not divide by 0", "Enty Error");
                 

            }
            catch (OverflowException)
            {
                MessageBox.Show("The number entered is out of range!" , "Enty Error");
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + ex.StackTrace, "Exception");
            }
             

        }
        
        // Method that clear the result text box if the operands changed

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
