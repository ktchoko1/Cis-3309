using System;
using System.Windows.Forms;

namespace MatrixAssignment
{
    public partial class FrmMain : Form
    {
        // Declare matrix varable
        Matrix A;
        Matrix B;
        Matrix C;

        public FrmMain()
        {
            InitializeComponent();
            rdbMultiply.Checked = true;
        }

        //populate matrix A
        private void BtnMakeMatrixA_Click(object sender, EventArgs e)
        {
            A = new Matrix(Convert.ToInt32(TxtMatrixARows.Text), Convert.ToInt32(TxtMatrixACols.Text));
            A.PopulateRand();

            LblMatrixAText.Text = A.ToString();

        }

        // populate matrix b
        private void BtnMakeMatrixB_Click(object sender, EventArgs e)
        {
            try
            {
                B = new Matrix(Convert.ToInt32(TxtMatrixBRows.Text), Convert.ToInt32(TxtMatrixBCols.Text));
                B.PopulateRand();

                LblMatrixBText.Text = A.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.GetType() + "\n\n"  + "\n" + ex.StackTrace, "Exception");
            }
          

        }

        //get the identity matix
        private void BtnMakeBIdentity_Click(object sender, EventArgs e)
        {
            try
            {
                B = new Matrix(Convert.ToInt32(TxtMatrixBRows.Text), Convert.ToInt32(TxtMatrixBCols.Text));
                B.MakeId();

                LblMatrixBText.Text = B.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.GetType() + "\n\n" + "\n" + ex.StackTrace, "Exception");
            }
           

        }

        // Calculate the matrix results
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (rdbAdd.Checked)
            {
                C = A + B;
                LblMatrixCText.Text = C.ToString();

            }
            else if (rdbSubstract.Checked)
            {
                C = A - B;
                LblMatrixCText.Text = C.ToString();

            }
            else if (rdbMultiply.Checked)
            {
                C = A * B;
                LblMatrixCText.Text = C.ToString();

            }
            
        }

        // validate inpute from the text box
        private bool IsValidData(TextBox t)
        {
            return true;
        }

        private void BtnClearMatrix_Click(object sender, EventArgs e)
        {
            A = null;
            B = null;
            C = null;

            LblMatrixAText.Text = "";
            LblMatrixBText.Text = "";
            LblMatrixCText.Text = "";
        }

        // Exit the form
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
