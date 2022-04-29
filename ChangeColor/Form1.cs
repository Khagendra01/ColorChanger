using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            Environment.Exit(0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                label2.Text = "Granite";
                pictureBox1.Image = Properties.Resources._292200;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();//new object
            colorDialog1.ShowDialog();
            Color myColor = colorDialog1.Color;
            tabPage1.BackColor = myColor;
        }
    }
}
