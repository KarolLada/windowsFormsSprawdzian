using System;
using System.Diagnostics.Eventing.Reader;
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
            int hours = 0;
            try
            {
                hours = int.Parse(hourText.Text);
                if (hours < 1 || hours > 20)
                {
                    resultLabel.Text = "Liczba godzin musi być w zakresie od 1 do 20.";
                    return;
                }
                int fee = calculateParkingFee(hours);
                resultLabel.Text = $"Do zapłaty: {fee} zł";
            }
            catch (FormatException)
            {
                if (float.TryParse(hourText.Text, out float hour))
                {
                    resultLabel.Text = "Proszę wprowadzić liczbę całkowitą.";
                } else if (string.IsNullOrWhiteSpace(hourText.Text))
                {
                    resultLabel.Text = "Pole nie może być puste.";
                }
                else
                {
                    resultLabel.Text = "Proszę wprowadzić poprawną liczbę godzin.";
                }
            }
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
