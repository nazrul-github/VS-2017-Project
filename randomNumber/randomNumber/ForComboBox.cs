using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomNumber
{
    public partial class ForComboBox : Form
    {
        public ForComboBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ForComboBox_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "London", "America", "Japan" });
        }
    }
}
