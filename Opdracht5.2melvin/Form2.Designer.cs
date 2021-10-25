namespace Opdracht5._2melvin
{
    partial class Form2
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
            this.gemiddelde = new System.Windows.Forms.TextBox();
            this.newNumber = new System.Windows.Forms.Button();
            this.numberList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gemiddelde
            // 
            this.gemiddelde.Enabled = false;
            this.gemiddelde.Location = new System.Drawing.Point(434, 231);
            this.gemiddelde.Name = "gemiddelde";
            this.gemiddelde.Size = new System.Drawing.Size(125, 27);
            this.gemiddelde.TabIndex = 1;
            this.gemiddelde.UseWaitCursor = true;
            // 
            // newNumber
            // 
            this.newNumber.Location = new System.Drawing.Point(443, 147);
            this.newNumber.Name = "newNumber";
            this.newNumber.Size = new System.Drawing.Size(109, 29);
            this.newNumber.TabIndex = 2;
            this.newNumber.Text = "new number";
            this.newNumber.UseVisualStyleBackColor = true;
            this.newNumber.UseWaitCursor = true;
            this.newNumber.Click += new System.EventHandler(this.newNumber_Click);
            // 
            // numberList
            // 
            this.numberList.ColumnWidth = 20;
            this.numberList.FormattingEnabled = true;
            this.numberList.HorizontalExtent = 20;
            this.numberList.ItemHeight = 20;
            this.numberList.Location = new System.Drawing.Point(86, 117);
            this.numberList.MultiColumn = true;
            this.numberList.Name = "numberList";
            this.numberList.Size = new System.Drawing.Size(315, 224);
            this.numberList.TabIndex = 20;
            this.numberList.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "gemiddelde";
            this.label1.UseWaitCursor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberList);
            this.Controls.Add(this.newNumber);
            this.Controls.Add(this.gemiddelde);
            this.Name = "Form2";
            this.Text = "Form2";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gemiddelde;
        private System.Windows.Forms.Button newNumber;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox numberList;
    }
}