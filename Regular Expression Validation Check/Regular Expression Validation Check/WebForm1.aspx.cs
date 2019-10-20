using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Regular_Expression_Validation_Check
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                msgLabel.Text = "Email Address Added Successfully";
                msgLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                msgLabel.Text = "Saving Failed";
                msgLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}