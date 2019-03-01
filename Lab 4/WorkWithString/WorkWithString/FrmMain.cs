using System;
using System.Linq;
using System.Windows.Forms;

namespace WorkWithString
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //declare variable
        private string userName;
        private string domain;

        private void ParseEmail(string e)
        {
            userName = e.Split('@')[0].Trim();
            domain = e.Split('@')[1].Trim();
        }

        private void BtnParse_Click(object sender, EventArgs e)
        {
            if (TxtEmail.Text.Contains('@'))
            {
                string email = TxtEmail.Text.Trim();
                ParseEmail(email);
                MessageBox.Show("username: " + userName + "\ndomain: " + domain);
            }
            else
            {
                MessageBox.Show("Please enter a valid email address.");
                TxtEmail.Clear();
                TxtEmail.Focus();
            }
        }

        private void BtnFormat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("City, State, Zip: " + TxtCity.Text + ", " + TxtState.Text.ToUpper() + ", " + TxtZipCode.Text);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
