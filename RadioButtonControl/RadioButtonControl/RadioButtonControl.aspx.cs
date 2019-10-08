using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButtonControl
{
    public partial class RadioButtonControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (maleRadioButton.Checked)
            {
                Response.Write($"Your Gender is {maleRadioButton.Text}<br/>");
            }else
            if (femaleRadioButton.Checked)
            {
                Response.Write($"Your Gender is {femaleRadioButton.Text}<br/>");
            }else
            if (unknownRadioButton.Checked)
            {
                Response.Write($"Your Gender is {unknownRadioButton.Text}<br/>");
            }
        }

        
    }
}