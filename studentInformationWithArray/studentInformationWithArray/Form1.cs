using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentInformationWithArray
{
    public partial class Form1 : Form
    {
        Students [] studentsArray = new Students[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var randomRegNo = random.Next(10000, 200000);
            label1.Text = Convert.ToString(randomRegNo);
            var studentOne = new Students(label1.Text, firstNameTextBox.Text, lastNameTextBox.Text);
            var studentTwo = new Students(label1.Text, firstNameTextBox.Text, lastNameTextBox.Text);
            var studentThree = new Students(label1.Text, firstNameTextBox.Text, lastNameTextBox.Text);

            regNoLabel.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            
                
                
            
        }

    }
}
