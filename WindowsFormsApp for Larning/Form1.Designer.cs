﻿namespace WindowsFormsApp_for_Larning
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
            this.cRectangel = new System.Windows.Forms.Button();
            this.clearL = new System.Windows.Forms.Button();
            this.CalRectangle = new System.Windows.Forms.Button();
            this.textBoxRectangle = new System.Windows.Forms.TextBox();
            this.rectangelDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cRectangel
            // 
            this.cRectangel.Location = new System.Drawing.Point(118, 12);
            this.cRectangel.Name = "cRectangel";
            this.cRectangel.Size = new System.Drawing.Size(120, 23);
            this.cRectangel.TabIndex = 0;
            this.cRectangel.Text = "create rectangel";
            this.cRectangel.UseVisualStyleBackColor = true;
            this.cRectangel.Click += new System.EventHandler(this.cRectangel_Click);
            // 
            // clearL
            // 
            this.clearL.Location = new System.Drawing.Point(725, 415);
            this.clearL.Name = "clearL";
            this.clearL.Size = new System.Drawing.Size(63, 23);
            this.clearL.TabIndex = 4;
            this.clearL.Text = "clear";
            this.clearL.UseVisualStyleBackColor = true;
            this.clearL.Click += new System.EventHandler(this.clearL_Click);
            // 
            // CalRectangle
            // 
            this.CalRectangle.Location = new System.Drawing.Point(244, 12);
            this.CalRectangle.Name = "CalRectangle";
            this.CalRectangle.Size = new System.Drawing.Size(178, 23);
            this.CalRectangle.TabIndex = 5;
            this.CalRectangle.Text = "cal area and space Rectangel";
            this.CalRectangle.UseVisualStyleBackColor = true;
            this.CalRectangle.Click += new System.EventHandler(this.CalRectangle_Click);
            // 
            // textBoxRectangle
            // 
            this.textBoxRectangle.Location = new System.Drawing.Point(428, 15);
            this.textBoxRectangle.Name = "textBoxRectangle";
            this.textBoxRectangle.Size = new System.Drawing.Size(100, 20);
            this.textBoxRectangle.TabIndex = 7;
            // 
            // rectangelDate
            // 
            this.rectangelDate.Location = new System.Drawing.Point(12, 15);
            this.rectangelDate.Name = "rectangelDate";
            this.rectangelDate.Size = new System.Drawing.Size(100, 20);
            this.rectangelDate.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rectangelDate);
            this.Controls.Add(this.textBoxRectangle);
            this.Controls.Add(this.CalRectangle);
            this.Controls.Add(this.clearL);
            this.Controls.Add(this.cRectangel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cRectangel;
        private System.Windows.Forms.Button clearL;
        private System.Windows.Forms.Button CalRectangle;
        private System.Windows.Forms.TextBox textBoxRectangle;
        private System.Windows.Forms.TextBox rectangelDate;
    }
}

