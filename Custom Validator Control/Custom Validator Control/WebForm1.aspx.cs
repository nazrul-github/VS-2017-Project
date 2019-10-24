using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Custom_Validator_Control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void submitButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                msgLabel.Text = "Data Saved Successfully";
                msgLabel.ForeColor = Color.Green;

            }
            else
            {
                msgLabel.Text = "Validation Failed!! Data not saved";
                msgLabel.ForeColor = Color.Red;
            }
        }

        protected void CustomValidatorEven_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                long number;
                bool tryParse = long.TryParse(args.Value, out number);

                if (tryParse && number >= 0 && number % 2 == 0)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }


        }

    }


}
