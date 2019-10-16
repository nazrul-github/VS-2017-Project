using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListItemControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateList(DropDownList1);
                PopulateList(CheckBoxList1);
                PopulateList(RadioButtonList1);
                PopulateList(ListBox1);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            GetMultipleSelectedItem(ListBox1);
            GetMultipleSelectedItem(CheckBoxList1);


        }
        private void PopulateList(ListControl listControl)
        {
            ListItem item1 = new ListItem("Item1", "1");
            ListItem item2 = new ListItem("Item2", "2");
            ListItem item3 = new ListItem("Item3", "3");
            ListItem item4 = new ListItem("Item4", "4");

            listControl.Items.AddRange(new ListItem[] { item1, item2, item3, item4 });

        }
        private void GetMultipleSelectedItem(ListControl listControl)
        {
            foreach (ListItem item in listControl.Items)
            {
                if (item.Selected)
                {
                    Response.Write($"Text: {item.Text}, Value:{item.Value}, Index: {listControl.Items.IndexOf(item)}<br/>");
                }
            }
        }
        private void GetSingleSelection(ListControl listControl)
        {
            if (listControl.SelectedIndex != -1)
            {
                ListItem item = new ListItem();
                item = listControl.SelectedItem;
                    Response.Write($"Text: {item.Text}, Value:{item.Value}, Index: {listControl.SelectedIndex.ToString()}");
            }
        }

      
    }
}