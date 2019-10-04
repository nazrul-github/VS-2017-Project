using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrudentRegistryFormWithListView
{
    public partial class studentRegistryForm : Form
    {
        public studentRegistryForm()
        {
            InitializeComponent();
        }

            private void exitButton_Click(object sender, EventArgs e)
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "System Down", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ListViewItem item1;
            item1 = mainListView.SelectedItems[0];
            item1.Remove();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var row = new string[] { studentIDTextBox.Text, firstNameTextBox.Text, surNameTextBox.Text, addressTextBox.Text, telephoneNoTextBox.Text, mobileNumberTextBox.Text, courseComboBox.Text, yearComboBox.Text };
            ListViewItem items = new ListViewItem(row);
            mainListView.Items.Add(items);
            studentIDTextBox.Text = "";
            firstNameTextBox.Text = "";
            surNameTextBox.Text = "";
            addressTextBox.Text = "";
            telephoneNoTextBox.Text = "";
            mobileNumberTextBox.Text = "";
            courseComboBox.Text = "";
            yearComboBox.Text = "";
        
        }

        private void studentRegistryForm_Load(object sender, EventArgs e)
        {
            courseComboBox.Items.AddRange(new string[] { "Computer Science","Games Development","Maths","Biology","Law","Business Studies","Chemistry", "Physics","Music","Medical Science" });
            yearComboBox.Items.AddRange(new string[] { "First", "Second", "Third", "Fourth", "Fifth" });
        }

        private void mainListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainListView.SelectedIndices !=null)
            {
                var itemsSelected = mainListView.SelectedItems[0];
                MessageBox.Show($"Name: {itemsSelected.SubItems[0].Text} {itemsSelected.SubItems[1].Text}");
            }
          
                   
                

        }
        
    }
}
