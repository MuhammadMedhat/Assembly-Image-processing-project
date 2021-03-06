﻿namespace CsharpGUI
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSecondImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputImage_pictureBox = new System.Windows.Forms.PictureBox();
            this.outputImage_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputImage2_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.invert_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.Gray = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage2_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.loadSecondImageToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(33, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openImageToolStripMenuItem.Text = "Load First Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // loadSecondImageToolStripMenuItem
            // 
            this.loadSecondImageToolStripMenuItem.Name = "loadSecondImageToolStripMenuItem";
            this.loadSecondImageToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.loadSecondImageToolStripMenuItem.Text = "Load Second Image";
            this.loadSecondImageToolStripMenuItem.Click += new System.EventHandler(this.loadSecondImageToolStripMenuItem_Click);
            // 
            // inputImage_pictureBox
            // 
            this.inputImage_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputImage_pictureBox.Location = new System.Drawing.Point(11, 49);
            this.inputImage_pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputImage_pictureBox.Name = "inputImage_pictureBox";
            this.inputImage_pictureBox.Size = new System.Drawing.Size(383, 469);
            this.inputImage_pictureBox.TabIndex = 1;
            this.inputImage_pictureBox.TabStop = false;
            // 
            // outputImage_pictureBox
            // 
            this.outputImage_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputImage_pictureBox.Location = new System.Drawing.Point(825, 49);
            this.outputImage_pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.outputImage_pictureBox.Name = "outputImage_pictureBox";
            this.outputImage_pictureBox.Size = new System.Drawing.Size(399, 469);
            this.outputImage_pictureBox.TabIndex = 2;
            this.outputImage_pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Image 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Image 2";
            // 
            // inputImage2_pictureBox1
            // 
            this.inputImage2_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputImage2_pictureBox1.Location = new System.Drawing.Point(415, 49);
            this.inputImage2_pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.inputImage2_pictureBox1.Name = "inputImage2_pictureBox1";
            this.inputImage2_pictureBox1.Size = new System.Drawing.Size(383, 469);
            this.inputImage2_pictureBox1.TabIndex = 9;
            this.inputImage2_pictureBox1.TabStop = false;
            // 
            // invert_button
            // 
            this.invert_button.Location = new System.Drawing.Point(1031, 523);
            this.invert_button.Margin = new System.Windows.Forms.Padding(2);
            this.invert_button.Name = "invert_button";
            this.invert_button.Size = new System.Drawing.Size(56, 35);
            this.invert_button.TabIndex = 8;
            this.invert_button.Text = "Invert Image";
            this.invert_button.UseVisualStyleBackColor = true;
            this.invert_button.Click += new System.EventHandler(this.invert_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(822, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output Image";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Equalize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.equalize_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Gx";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 541);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Gy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(521, 541);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubButton
            // 
            this.SubButton.Location = new System.Drawing.Point(622, 541);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(75, 23);
            this.SubButton.TabIndex = 15;
            this.SubButton.Text = "Sub";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // Gray
            // 
            this.Gray.Location = new System.Drawing.Point(725, 541);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(75, 23);
            this.Gray.TabIndex = 16;
            this.Gray.Text = "Gray Scale";
            this.Gray.UseVisualStyleBackColor = true;
            this.Gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 582);
            this.Controls.Add(this.Gray);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputImage2_pictureBox1);
            this.Controls.Add(this.invert_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputImage_pictureBox);
            this.Controls.Add(this.inputImage_pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage2_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox inputImage_pictureBox;
        private System.Windows.Forms.PictureBox outputImage_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox inputImage2_pictureBox1;
        private System.Windows.Forms.Button invert_button;
        private System.Windows.Forms.ToolStripMenuItem loadSecondImageToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button Gray;
    }
}

