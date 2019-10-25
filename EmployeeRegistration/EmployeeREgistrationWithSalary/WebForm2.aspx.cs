using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeREgistrationWithSalary.BLL;
using EmployeeREgistrationWithSalary.Models;

namespace EmployeeREgistrationWithSalary
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Department departmentData = new Department();
        EmployeeManagement employeeManagement = new EmployeeManagement();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadGridview();
        }

        private void loadGridview()
        {
            GridView1.DataSource = employeeManagement.GetDataForGridView();
        }
    }
}