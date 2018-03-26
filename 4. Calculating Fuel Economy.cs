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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //CLose the form
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;   //To hold miles driven
            double gallons; // To hold gallons used
            double mpg;     // To hold MPG

            // Validation the milesTextbox control.
            if (double.TryParse(milesTextBox.Text, out miles))
            {

                //Validation the gallonsTextBox Control
                if (double.TryParse(gallonsTextBox.Text, out gallons))
                {
                    // Calculate MPG
                    mpg = miles / gallons;

                    //Display the MPG in the mpgLable control.
                    mpgLabel.Text = mpg.ToString("n1");
                }
               else
                {
                    //Display an error message for gallonsTextBox.
                    MessageBox.Show("Invalid input for gallons.");
                }
            }
            else
            {
                //Display an error message for milesTextBox.
                MessageBox.Show("Invalid input for miles.");
            }
        }
    }
}
