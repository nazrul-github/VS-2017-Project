using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            Animal lion = new Animal(txtBoxName.Text, int.Parse(txtBoxAge.Text), decimal.Parse(txtBoxPower.Text), decimal.Parse(txtBoxSpeed.Text));
            lblResult.Text = $"Animal Name:{lion.Name}\nAnimal Age:{lion.Age}\nAnimal Power:{lion.Power}\nAnimal Speed:{lion.Speed}";

            lion.IncreaseAge(-2);
            lblIncreasedAge.Text = lion.Age + "";
            lion.IncrePower(2.40m);
            lblIncreasePower.Text = lion.Power + "";
            lion.IncreaseSpeed(33.56m);
            lblIncreaseSpeed.Text = lion.Speed + "";
        }
    }
}
