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
    public partial class ParentWindow : Form
    {
        ChildWindow window = new ChildWindow();
        public ParentWindow()
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
