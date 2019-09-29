using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructorInCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblFirstName.Text = "Nozrul";
            lblLastName.Text = "Islam";

            Boxer myBoxer = new Boxer("Robin");

            btnResult.Text = myBoxer.GetFirstBoxer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblFirstName.Text + " " + lblLastName.Text;
        }
    }
}
