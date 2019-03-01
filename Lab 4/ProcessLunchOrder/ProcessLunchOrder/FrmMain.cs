using System;
using System.Windows.Forms;

namespace ProcessLunchOrder
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ClearTotal()
        {
            LblOrderTotalCalculated.Text = "";
            LblSubtotalCalcualted.Text = "";
            LblTaxCalculated.Text = "";
            
        }

        private void ClearAllAddons()
        {
            foreach(CheckBox c in GboAddOn.Controls)
            {
                c.Checked = false;

            }
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0;
            decimal salestax = 0.0775m;
            decimal ordertotal = 0;
            decimal taxPaid = 0;

            if (RdbHumberger.Checked)
            {
                subtotal += 6.95m;

                foreach (CheckBox c in GboAddOn.Controls)
                {
                    if (c.Checked)
                    {
                        subtotal += 0.75m;
                    }
                }
                 taxPaid = subtotal * salestax;
                ordertotal = subtotal + taxPaid ;
            }
            else if (RdbPizza.Checked)
            {
                subtotal += 5.95m;

                foreach (CheckBox c in GboAddOn.Controls)
                {
                    if (c.Checked)
                    {
                        subtotal += 0.50m;
                    }
                }
                taxPaid = subtotal * salestax;
                ordertotal = subtotal + taxPaid;
            }
            else if (RdbSalad.Checked)
            {
                subtotal += 4.95m;

                foreach (CheckBox c in GboAddOn.Controls)
                {
                    if (c.Checked)
                    {
                        subtotal += 0.25m;
                    }
                }
                taxPaid = subtotal * salestax;
                ordertotal = subtotal + taxPaid;
            }
            else
            {

            }
            
            LblSubtotalCalcualted.Text = subtotal.ToString("c2");
            LblTaxCalculated.Text = taxPaid.ToString("c2");
            LblOrderTotalCalculated.Text = ordertotal.ToString("c2");
            



    }

       

        private void RdbHumberger_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the checked box
            ClearAllAddons();

            //Clear total
            ClearTotal();

            ChbLettuceTomate.Text = "Lettuce, Tomato, Onions";
            ChbKetchMustard.Text = "Ketchup, Mustard, and Mayo";
            ChbFrienchFries .Text = "French Fries";
            GboAddOn.Text = "Add-ons $0.75/each";

        }

        private void RdbPizza_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the checked box
            ClearAllAddons();

            //Clear total
            ClearTotal();

            ChbLettuceTomate.Text = "Pepperoni";
            ChbKetchMustard.Text = "Sausage";
            ChbFrienchFries.Text = "Olives";
            GboAddOn.Text = "Add-ons $0.50/each";

        }

        private void RdbSalad_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the checked box
            ClearAllAddons();

            //Clear total
            ClearTotal();

            ChbLettuceTomate.Text = "Croutons";
            ChbKetchMustard.Text = "Bacon Bits";
            ChbFrienchFries.Text = "Bread Sticks";
            GboAddOn.Text = "Add-ons $0.25/each";

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
