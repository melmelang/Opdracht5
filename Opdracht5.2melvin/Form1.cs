using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht5._2melvin
{
    public partial class Form1 : Form
    {
        Form2 window = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            window.MdiParent = this;
            window.Show();
        }
    }
}
