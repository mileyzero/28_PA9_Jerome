﻿namespace _28_PA9_Jerome
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
            this.btn_Convert = new System.Windows.Forms.Button();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.rb_US = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Converted = new System.Windows.Forms.TextBox();
            this.rb_Yen = new System.Windows.Forms.RadioButton();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(578, 189);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 0;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(306, 108);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(194, 20);
            this.txt_Amount.TabIndex = 1;
            // 
            // rb_US
            // 
            this.rb_US.AutoSize = true;
            this.rb_US.Location = new System.Drawing.Point(315, 158);
            this.rb_US.Name = "rb_US";
            this.rb_US.Size = new System.Drawing.Size(75, 17);
            this.rb_US.TabIndex = 2;
            this.rb_US.TabStop = true;
            this.rb_US.Text = "US Dollars";
            this.rb_US.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected Currency:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Converted Amount:";
            // 
            // txt_Converted
            // 
            this.txt_Converted.Location = new System.Drawing.Point(306, 244);
            this.txt_Converted.Name = "txt_Converted";
            this.txt_Converted.Size = new System.Drawing.Size(194, 20);
            this.txt_Converted.TabIndex = 6;
            // 
            // rb_Yen
            // 
            this.rb_Yen.AutoSize = true;
            this.rb_Yen.Location = new System.Drawing.Point(315, 189);
            this.rb_Yen.Name = "rb_Yen";
            this.rb_Yen.Size = new System.Drawing.Size(93, 17);
            this.rb_Yen.TabIndex = 7;
            this.rb_Yen.TabStop = true;
            this.rb_Yen.Text = "Japanese Yen";
            this.rb_Yen.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(578, 237);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.rb_Yen);
            this.Controls.Add(this.txt_Converted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_US);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.btn_Convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.RadioButton rb_US;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Converted;
        private System.Windows.Forms.RadioButton rb_Yen;
        private System.Windows.Forms.Button btn_Clear;
    }
}

