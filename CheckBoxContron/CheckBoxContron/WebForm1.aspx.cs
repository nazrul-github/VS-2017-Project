using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace CheckBoxContron
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder svUserData = new StringBuilder();
            if (graduateTextBox.Checked)
            {
                svUserData.Append( graduateTextBox.Text);
            }  if (postGraduateTextBox.Checked) 
            {
                svUserData.Append(", " + postGraduateTextBox.Text);
            } if (doctorateTextBox.Checked)
            {
                svUserData.Append(", " + doctorateTextBox.Text);
            }
            Response.Write($"Your Qualification is: {svUserData.ToString()}");
        }

        protected void graduateTextBox_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Graduate checked box selection change");
        }
    }
}