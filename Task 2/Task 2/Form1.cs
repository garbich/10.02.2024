using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();

            }
        }

        private void addColummToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

            ListViewItem item = new ListViewItem(toolStripTextBox4.Text);

            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, toolStripTextBox3.Text);

            item.SubItems.Add(subItem);
            listView1.Items.Add(item);
        }
    }
}
