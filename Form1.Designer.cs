﻿namespace bar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtlabels = new TextBox();
            txtValues = new TextBox();
            bar1 = new bar();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.NavajoWhite;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(434, 55);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(134, 40);
            button1.TabIndex = 0;
            button1.Text = "Create Chart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter Labels ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 80);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter Values";
            // 
            // txtlabels
            // 
            txtlabels.BackColor = Color.LightSteelBlue;
            txtlabels.Location = new Point(127, 43);
            txtlabels.Margin = new Padding(2);
            txtlabels.Name = "txtlabels";
            txtlabels.Size = new Size(249, 23);
            txtlabels.TabIndex = 3;
            // 
            // txtValues
            // 
            txtValues.BackColor = Color.LightSteelBlue;
            txtValues.Location = new Point(127, 80);
            txtValues.Margin = new Padding(2);
            txtValues.Name = "txtValues";
            txtValues.Size = new Size(249, 23);
            txtValues.TabIndex = 4;
            // 
            // bar1
            // 
            bar1.Location = new Point(10, 127);
            bar1.Margin = new Padding(1);
            bar1.Name = "bar1";
            bar1.Size = new Size(680, 257);
            bar1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 10);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(274, 15);
            label3.TabIndex = 6;
            label3.Text = "Please enter all the values separated by commas (,)";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 394);
            Controls.Add(label3);
            Controls.Add(bar1);
            Controls.Add(txtValues);
            Controls.Add(txtlabels);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtlabels;
        private TextBox txtValues;
        private bar bar1;
        private Label label3;
    }
}