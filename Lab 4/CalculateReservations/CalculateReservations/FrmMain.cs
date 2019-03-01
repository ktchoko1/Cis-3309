using System;
using System.Windows.Forms;


namespace CalculateReservations
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public bool IsValidData()
        {
            if (IsDateTime(TxtArrivalDate, "Arrival Date") && IsDateTime(TxtDepartureDate, "Departure Date") &&
                IsWithinRange(TxtArrivalDate, "Arrival Date", DateTime.Today, DateTime.MaxValue) && 
                IsWithinRange(TxtDepartureDate, "Departure Date", DateTime.Today, DateTime.MaxValue))
            {
                return true;
            }
            return false;
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



        public bool IsDateTime(TextBox textBox, string name)
        {
            DateTime d = new DateTime();
            return DateTime.TryParse(textBox.Text, out d);
        }
       
        public bool IsWithinRange(TextBox textBox, string name, DateTime min, DateTime max)
        {
            DateTime d = Convert.ToDateTime(textBox.Text);
            //today is the min date
            min = DateTime.Today.Date;

            // max day is up to 5years
            max = min.AddDays(1826);   
            
            return (min <= d) && (d <= max);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                DateTime arrivalDate = Convert.ToDateTime(TxtArrivalDate.Text);
                DateTime departureDate = Convert.ToDateTime(TxtDepartureDate.Text);

                double nights = (departureDate - arrivalDate).TotalDays;
                double nightCount = 0;
                double price = 0;

                while (nightCount < nights)

                {

                    //MessageBox.Show(arrivalDate.AddDays(nightCount).DayOfWeek.ToString());
                    if (arrivalDate.AddDays(nightCount).DayOfWeek.Equals(DayOfWeek.Friday) || arrivalDate.AddDays(nightCount).DayOfWeek.Equals(DayOfWeek.Saturday))
                    {
                        price += 150;
                    }
                    else
                    {
                        price += 120;
                    }
                    nightCount++;

                }

                double avgPrice = price / nights;

                TxtNumberOfNights.Text = nights.ToString();
                TxtTotalPrice.Text = price.ToString("c2");
                TxtAvgPricePerNight.Text = avgPrice.ToString("c2");

            }
            else
            {
                DateTime today = DateTime.Today;
                MessageBox.Show("Please Enter Valid Dates");
                TxtArrivalDate.Text = today.Date.ToShortDateString();
                TxtDepartureDate.Text = today.AddDays(3).Date.ToShortDateString();
                TxtArrivalDate.Focus();

            }

        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            TxtArrivalDate.Text = today.Date.ToShortDateString();
            TxtDepartureDate.Text = today.AddDays(3).Date.ToShortDateString();
        }

        //Method that clear all text box
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
