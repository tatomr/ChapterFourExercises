﻿namespace Ch4_Tutorials
{
    partial class Form1
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
            this.testScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.test3promptLabel = new System.Windows.Forms.Label();
            this.test2promptLabel = new System.Windows.Forms.Label();
            this.test1promptLabel = new System.Windows.Forms.Label();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.testScoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // testScoreGroupBox
            // 
            this.testScoreGroupBox.Controls.Add(this.outputDescriptionLabel);
            this.testScoreGroupBox.Controls.Add(this.averageLabel);
            this.testScoreGroupBox.Controls.Add(this.test3promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test2promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test1promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test3TextBox);
            this.testScoreGroupBox.Controls.Add(this.test2TextBox);
            this.testScoreGroupBox.Controls.Add(this.test1TextBox);
            this.testScoreGroupBox.Location = new System.Drawing.Point(18, 18);
            this.testScoreGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testScoreGroupBox.Name = "testScoreGroupBox";
            this.testScoreGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testScoreGroupBox.Size = new System.Drawing.Size(390, 242);
            this.testScoreGroupBox.TabIndex = 0;
            this.testScoreGroupBox.TabStop = false;
            this.testScoreGroupBox.Text = "Enter Three Test Scores";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(99, 186);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(68, 20);
            this.outputDescriptionLabel.TabIndex = 7;
            this.outputDescriptionLabel.Text = "Average";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(183, 178);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(149, 34);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test3promptLabel
            // 
            this.test3promptLabel.AutoSize = true;
            this.test3promptLabel.Location = new System.Drawing.Point(57, 135);
            this.test3promptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test3promptLabel.Name = "test3promptLabel";
            this.test3promptLabel.Size = new System.Drawing.Size(108, 20);
            this.test3promptLabel.TabIndex = 5;
            this.test3promptLabel.Text = "Test Score #3";
            // 
            // test2promptLabel
            // 
            this.test2promptLabel.AutoSize = true;
            this.test2promptLabel.Location = new System.Drawing.Point(57, 89);
            this.test2promptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test2promptLabel.Name = "test2promptLabel";
            this.test2promptLabel.Size = new System.Drawing.Size(108, 20);
            this.test2promptLabel.TabIndex = 4;
            this.test2promptLabel.Text = "Test Score #2";
            // 
            // test1promptLabel
            // 
            this.test1promptLabel.AutoSize = true;
            this.test1promptLabel.Location = new System.Drawing.Point(57, 46);
            this.test1promptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test1promptLabel.Name = "test1promptLabel";
            this.test1promptLabel.Size = new System.Drawing.Size(108, 20);
            this.test1promptLabel.TabIndex = 3;
            this.test1promptLabel.Text = "Test Score #1";
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(183, 129);
            this.test3TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(148, 26);
            this.test3TextBox.TabIndex = 2;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(183, 83);
            this.test2TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(148, 26);
            this.test2TextBox.TabIndex = 1;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(183, 40);
            this.test1TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(148, 26);
            this.test1TextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(96, 269);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 80);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Caclulate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(218, 269);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 35);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(218, 314);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 369);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.testScoreGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Test Score Average";
            this.testScoreGroupBox.ResumeLayout(false);
            this.testScoreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox testScoreGroupBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label test3promptLabel;
        private System.Windows.Forms.Label test2promptLabel;
        private System.Windows.Forms.Label test1promptLabel;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

