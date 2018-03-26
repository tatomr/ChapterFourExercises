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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the TextBoxes and the decisionLabel.
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLable.Text = "";

            //Reset the focus.
            salaryTextBox.Focus();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Name constants
                const decimal MINIMUM_SALARY = 40000m;
                const int MINIMUM_YEARS_ON_JOB = 2;

                //Local variables
                decimal salary;
                int yearsOnJob;

                //Get the salary and years on the job.
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                //Determine whether the user qualifies.
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        //The user qualifies 
                        decisionLable.Text = "You qualify for the loan.";

                    }
                    else
                    {
                        //The user does not qualify.
                        decisionLable.Text = "Minimum years at currect job not met.";
                    }
                }
                else
                {
                    //The user does not qualify.
                    decisionLable.Text = "Minimum salary requirement not met.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }
    }

