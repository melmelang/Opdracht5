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
        static int rows;
        static int columns = 0;
        private List<int> R = new List<int>();
        private List<int> G = new List<int>();
        private List<int> B = new List<int>();
        private List<int> A = new List<int>();
        private List<Button> buttonList = new List<Button>();
        private List<NumericUpDown> numHold = new List<NumericUpDown>();

        public Form1()
        {
            InitializeComponent();
        }

        private void sizing()
        {
            int rowAndCollumns;

            if (counter > 3)
            {
                rowAndCollumns = (int)Math.Ceiling(Math.Sqrt(counter));
            }
            else if (counter == 1)
            {
                rowAndCollumns = 1;
            }
            else
            {
                rowAndCollumns = 2;
            }
            width = (this.Size.Width - 19) / rowAndCollumns;
            height = (this.Size.Height - 76) / rowAndCollumns;

            if (rows < rowAndCollumns)
            {
                pointX = ((this.Size.Width - 19) * rows) / rowAndCollumns;
                pointY = ((this.Size.Height - 76) * columns) / rowAndCollumns + 28;
            }

            //MessageBox.Show("" + rows + "-" + columns + "-" + pointX + "-" + pointY);
            rows++;
            if (rows == rowAndCollumns)
            {
                columns++;
                rows = 0;
            }
        }

        private void rechthoekToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numHold.Count != 0)
            {
                foreach (NumericUpDown n in numHold)
                {
                    n.Dispose();
                }
                numHold.Clear();
            }
            int counted = counter;
            for (int i = 0; i < counter; i++)
            {
                this.Controls.RemoveAt(counted);
                counted--;
            }
            counter++;
            rows = 0;
            columns = 0;
            buttonList.Clear();
            for (int i = 0; i < counter; i++)
            {
                A.Add(255);
                R.Add(255);
                G.Add(255);
                B.Add(255);
                sizing();
                Button MyButton = new Button();
                MyButton.Location = new Point(pointX, pointY);
                MyButton.Size = new Size(width, height);
                MyButton.BackColor = Color.FromArgb(A[i], R[i], G[i], B[i]);
                MyButton.MouseEnter += new EventHandler(MyButton_MouseEnter);
                this.Controls.Add(MyButton);
                buttonList.Add(MyButton);
            }
        }

        private void rechthoekVerwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numHold.Count != 0)
            {
                foreach (NumericUpDown n in numHold)
                {
                    n.Dispose();
                }
                numHold.Clear();
            }
            int counted = counter;
            for (int i = 0; i < counter; i++)
            {
                this.Controls.RemoveAt(counted);
                counted--;
            }
            if (counter != 0)
            {
                counter--;
            }
            rows = 0;
            columns = 0;
            buttonList.Clear();
            for (int i = 0; i < counter; i++)
            {
                sizing();
                Button MyButton = new Button();
                MyButton.Location = new Point(pointX, pointY);
                MyButton.Size = new Size(width, height);
                MyButton.BackColor = Color.FromArgb(A[i], R[i], G[i], B[i]);
                MyButton.MouseEnter += new EventHandler(MyButton_MouseEnter);
                this.Controls.Add(MyButton);
                buttonList.Add(MyButton);
            }
            A.RemoveAt(counter);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (numHold.Count != 0)
            {
                foreach (NumericUpDown n in numHold)
                {
                    n.Dispose();
                }
                numHold.Clear();
            }
            int counted = counter;
            for (int i = 0; i < counter; i++)
            {
                this.Controls.RemoveAt(counted);
                counted--;
            }
            rows = 0;
            columns = 0;
            buttonList.Clear();
            for (int i = 0; i < counter; i++)
            {
                sizing();
                Button MyButton = new Button();
                MyButton.Location = new Point(pointX, pointY);
                MyButton.Size = new Size(width, height);
                MyButton.BackColor = Color.FromArgb(A[i], R[i], G[i], B[i]);
                MyButton.MouseEnter += new EventHandler(MyButton_MouseEnter);
                this.Controls.Add(MyButton);
                buttonList.Add(MyButton);
            }
        }
        public void MyButton_MouseEnter(object sender, EventArgs e)
        {
            Button MyButton = (Button)sender;
            int i = buttonList.IndexOf(MyButton);

            if (numHold.Count != 0)
            {
                foreach(NumericUpDown n in numHold)
                {
                    n.Dispose();
                }
                numHold.Clear();
            }

            NumericUpDown NumUpDownA = new NumericUpDown();
            NumUpDownA.Location = new Point(MyButton.Location.X, MyButton.Location.Y);
            NumUpDownA.Size = new Size(MyButton.Width / 5, 5);
            NumUpDownA.Maximum = 255;
            NumUpDownA.Minimum = 0;
            NumUpDownA.Value = A[i];
            Controls.Add(NumUpDownA);
            NumUpDownA.BringToFront();
            NumericUpDown NumUpDownR = new NumericUpDown();
            NumUpDownR.Location = new Point(MyButton.Location.X, MyButton.Location.Y + 30);
            NumUpDownR.Size = new Size(MyButton.Width / 5, 5);
            NumUpDownR.Maximum = 255;
            NumUpDownR.Minimum = 0;
            NumUpDownR.Value = R[i];
            Controls.Add(NumUpDownR);
            NumUpDownR.BringToFront();
            NumericUpDown NumUpDownG = new NumericUpDown();
            NumUpDownG.Location = new Point(MyButton.Location.X + (MyButton.Width / 5) + 5, MyButton.Location.Y);
            NumUpDownG.Size = new Size(MyButton.Width / 5, 5);
            NumUpDownG.Maximum = 255;
            NumUpDownG.Minimum = 0;
            NumUpDownG.Value = G[i];
            Controls.Add(NumUpDownG);
            NumUpDownG.BringToFront();
            NumericUpDown NumUpDownB = new NumericUpDown();
            NumUpDownB.Location = new Point(MyButton.Location.X + (MyButton.Width / 5) + 5, MyButton.Location.Y + 30);
            NumUpDownB.Size = new Size(MyButton.Width / 5, 5);
            NumUpDownB.Maximum = 255;
            NumUpDownB.Minimum = 0;
            NumUpDownB.Value = B[i];
            Controls.Add(NumUpDownB);
            NumUpDownB.BringToFront();
            NumUpDownA.ValueChanged += new EventHandler(NumUpDownA_ValueChange);
            NumUpDownG.ValueChanged += new EventHandler(NumUpDownG_ValueChange);
            NumUpDownR.ValueChanged += new EventHandler(NumUpDownR_ValueChange);
            NumUpDownB.ValueChanged += new EventHandler(NumUpDownB_ValueChange);

            numHold.Add(NumUpDownA);
            numHold.Add(NumUpDownG);
            numHold.Add(NumUpDownR);
            numHold.Add(NumUpDownB);

            void NumUpDownA_ValueChange(object sender, EventArgs e)
            {
                A[i] = (int)NumUpDownA.Value;
                MyButton.BackColor = Color.FromArgb(A[i], R[i], G[i], B[i]);
            }
            void NumUpDownR_ValueChange(object sender, EventArgs e)
            {
                R[i] = (int)NumUpDownR.Value;
                MyButton.BackColor = Color.FromArgb(A[i], R[i], G[i], B[i]);
            }
            void NumUpDownG_ValueChange(object sender, EventArgs e)
            {
                G[i] = (int)NumUpDownG.Value;
                MyButton.BackColor = Color.FromArgb(A[i], R[i], G[i], B[i]);
            }
            void NumUpDownB_ValueChange(object sender, EventArgs e)
            {
                B[i] = (int)NumUpDownB.Value;
                MyButton.BackColor = Color.FromArgb(A[i], R[i], G[i], B[i]);
            }
        }
    }
}
