using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoopsSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          int  myNumber = 100;
            for (int myCounter = 5; myCounter < 30; myCounter += 10) {
             //   myNumber = myNumber + myCounter;
                myNumber += myCounter;
                lblResult.Text = myNumber.ToString();
            }
                
        }
    }
}
