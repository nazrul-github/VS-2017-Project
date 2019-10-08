using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IsPostBackEvent
{
    public partial class IsPostBackEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            Response.Write("Page Loaded for the first time");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}