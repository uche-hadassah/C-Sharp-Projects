﻿namespace FormsTest_1
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 43);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 0;
            label1.Text = "Label";
            label1.Click += label1_Click_2;
            // 
            // button1
            // 
            button1.Location = new Point(112, 96);
            button1.Name = "button1";
            button1.Size = new Size(135, 34);
            button1.TabIndex = 1;
            button1.Text = "RED";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.Location = new Point(112, 157);
            button2.Name = "button2";
            button2.Size = new Size(135, 34);
            button2.TabIndex = 2;
            button2.Text = "GREEN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(112, 222);
            button3.Name = "button3";
            button3.Size = new Size(135, 34);
            button3.TabIndex = 3;
            button3.Text = "BLUE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(112, 287);
            button4.Name = "button4";
            button4.Size = new Size(135, 34);
            button4.TabIndex = 4;
            button4.Text = "YELLOW";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(112, 351);
            button5.Name = "button5";
            button5.Size = new Size(135, 34);
            button5.TabIndex = 5;
            button5.Text = "BROWN";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(112, 419);
            button6.Name = "button6";
            button6.Size = new Size(135, 34);
            button6.TabIndex = 6;
            button6.Text = "BLACK";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(69, 477);
            button7.Name = "button7";
            button7.Size = new Size(209, 46);
            button7.TabIndex = 7;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 562);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
