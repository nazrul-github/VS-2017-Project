using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchStatements
{
    public partial class Form1 : Form
    {
        int numberOfGreatBoxers;
        int numberOfGoodBoxers;
        int numberOfBadBoxers;

        public Form1()
        {
            InitializeComponent();
            lblGreatBoxer.Text = String.Empty;
            lblGoodBoxer.Text = String.Empty;
            lblBadBoxer.Text = String.Empty;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int boxerSpeed = int.Parse(txtBoxBoxerSpeed.Text);

            if (boxerSpeed != 0 && boxerSpeed<=200)
            {


                switch (boxerSpeed / 10)
                {
                    case 20:
                    case 19:
                    case 18:
                    case 17:
                        numberOfGreatBoxers++;
                        goto case 14;
                    case 16:
                    case 15:
                    case 14:
                        numberOfGoodBoxers++;
                        break;
                    default:
                        numberOfBadBoxers++;
                        break;
                }
                lblGreatBoxer.Text = numberOfGreatBoxers.ToString();
                lblGoodBoxer.Text = numberOfGoodBoxers.ToString();
                lblBadBoxer.Text = numberOfBadBoxers.ToString();

            }
        }
    }
}
