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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result :";
            // 
            // BMI_num
            // 
            this.BMI_num.AutoSize = true;
            this.BMI_num.Location = new System.Drawing.Point(369, 326);
            this.BMI_num.Name = "BMI_num";
            this.BMI_num.Size = new System.Drawing.Size(46, 20);
            this.BMI_num.TabIndex = 4;
            this.BMI_num.Text = "label5";
            // 
            // BMI_text
            // 
            this.BMI_text.AutoSize = true;
            this.BMI_text.Location = new System.Drawing.Point(429, 326);
            this.BMI_text.Name = "BMI_text";
            this.BMI_text.Size = new System.Drawing.Size(46, 20);
            this.BMI_text.TabIndex = 5;
            this.BMI_text.Text = "label6";
            // 
            // Cal_Button
            // 
            this.Cal_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cal_Button.Location = new System.Drawing.Point(299, 376);
            this.Cal_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cal_Button.Name = "Cal_Button";
            this.Cal_Button.Size = new System.Drawing.Size(105, 29);
            this.Cal_Button.TabIndex = 6;
            this.Cal_Button.Text = "Calculate";
            this.Cal_Button.UseVisualStyleBackColor = true;
            this.Cal_Button.Click += new System.EventHandler(this.Cal_Button_Click);
            // 
            // h_textBox
            // 
            this.h_textBox.Location = new System.Drawing.Point(369, 213);
            this.h_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.h_textBox.Name = "h_textBox";
            this.h_textBox.Size = new System.Drawing.Size(100, 27);
            this.h_textBox.TabIndex = 7;
            // 
            // w_textBox
            // 
            this.w_textBox.Location = new System.Drawing.Point(369, 263);
            this.w_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.w_textBox.Name = "w_textBox";
            this.w_textBox.Size = new System.Drawing.Size(100, 27);
            this.w_textBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "cm.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "kg.";
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(419, 376);
            this.Clear_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(75, 29);
            this.Clear_button.TabIndex = 11;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.pictureBox1);
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
            this.Font = new System.Drawing.Font("Kanit", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

