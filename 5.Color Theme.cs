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
    public partial class colorThemeForm : Form
    {
        public colorThemeForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowRadioButton.Checked)
            {
                //When selected form back color is yellow
                this.BackColor = Color.Yellow;
            }

        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (redRadioButton.Checked)
            {
                //When selected form back color is red
                this.BackColor = Color.Red;
            }
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //When selected form back color is white
            if (whiteRadioButton.Checked)
            {
                //When selected form back color is white
                this.BackColor = Color.White;
            }
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (normalRadioButton.Checked)
            {
                //When selected form back color to original color
                this.BackColor = SystemColors.Control;
            }
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }
    }
}
