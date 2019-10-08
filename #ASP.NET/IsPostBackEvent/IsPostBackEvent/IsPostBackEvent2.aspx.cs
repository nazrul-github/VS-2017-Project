using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IsPostBackEvent
{
    public partial class IsPostBackEvent2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            LoadCityDropDownList();
            }

            
        }
        public void LoadCityDropDownList()
        {
            ListItem ddl1 = new ListItem("London");
            ddlCity.Items.Add(ddl1);
            ListItem ddl2 = new ListItem("Sydney");
            ddlCity.Items.Add(ddl2);
            ListItem ddl3 = new ListItem("Mumbai");
            ddlCity.Items.Add(ddl3);
        }

        
    }
}