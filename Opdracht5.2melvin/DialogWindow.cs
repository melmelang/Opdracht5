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
    public partial class DialogWindow : Form
    {

        public int ReturnInt { get; set; }

        public DialogWindow()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.ReturnInt = int.Parse(number.Text);
    }
    }
}
