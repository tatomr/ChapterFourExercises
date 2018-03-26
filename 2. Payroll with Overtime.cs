using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch4_Tutorials
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void calculateButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //Named constants
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                // local variables
                decimal hoursWorked; //number of hours worked
                decimal hourlyPayRate; //Hourly pay rate
                decimal basePay; //Pay not included overtime
                decimal overtimeHours; //overtime hours worked
                decimal overtimePay; //overtime pay
                decimal grossPay; //total gross pay

                //Get the hours worked and hourly pay rate.
                hoursWorked = decimal.Parse(hoursWorkedTBox1.Text);
                hourlyPayRate = decimal.Parse(hourlyPaytextBox2.Text);

                //Determine the gross pay.
                if (hoursWorked > BASE_HOURS)
                {
                    //Calculate the base pay (without overtime)
                    basePay = hourlyPayRate * BASE_HOURS;

                    // Calculate the number of overtime hours
                    overtimeHours = hoursWorked - BASE_HOURS;

                    //Calculate the overtime pay
                    overtimePay = overtimeHours * hourlyPayRate *
                        OT_MULTIPLIER;

                    //Calculate the gross pay.
                    grossPay = basePay + overtimePay;
                }
                else
                {
                    // Calculate the gross pay.
                    grossPay = hoursWorked * hourlyPayRate;
                }

                // Display the gross pay.
                payTBox3.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton2_Click(object sender, EventArgs e)
        {
            //Clear the TextBoxes and gross pay label.
            hoursWorkedTBox1.Text  = "";
            hourlyPaytextBox2.Text = "";
            payTBox3.Text = "";

            //Reset the focus.
            hoursWorkedTBox1.Focus();
            
            
        }

        private void exitButton3_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
