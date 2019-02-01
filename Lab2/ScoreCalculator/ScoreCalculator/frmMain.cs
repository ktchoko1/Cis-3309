using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class frmMain : Form
    {
        // Declar and initialize score and count
        decimal scoreTotal = 0;
        decimal scoreCount = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //accumulate the tota  score
            scoreTotal += Convert.ToDecimal(txtScore.Text);

            // count the number of score enter
            scoreCount++;
          // emptied the score texbox
            txtScore.Text = "";

            //Convert number into string
            txtScoreTotal.Text = scoreTotal.ToString();
            txtScoreCount.Text = scoreCount.ToString();
            txtAverage.Text = (scoreTotal / scoreCount).ToString("f2");
            

        }

      

        private void btnClearScore_Click(object sender, EventArgs e)
        {
            scoreCount = 0;
            scoreTotal = 0;
            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
