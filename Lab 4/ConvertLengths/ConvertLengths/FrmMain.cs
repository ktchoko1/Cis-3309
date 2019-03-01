using System;
using System.Windows.Forms;

namespace ConvertLengths
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        string[,] conversionTable = {

            {"Miles to kilometers", "Miles", "Kilometers", "1.6093"},
            {"Kilometers to miles", "Kilometers", "Miles", "0.6214"},
            {"Feet to meters", "Feet", "Meters", "0.3048"},
            {"Meters to feet", "Meters", "Feet", "3.2808"},
            {"Inches to centimeters", "Inches", "Centimeters", "2.54"},
            {"Centimeters to inches", "Centimeters", "Inches", "0.3937"}
        };

        private void LoadDataToComboBox()
        {
            for (int i = 0; i < conversionTable.GetLength(0); i++)
            {
                CmbConversion.Items.Add(conversionTable[i, 0]);
            }
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
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }

            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (IsDecimal(TxtLength, "length") && IsPresent(TxtLength, "length"))

            {
                decimal fromLength = Convert.ToDecimal(TxtLength.Text);
                decimal conversionUnit = Convert.ToDecimal(conversionTable[CmbConversion.SelectedIndex, 3]);
                LblCalculatedLength.Text = (fromLength * conversionUnit).ToString("f2");
            }
            else
            {
                MessageBox.Show("Please enter proper data.");
            }

        }
        private void CmbConversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblFromLength.Text = conversionTable[CmbConversion.SelectedIndex, 1];
            LblToLength.Text = conversionTable[CmbConversion.SelectedIndex, 2];
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
