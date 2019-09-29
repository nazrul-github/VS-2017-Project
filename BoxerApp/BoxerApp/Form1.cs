using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Boxer handBoxer = new Boxer(txtName.Text,int.Parse(txtPunchPower.Text),decimal.Parse(txtKickPower.Text), decimal.Parse(txtRightHookPower.Text),decimal.Parse(txtLeftHookPwer.Text));

            lblResult.Text = $"Name Of The Boxer: {handBoxer.Name}\nPunch Power: {handBoxer.PunchPower}\nKick Power: {handBoxer.KickPower}\nRight Hook Power: {handBoxer.RightHookPower}\nLefHookPower: {handBoxer.LeftHookPower}";

            lblIncrsdRslt.Text = $"Enhanced Boxer Name: {handBoxer.Name}\nPunch Power: {handBoxer.IncreasePunchPower(15)}\nKick Power: {handBoxer.IncreaseKickPower(20)}\nRight Hook Power: {handBoxer.IncreaseRightHookPower(20)}\nLefHookPower: {handBoxer.IncreaseLeftHookPpower(33)}";


        }
    }
}
