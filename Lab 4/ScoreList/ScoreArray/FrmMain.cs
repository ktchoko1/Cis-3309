using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScoreArray
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // Declare variable

        decimal total = 0m;
        List<decimal> scoreList = new List<decimal>();

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try

            {

                if (IsValidData())

                {
                    // get the number
                    decimal score = Convert.ToDecimal(TxtScore.Text);

                    // Add the number to the list
                    scoreList.Add(score);

                    //Calculate the total
                    total += score;
 
                    //Calculate the average
                    decimal average = total / scoreList.Count;

                    // Emptied the score text bosx
                    TxtScore.Text = "";

                    // Get all the string vakues
                    TxtSoreTotal.Text = total.ToString();
                    TxtScoreCount.Text = scoreList.Count.ToString();
                    TxtAverage.Text = average.ToString();

                    // Set the focus on score text box
                    TxtScore.Focus();

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");

            }

        }

        private void BtnDisplayScore_Click(object sender, EventArgs e)
        {
            // sort the list
            scoreList.Sort();

            string scoresString = "";

            foreach (int i in scoreList)

                if (i != 0)

                {
                    scoresString += i.ToString() + "\n";

                }

            MessageBox.Show(scoresString, "Sorted Scores");

            TxtScore.Focus();

        }

        private void BtnClearScore_Click(object sender, EventArgs e)
        {
            total = 0;

            TxtScore.Text = "";

            TxtSoreTotal.Text = "";

            TxtScoreCount.Text = "";

            TxtAverage.Text = "";

            scoreList = new List<decimal>();
            TxtScore.Focus();

        }
        public bool IsValidData()

        {

            return

                // Validate the Score text box

                IsPresent(TxtScore, "Score") && IsDecimal(TxtScore, "Score") && IsWithinRange(TxtScore, "Score", 01, 100);

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
            decimal number = 0;
            if (Decimal.TryParse(textBox.Text, out number))

            {
                return true;
            }

            else

            {
                MessageBox.Show(name + " must be a valid integer.", "Entry Error");
                textBox.Focus();
                return false;

            }

        }



        public bool IsWithinRange(TextBox textBox, string name,

            decimal min, decimal max)

        {

            decimal number = Convert.ToDecimal(textBox.Text);

            if (number < min || number > max)

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
    }
}
