using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchStringValues
{
    public partial class Form1 : Form
    {
        private int numberOfAppleDevices;
        private int numberOfSamsungDevices;
        public Form1()
        {
            InitializeComponent();
            lblDeviceName.Text = String.Empty;
            lblNumberOfAppleDevices.Text = String.Empty;
            lblNumberOfSamsungDevices.Text = String.Empty;
        }
    
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Device myDecvice = new Device(txtBoxDeviceName.Text);

            specifyTheDeviceCompany(myDecvice);
        }
        private void specifyTheDeviceCompany(Device device)
        {
            lblDeviceName.Text = device.Name;

            if(device.CompanyDevice == "Apple")
            {
                numberOfAppleDevices++;
            }else if(device.CompanyDevice == "Samsung")
            {
                numberOfSamsungDevices++;
            }
            lblNumberOfAppleDevices.Text = numberOfAppleDevices.ToString();
            lblNumberOfSamsungDevices.Text = numberOfSamsungDevices.ToString();
        }
    }
}
