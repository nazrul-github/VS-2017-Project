using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfStatementsInCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            Boxer myBoxer = new Boxer(txtBoxName.Text, int.Parse(txtBoxPunchSpeed.Text));
            lblResult.Text = $"Boxer Name: {myBoxer.Name}\nBoxer Speed Evaluation: {myBoxer.PunchSpeedEvaluation}";
        }
    }
}
