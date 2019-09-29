using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterForLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = String.Empty;

            string oldLblResultValue;
            for (int number = 1; number <= 20; ++number)
            {
                oldLblResultValue = lblResult.Text;
                lblResult.Text = oldLblResultValue + number + "\n";
            }
        }
    }
}
