﻿namespace Opdracht5._3melvin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rechthoekToevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechthoekVerwijderenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechthoekToevoegenToolStripMenuItem,
            this.rechthoekVerwijderenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rechthoekToevoegenToolStripMenuItem
            // 
            this.rechthoekToevoegenToolStripMenuItem.Name = "rechthoekToevoegenToolStripMenuItem";
            this.rechthoekToevoegenToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.rechthoekToevoegenToolStripMenuItem.Text = "rechthoek toevoegen";
            this.rechthoekToevoegenToolStripMenuItem.Click += new System.EventHandler(this.rechthoekToevoegenToolStripMenuItem_Click);
            // 
            // rechthoekVerwijderenToolStripMenuItem
            // 
            this.rechthoekVerwijderenToolStripMenuItem.Name = "rechthoekVerwijderenToolStripMenuItem";
            this.rechthoekVerwijderenToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.rechthoekVerwijderenToolStripMenuItem.Text = "rechthoek verwijderen";
            this.rechthoekVerwijderenToolStripMenuItem.Click += new System.EventHandler(this.rechthoekVerwijderenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Squarification";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rechthoekToevoegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechthoekVerwijderenToolStripMenuItem;
    }
}

