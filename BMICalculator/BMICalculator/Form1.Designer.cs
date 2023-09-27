namespace BMICalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BMI_num = new System.Windows.Forms.Label();
            this.BMI_text = new System.Windows.Forms.Label();
            this.Cal_Button = new System.Windows.Forms.Button();
            this.h_textBox = new System.Windows.Forms.TextBox();
            this.w_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result :";
            // 
            // BMI_num
            // 
            this.BMI_num.AutoSize = true;
            this.BMI_num.Location = new System.Drawing.Point(390, 220);
            this.BMI_num.Name = "BMI_num";
            this.BMI_num.Size = new System.Drawing.Size(44, 16);
            this.BMI_num.TabIndex = 4;
            this.BMI_num.Text = "label5";
            // 
            // BMI_text
            // 
            this.BMI_text.AutoSize = true;
            this.BMI_text.Location = new System.Drawing.Point(450, 220);
            this.BMI_text.Name = "BMI_text";
            this.BMI_text.Size = new System.Drawing.Size(44, 16);
            this.BMI_text.TabIndex = 5;
            this.BMI_text.Text = "label6";
            // 
            // Cal_Button
            // 
            this.Cal_Button.Location = new System.Drawing.Point(320, 260);
            this.Cal_Button.Name = "Cal_Button";
            this.Cal_Button.Size = new System.Drawing.Size(105, 23);
            this.Cal_Button.TabIndex = 6;
            this.Cal_Button.Text = "Calculate";
            this.Cal_Button.UseVisualStyleBackColor = true;
            this.Cal_Button.Click += new System.EventHandler(this.Cal_Button_Click);
            // 
            // h_textBox
            // 
            this.h_textBox.Location = new System.Drawing.Point(390, 130);
            this.h_textBox.Name = "h_textBox";
            this.h_textBox.Size = new System.Drawing.Size(100, 22);
            this.h_textBox.TabIndex = 7;
            // 
            // w_textBox
            // 
            this.w_textBox.Location = new System.Drawing.Point(390, 170);
            this.w_textBox.Name = "w_textBox";
            this.w_textBox.Size = new System.Drawing.Size(100, 22);
            this.w_textBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "cm.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "kg.";
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(440, 260);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(75, 23);
            this.Clear_button.TabIndex = 11;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.w_textBox);
            this.Controls.Add(this.h_textBox);
            this.Controls.Add(this.Cal_Button);
            this.Controls.Add(this.BMI_text);
            this.Controls.Add(this.BMI_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BMI_num;
        private System.Windows.Forms.Label BMI_text;
        private System.Windows.Forms.Button Cal_Button;
        private System.Windows.Forms.TextBox h_textBox;
        private System.Windows.Forms.TextBox w_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Clear_button;
    }
}

