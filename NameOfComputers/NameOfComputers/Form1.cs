using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameOfComputers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Computer myFirsComputer = new Computer("iMac");
            Computer mySecondComputer = new Computer("HP");

            lbLastName.Text = myFirsComputer.NameOfFirstComputer;
            lblFirstName.Text = mySecondComputer.NameofSecondComputer;
            
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Computer myFirsComputer = new Computer("iMac");
            Computer mySecondComputer = new Computer("HP");
            Computer myThirdComputer = new Computer("Dell");


            lblResult.Text = myFirsComputer.NameOfFirstComputer + " " + mySecondComputer.NameofSecondComputer + " " + myThirdComputer.NameofThirdComputer;
        }
    }
}
