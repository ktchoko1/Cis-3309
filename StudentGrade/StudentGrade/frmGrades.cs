using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentGrade
{
    public partial class frmGrades : Form
    {
        public frmGrades()
        {
            InitializeComponent();
        }

        private void Grades_Load(object sender, EventArgs e)
        {

        }

        private void bntCalculate_Click(object sender, EventArgs e)
        {
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);
            string letterGrade = "";

            if (numberGrade >= 88)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 87)
            {

                letterGrade = "B";
            }
            else if (numberGrade >= 70 && numberGrade <= 79)
            {

                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 69) {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

             txtLetterGrade.Text = letterGrade;
             txtNumberGrade.Focus();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
