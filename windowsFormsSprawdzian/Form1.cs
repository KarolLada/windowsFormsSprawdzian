using System;
using System.Windows.Forms;

namespace windowsFormsSprawdzian
{
    public partial class parkingForm : Form
    {
        public parkingForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
        }

        public int calculateParkingFee(int hours)
        {
            int fee = 0;

            if (hours <= 3)
            {
                fee = hours * 5;
            }
            else
            {
                fee = 3 * 5 + (hours - 3) * 4;
            }

            return fee;
        }
    }
}
