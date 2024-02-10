using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox1.SelectedItem + "  -  done"); 
            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            listBox1.Items.Add(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
