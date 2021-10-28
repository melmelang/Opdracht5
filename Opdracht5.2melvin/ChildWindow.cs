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
    public partial class ChildWindow : Form
    {

        public ChildWindow()
        {
            InitializeComponent();
        }

        private void newNumber_Click(object sender, EventArgs e)
        {
            DialogWindow dialogWindow = new DialogWindow();
            dialogWindow.ShowDialog();
            if (dialogWindow.DialogResult == DialogResult.OK)
            {
                AddToList(dialogWindow.ReturnInt);
                MakeAVG();
                dialogWindow.Dispose();
            }
        }

        public void AddToList(int getal)
        {
            numberList.Items.Add(getal.ToString());
        }

        public void MakeAVG()
        {
            double total = 0;
            for (int i = 0; i < numberList.Items.Count; i++)
            {
                total += double.Parse(numberList.Items[i].ToString());
            }
            total = total / numberList.Items.Count;
            gemiddelde.Text = total.ToString();
        }
    }
}
