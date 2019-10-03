using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                
                PrizeModel model = new PrizeModel(placeNumberValue.Text, placeNameValue.Text, prizeAmountValue.Text, prizePercentageValue.Text);
                foreach (IDataConncetion db in GlobalConfig.Conncetions)
                {
                    db.CreatePrize(model);
                }
                placeNumberValue.Text = " ";
                placeNameValue.Text = " ";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information, please check it and try again");
            }

        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                MessageBox.Show("Enter a valid place number");
                output = false;
            }
            if (placeNumber < 1)
            {
                MessageBox.Show("Enter a place number greater than 1");

                output = false;
            }
            if (placeNameValue.Text.Length == 0)
            {
                MessageBox.Show("Enter a valid text");

                output = false;
            }
            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);
            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                MessageBox.Show("Enter a valid number");

                output = false;
            }
            if (prizePercentage <= 0 && prizeAmount <= 0)
            {
                MessageBox.Show("Enter a valid number");

                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                MessageBox.Show("Enter a valid number");

                output = false;
            }
            return output;
        }
    }
}
