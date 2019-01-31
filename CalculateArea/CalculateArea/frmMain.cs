using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateArea
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get the length value from the user
            double numLength = Convert.ToDouble(txtLength.Text);

            // get the width value from the user
            double numWidth = Convert.ToDouble(txtWidth.Text);

            // Declair and initilize the area and the length
            double numArea = 0;
            double numPerimeter = 0;

            // Calculate the area
            numArea = numLength * numWidth;
            txtArea.Text = Convert.ToString(numArea);

            // Calculate the Perimeter

            numPerimeter = 2 * (numLength + numWidth);
            txtPerimeter.Text = Convert.ToString(numPerimeter);

            txtLength.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
