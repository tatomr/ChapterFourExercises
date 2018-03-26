namespace Ch4_Tutorials
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateButton1 = new System.Windows.Forms.Button();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.exitButton3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hoursWorkedTBox1 = new System.Windows.Forms.TextBox();
            this.payTBox3 = new System.Windows.Forms.TextBox();
            this.hourlyPaytextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours worked:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hourly pay rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gross Pay:";
            // 
            // calculateButton1
            // 
            this.calculateButton1.Location = new System.Drawing.Point(94, 232);
            this.calculateButton1.Name = "calculateButton1";
            this.calculateButton1.Size = new System.Drawing.Size(101, 65);
            this.calculateButton1.TabIndex = 3;
            this.calculateButton1.Text = "Calculate Gross Pay";
            this.calculateButton1.UseVisualStyleBackColor = true;
            this.calculateButton1.Click += new System.EventHandler(this.calculateButton1_Click);
            // 
            // clearButton2
            // 
            this.clearButton2.Location = new System.Drawing.Point(264, 231);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(113, 66);
            this.clearButton2.TabIndex = 4;
            this.clearButton2.Text = "Clear";
            this.clearButton2.UseVisualStyleBackColor = true;
            this.clearButton2.Click += new System.EventHandler(this.clearButton2_Click);
            // 
            // exitButton3
            // 
            this.exitButton3.Location = new System.Drawing.Point(432, 231);
            this.exitButton3.Name = "exitButton3";
            this.exitButton3.Size = new System.Drawing.Size(115, 66);
            this.exitButton3.TabIndex = 5;
            this.exitButton3.Text = "Exit";
            this.exitButton3.UseVisualStyleBackColor = true;
            this.exitButton3.Click += new System.EventHandler(this.exitButton3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 7;
            // 
            // hoursWorkedTBox1
            // 
            this.hoursWorkedTBox1.Location = new System.Drawing.Point(250, 46);
            this.hoursWorkedTBox1.Name = "hoursWorkedTBox1";
            this.hoursWorkedTBox1.Size = new System.Drawing.Size(171, 26);
            this.hoursWorkedTBox1.TabIndex = 0;
            // 
            // payTBox3
            // 
            this.payTBox3.Location = new System.Drawing.Point(250, 160);
            this.payTBox3.Name = "payTBox3";
            this.payTBox3.Size = new System.Drawing.Size(171, 26);
            this.payTBox3.TabIndex = 2;
            // 
            // hourlyPaytextBox2
            // 
            this.hourlyPaytextBox2.Location = new System.Drawing.Point(250, 98);
            this.hourlyPaytextBox2.Name = "hourlyPaytextBox2";
            this.hourlyPaytextBox2.Size = new System.Drawing.Size(171, 26);
            this.hourlyPaytextBox2.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 366);
            this.Controls.Add(this.hourlyPaytextBox2);
            this.Controls.Add(this.payTBox3);
            this.Controls.Add(this.hoursWorkedTBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitButton3);
            this.Controls.Add(this.clearButton2);
            this.Controls.Add(this.calculateButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateButton1;
        private System.Windows.Forms.Button clearButton2;
        private System.Windows.Forms.Button exitButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hoursWorkedTBox1;
        private System.Windows.Forms.TextBox payTBox3;
        private System.Windows.Forms.TextBox hourlyPaytextBox2;
    }
}