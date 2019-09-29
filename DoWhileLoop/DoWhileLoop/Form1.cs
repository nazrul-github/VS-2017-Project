using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhileLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string OldlblResultValue;
            int myNumber = 10;
            lblResult.Text = String.Empty;
            do
            {
                OldlblResultValue = lblResult.Text;
                lblResult.Text = OldlblResultValue + myNumber + "\n";
                myNumber++;
            } while (myNumber < 0);
        }
    }
}
