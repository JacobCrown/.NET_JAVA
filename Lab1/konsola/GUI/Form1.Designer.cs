﻿namespace GUI
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
            this.tB_N = new System.Windows.Forms.TextBox();
            this.tB_Seed = new System.Windows.Forms.TextBox();
            this.tB_C = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.tB_big = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "n:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "C:";
            // 
            // tB_N
            // 
            this.tB_N.Location = new System.Drawing.Point(62, 54);
            this.tB_N.Name = "tB_N";
            this.tB_N.Size = new System.Drawing.Size(100, 22);
            this.tB_N.TabIndex = 3;
            this.tB_N.TextChanged += new System.EventHandler(this.tB_N_TextChanged);
            // 
            // tB_Seed
            // 
            this.tB_Seed.Location = new System.Drawing.Point(62, 123);
            this.tB_Seed.Name = "tB_Seed";
            this.tB_Seed.Size = new System.Drawing.Size(100, 22);
            this.tB_Seed.TabIndex = 4;
            this.tB_Seed.TextChanged += new System.EventHandler(this.tB_Seed_TextChanged);
            // 
            // tB_C
            // 
            this.tB_C.Location = new System.Drawing.Point(62, 193);
            this.tB_C.Name = "tB_C";
            this.tB_C.Size = new System.Drawing.Size(100, 22);
            this.tB_C.TabIndex = 5;
            this.tB_C.TextChanged += new System.EventHandler(this.tB_C_TextChanged);
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.LightYellow;
            this.Button.Location = new System.Drawing.Point(86, 277);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(76, 72);
            this.Button.TabIndex = 7;
            this.Button.Text = "OK";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // tB_big
            // 
            this.tB_big.BackColor = System.Drawing.Color.Lavender;
            this.tB_big.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_big.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_big.Location = new System.Drawing.Point(253, 12);
            this.tB_big.Multiline = true;
            this.tB_big.Name = "tB_big";
            this.tB_big.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_big.Size = new System.Drawing.Size(383, 385);
            this.tB_big.TabIndex = 8;
            this.tB_big.TextChanged += new System.EventHandler(this.tB_big_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(682, 433);
            this.Controls.Add(this.tB_big);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.tB_C);
            this.Controls.Add(this.tB_Seed);
            this.Controls.Add(this.tB_N);
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
        private System.Windows.Forms.TextBox tB_N;
        private System.Windows.Forms.TextBox tB_Seed;
        private System.Windows.Forms.TextBox tB_C;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox tB_big;
    }
}
