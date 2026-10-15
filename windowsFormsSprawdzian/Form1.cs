using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            else if (hours <= 5)
            {
                fee = 3 * 5 + (hours - 3) * 4; 
            }

            return fee;
        }
    }
}
