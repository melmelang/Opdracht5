using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht5._1melvin
{
    public partial class ChangeColor : Form
    {
        public ChangeColor()
        {
            InitializeComponent();
        }

        private void redToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InputText.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InputText.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InputText.ForeColor = Color.Blue;
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputText.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputText.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputText.BackColor = Color.Blue;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Font = Font = new Font(InputText.Font.Name, 5,
                InputText.Font.Style, InputText.Font.Unit);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Font = Font = new Font(InputText.Font.Name, 9,
                InputText.Font.Style, InputText.Font.Unit);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Font = Font = new Font(InputText.Font.Name, 15,
                InputText.Font.Style, InputText.Font.Unit);
        }

        private void redToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            redToolStripMenuItem_Click_1(sender, e);
        }

        private void greenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            greenToolStripMenuItem_Click_1(sender, e);
        }

        private void blueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            blueToolStripMenuItem_Click_1(sender, e);
        }

        private void redToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            redToolStripMenuItem1_Click(sender, e);
        }

        private void greenToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            greenToolStripMenuItem1_Click(sender, e);
        }

        private void blueToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            blueToolStripMenuItem1_Click(sender, e);
        }

        private void smallToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            smallToolStripMenuItem_Click(sender, e);
        }

        private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            normalToolStripMenuItem_Click(sender, e);
        }

        private void largeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            largeToolStripMenuItem_Click(sender, e);

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
