using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht5._3melvin
{
    public partial class Form1 : Form
    {
        static int counter;
        public int width = 0;
        public int height = 0;
        public int pointX = 0;
        public int pointY = 28;

        public Form1()
        {
            InitializeComponent();
        }

        private void sizing(int i)
        {
            if (counter == 1)
            {
                width = this.Size.Width - 19;
                height = this.Size.Height - 76;
                pointX = 0;
                pointY = 28;
            }
            else if (counter == 2)
            {
                width = (this.Size.Width - 19) / 2;
                height = this.Size.Height - 76;
                if (i == 0)
                {
                    pointX = 0;
                    pointY = 28;
                }
                else if (i == 1)
                {
                    pointX = width;
                    pointY = 28;
                }
                
            }
        }

        public void deleting(int i)
        {
            if (counter == 1)
            {
                width = this.Size.Width - 19;
                height = this.Size.Height - 76;
                pointX = 0;
                pointY = 28;
            }
        }

        private void rechthoekToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int counted = counter;
            for (int i = 0; i < counter; i++)
            {
                this.Controls.RemoveAt(counted);
                counted--;
            }
            counter++;
            for (int i = 0; i < counter; i++)
            {
                sizing(i);
                Button MyButton = new Button();
                MyButton.Location = new Point(pointX, pointY);
                MyButton.Size = new Size(width, height);
                MyButton.BackColor = Color.LightBlue;
                this.Controls.Add(MyButton);
            }
            

            
        }

        private void rechthoekVerwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int counted = counter;
            for (int i = 0; i < counter; i++)
            {
                this.Controls.RemoveAt(counted);
                counted--;
            }
            counter--;
            for (int i = 0; i < counter; i++)
            {
                sizing(i);
                Button MyButton = new Button();
                MyButton.Location = new Point(pointX, pointY);
                MyButton.Size = new Size(width, height);
                MyButton.BackColor = Color.LightBlue;
                this.Controls.Add(MyButton);
            }
        }
    }
}
