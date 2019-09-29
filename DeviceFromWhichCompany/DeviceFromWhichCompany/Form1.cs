using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceFromWhichCompany
{
    public partial class Form1 : Form
    {
        int incrsApplDvc;
        int incrSmsngDvc;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string deviceName = txtDeviceName.Text;
            switch (deviceName)
            {
                case "iphone": case "iPad": case "iMac": case "iWatch":
                    incrsApplDvc++;
                    lblDeviceName.Text = "Apple";
                        break;
                case "Galaxy Note": case "Galaxy S":
                    incrSmsngDvc++;
                    lblDeviceName.Text = "Samsung";
                    break;

            }
            lblNmberAplDvc.Text = incrsApplDvc.ToString();
            lblNmbrSmgnDvc.Text = incrSmsngDvc.ToString();

        }
    }
}
