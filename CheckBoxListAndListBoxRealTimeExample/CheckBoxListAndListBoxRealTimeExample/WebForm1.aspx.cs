using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckBoxListAndListBoxRealTimeExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem diploma = new ListItem("Diploma", "1");
                ListItem graduate = new ListItem("Graduate", "2");
                ListItem postGraduate = new ListItem("Post Graduate", "3");
                ListItem doctorate = new ListItem("Doctorate", "4");
                CheckBoxList1.Items.AddRange(new ListItem[] { diploma, graduate, postGraduate, doctorate });
              //  EmptyLabel();
            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainListBox.Items.Clear();
         //   int count = 0;

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    mainListBox.Items.Add(item.Text);
                   // count++;
                }
            }
       /*     if (count > 0)
            {
                checkBoxStatusLabel.ForeColor = System.Drawing.Color.Green;
                checkBoxStatusLabel.Text = count + " item(s) selected";
            }
            else
            {
             //   EmptyLabel();
            }*/
            //Another way of changing the color and text of the label
            if(CheckBoxList1.SelectedIndex == -1)
            {
                checkBoxStatusLabel.ForeColor = System.Drawing.Color.Red;
            }
            checkBoxStatusLabel.Text = mainListBox.Items.Count.ToString() + " item(s) selected";
        }
      /*  public void EmptyLabel()
        {
            checkBoxStatusLabel.ForeColor = System.Drawing.Color.Red;
            checkBoxStatusLabel.Text = "0 item(s) selected";
        }*/
    }
}