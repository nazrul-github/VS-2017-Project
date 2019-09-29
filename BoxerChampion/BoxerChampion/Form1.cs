using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxerChampion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void btnResult_Click(object sender, EventArgs e)
            {
                string boxerName = txtBoxName.Text;
                int numberOfMatchesWon = int.Parse(txtBoxMatchesWon.Text);
                int numberOfMatchesLost = int.Parse(txtBoxMatchesLost.Text);

                if (numberOfMatchesWon > 20)
                {
                    lblWinnerResult.Text = $"This boxer Named: {boxerName} is a Champion!!";
                }
                else
                {
                    lblWinnerResult.Text = $"This boxer Named: {boxerName} is a Looser";

                }
                if (numberOfMatchesWon > 100)
                {
                    lblEvaluation.Text = $"This boxer Named: {boxerName} is a legend";
                }
            }
    }
}
