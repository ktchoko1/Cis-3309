using System;
using System.Windows.Forms;

namespace ScoreArray
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        decimal[] scoreArr  = new decimal [20];
        int scoreCount = 0;
        decimal total = 0m;
       




        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal score = Convert.ToDecimal(TxtScore.Text);
                //put score into the array
                scoreArr[scoreCount] = score;
                scoreCount++;

                // Calculate the total
                total += score;

                // emptied the score textbox
                TxtScore.Text = "";
               
                // Calculate the average score 
                    decimal average = (total / scoreCount);
                    TxtAverage.Text = average.ToString();
 
                    

            }
            catch(FormatException)
            {
                MessageBox.Show("invalid input, please enter a number");
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("You cannot enter anymore score");
            }
            finally
            {
                // get score total
                TxtSoreTotal.Text = total.ToString();

                //get number counted so far
                TxtScoreCount.Text = scoreCount.ToString();

                // set the focuson the score textbox
                TxtScore.Focus();

            }
           
 
        }

       
      // Method that clear all
        private void BtnClearScore_Click(object sender, EventArgs e)
        {
            scoreCount = 0;
            scoreArr = new decimal[20];
            TxtScore.Text = "";
            TxtSoreTotal.Text = "";
            TxtScoreCount.Text = "";
            TxtAverage.Text = "";
            TxtScore.Focus();
            

        }

        private void BtnDisplayScore_Click(object sender, EventArgs e)
        {
            //sort the score array
            Array.Sort(scoreArr);
            string scoreList = "";
            for(int i = 0; i < scoreArr.Length; i++)
            {
                if(scoreArr[i] != 0)
                {
                    scoreList += scoreArr[i].ToString() + "\n";
                }
            }

            MessageBox.Show(scoreList, "Sorted scores");

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
