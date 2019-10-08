﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DifferenceInDifferentStatesOfDataSharing
{
    public partial class ApplicationState1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["Clicks"] == null)
                {
                    Application["Clicks"] = 0;
                }
                TextBox1.Text = Application["Clicks"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clicksCount = (int)Application["Clicks"] + 1;
            TextBox1.Text = clicksCount.ToString();
            Application["Clicks"] = clicksCount;
        }
    }
}