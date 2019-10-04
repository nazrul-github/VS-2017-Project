using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingLoop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageBox.Show("Please Add Some Value");
                return;
            }
            if (!string.IsNullOrEmpty(NameTextBox.Text))
            {
                var random = new Random();
                var randomId = random.Next(1, 100);
                ListViewItem item = new ListViewItem(Convert.ToString(randomId));
                item.SubItems.Add(NameTextBox.Text);
                listView.Items.Add(item);
                NameTextBox.Clear();
                idTextBox.Clear();
                idTextBox.Focus();
            }
            
                
        }
        

        private void removeButton_Click(object sender, EventArgs e)
        {
           
            
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView.Items.Remove(listView.SelectedItems[0]);

        }
    }
}
