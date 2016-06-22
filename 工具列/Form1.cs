using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 工具列
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem_UCase_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ToUpper();
        }

        private void menuItem_LCase_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ToLower();
        }

        private void menuItem_Trim_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.Trim();
        }

        private void menuItem_TrimEnd_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.TrimEnd();
        }

        private void menuItem_Input_Click(object sender, EventArgs e)
        {
            if (允許輸入ToolStripMenuItem.Checked)
            {
                textBox1.ReadOnly = true;
                允許輸入ToolStripMenuItem.Checked = false;
            }
            else
            {
                textBox1.ReadOnly = false;
                允許輸入ToolStripMenuItem.Checked = true;
            }
        }

        private void menuItem_Green_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.DarkGreen;
        }

        private void menuItem_Blue_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.DarkBlue;
        }

        private void menuItem_Purple_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.DarkViolet;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void textBoxBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void textBoxGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void textBoxPurpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
