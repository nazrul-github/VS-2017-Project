using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterest_Calculator
{
    public partial class Form1 : Form
    {
     string seletectedCondition;
        string selectedTime;
        double P;
        double R;
        double r;
        double t;
        double A;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conditionSelectionComboBox.Items.AddRange(new string[] { "Total P+I (A)","Princiapal (P)","Rate (R)","Time Period (t)"});
            timeSelectionComboBox.Items.AddRange(new string[] { "days (365/Yr)","days (360/Yr)","Weeks", "months","quarters","years" });
            conditionSelectionComboBox.SelectedItem = "Total P+I (A)";
            timeSelectionComboBox.SelectedItem = "years";
            
        }

        private void conditionSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            seletectedCondition = conditionSelectionComboBox.SelectedItem.ToString();
            if (seletectedCondition == "Total P+I (A)")
            {
                whereConditionLabel.Text = "Where: A = P(1+rt)";
                firstLabel.Text = "Principal (P): $ ";
                secondLabel.Text = "Rate (R): % ";
                thirdLabel.Text = "Time(t) ";
                thirdLabel.Location = new Point(97, 266);
                thirdTextBox.Location = new Point(222, 263);
                perYearLabel.Visible = true;
                perYearLastLabel.Visible = false;
                perYearLastLabel.Location = new Point(157, 334);
                timeSelectionComboBox.Visible = true;
                timeSelectionComboBox.Location = new Point(223, 305);

            }
            else if (seletectedCondition == "Princiapal (P)")
            {
                whereConditionLabel.Text = "Where: P = A / (1 + rt)";
                firstLabel.Text = "Total P+I A:$ ";
                secondLabel.Text = "Rate (R): % ";
                thirdLabel.Text = "Time(t): ";
                thirdLabel.Location = new Point(97, 266);
                thirdTextBox.Location = new Point(222, 263);
                perYearLabel.Visible = true;
                perYearLastLabel.Visible = true;
                perYearLastLabel.Location = new Point(157, 334);
                timeSelectionComboBox.Visible = true;
                timeSelectionComboBox.Location = new Point(223, 305);
            }
            else if (seletectedCondition == "Rate (R)")
            {
                whereConditionLabel.Text = "Where: r = (1/t)(A/P - 1)";
                firstLabel.Text = "Total P+I A:$ ";
                secondLabel.Text = "Principal (P): $ ";
                thirdLabel.Text = "Time(t) ";
                thirdLabel.Location = new Point(97, 239);
                thirdTextBox.Location = new Point(223, 236);
                perYearLabel.Visible = false;
                perYearLastLabel.Visible = false;
                perYearLastLabel.Location = new Point(157, 334);
                timeSelectionComboBox.Visible = true;
                timeSelectionComboBox.Location = new Point(223, 270);
            }
            else if (seletectedCondition == "Time Period (t)")
            {
                whereConditionLabel.Text = "Where: t = (1/r)(A/P - 1)";
                firstLabel.Text = "Total P+I A:$";
                secondLabel.Text = "Principal (P): $ ";
                thirdLabel.Text = "Rate (R): %";
                thirdLabel.Location = new Point(97, 239);
                thirdTextBox.Location = new Point(223, 236);
                perYearLabel.Visible = false;
                perYearLastLabel.Visible = true;
                perYearLastLabel.Location = new Point(157, 269);
                timeSelectionComboBox.Visible = false;
            }
           
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstTextBox.Text) || string.IsNullOrEmpty(secondTextBox.Text) || string.IsNullOrEmpty(thirdTextBox.Text))
            {
                MessageBox.Show("Please fill all the required box");
            }
            else
            {

                selectedTime = timeSelectionComboBox.SelectedItem.ToString();

                if (seletectedCondition == "Total P+I (A)")
                {
                    resultLabel.Text = GetTotalAccuredAmount().ToString("0.00");
                }
                else if (seletectedCondition == "Princiapal (P)")
                {
                    resultLabel.Text = GetPrincipalAmount().ToString("0.00");
                }
                else if (seletectedCondition == "Rate (R)")
                {
                    StringBuilder withRate = new StringBuilder();
                    withRate.Append(GetRate().ToString("0.00"));
                    withRate.Append(GetTimeText());
                    resultLabel.Text = withRate.ToString();
                }
                else if (seletectedCondition == "Time Period (t)")
                {
                    StringBuilder withYear = new StringBuilder();
                    withYear.Append(GetTimePeriod().ToString("0.00"));
                    withYear.Append(" years");
                    resultLabel.Text = withYear.ToString();
                }
            }
            firstTextBox.Focus();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            GetClear();
        }
        private void GetClear()
        {
            firstTextBox.Clear();
            secondTextBox.Clear();
            thirdTextBox.Clear();
            resultLabel.Text = String.Empty;
            firstTextBox.Focus();
        }
        private double GetTime()
        {
            if (selectedTime == "days (365/Yr)")
            {
                t = Convert.ToDouble(thirdTextBox.Text) / 365;
            }
            else if (selectedTime == "days (360/Yr)")
            {
                t = Convert.ToDouble(thirdTextBox.Text) / 360;
            }
            else if (selectedTime == "Weeks")
            {
                t = Convert.ToDouble(thirdTextBox.Text) / 52;
            }
            else if (selectedTime == "months")
            {
                t = Convert.ToDouble(thirdTextBox.Text) / 12;
            }
            else if (selectedTime == "quarters")
            {
                t = Convert.ToDouble(thirdTextBox.Text) / 4;
            }
            else
            {
                t = Convert.ToDouble(thirdTextBox.Text);
            }
            return t;
        }
        private string GetTimeText()
        {
            string timeText = "";
            if (selectedTime == "days (365/Yr)")
            {
                timeText = "%/day";
            }
            else if (selectedTime == "days (360/Yr)")
            {
                timeText = "%/day";
            }
            else if (selectedTime == "Weeks")
            {
                timeText = "%/week";
            }
            else if (selectedTime == "months")
            {
                timeText = "%/month";
            }
            else if (selectedTime == "quarters")
            {
                timeText = "%/quarter";
            }
            else
            {
                timeText = "%/year";
            }
            return timeText;
        }
        private double GetTotalAccuredAmount()
        {
            R = Convert.ToDouble(secondTextBox.Text);
            r = R / 100;
            P = Convert.ToDouble(firstTextBox.Text);
            t = GetTime();
            A = 0;

            
            A = P * (1 + (r * t));
            return A;
        }
        private double GetPrincipalAmount()
        {
            R = Convert.ToDouble(secondTextBox.Text);
            r = R / 100;
            P = 0;
            t = GetTime();
            A = Convert.ToDouble(firstTextBox.Text);
            
            P = A / (1 + (r * t));
            return P;
        }
        private double GetRate()
        {
            
            r = 0;
            P = Convert.ToDouble(secondTextBox.Text);
            t = Convert.ToDouble(thirdTextBox.Text);
            A = Convert.ToDouble(firstTextBox.Text);
            if (A>P)
            {
                r = (1 / t) * ((A / P) - 1);
                R = r * 100;
            }
            else { MessageBox.Show("A must be greater than P");}

           
            return R;
        }
        private double GetTimePeriod()
        {
            R = Convert.ToDouble(thirdTextBox.Text);
            r = R/100;
            P = Convert.ToDouble(secondTextBox.Text);
            A = Convert.ToDouble(firstTextBox.Text);

            if (A>P)
            {
            t = (1/r)*((A/P)-1);
            }
            else
            {
                MessageBox.Show("A must be greater than P");
            }
            return t;
        }
    }
}
