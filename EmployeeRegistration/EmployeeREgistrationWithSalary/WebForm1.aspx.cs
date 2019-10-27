using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeREgistrationWithSalary.BLL;
using EmployeeREgistrationWithSalary.Models;

namespace EmployeeREgistrationWithSalary
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        EmployeeManagement employeeManagement = new EmployeeManagement();
        Department newDepartMent = new Department();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDdLdepartment();
            }
        }



        protected void saveButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string name = employeeNameTextBox.Text;
                string email = emailAddressTextBox.Text;
                string mobileNumber = mobileNumberTextBox.Text;
                string district = districtTextBox.Text;
                string gender = genderDropDownList.SelectedItem.Text;
                DateTime dateOfBirth = DateTime.Parse(dateSelectTextBox.Text);
                int registrationNumber = Convert.ToInt32(registrationNumberTextBox.Text);
                Employee newEmployee = new Employee(name, email, mobileNumber, district, gender, dateOfBirth, registrationNumber);
                int departmentID = Int32.Parse(ddlDepartment.SelectedValue);
                newEmployee.DepartmentID = departmentID;
                newDepartMent.Employees.Add(newEmployee);

                if (employeeManagement.IsExist(newEmployee))
                {
                    msgLabel.Text = "Employee Id Already Exist";
                    msgLabel.ForeColor = Color.Red;
                    registrationNumberTextBox.Focus();
                }
                else
                {
                    msgLabel.Text = employeeManagement.SendData(newEmployee);
                    GetClear();

                }

            }

        }



        protected void updateButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string name = employeeNameTextBox.Text;
                string email = emailAddressTextBox.Text;
                string mobileNumber = mobileNumberTextBox.Text;
                string district = districtTextBox.Text;
                string gender = genderDropDownList.SelectedItem.Text;
                DateTime dateOfBirth = DateTime.Parse(dateSelectTextBox.Text);
                int registrationNumber = Convert.ToInt32(registrationNumberTextBox.Text);
                Employee newEmployee = new Employee(name, email, mobileNumber, district, gender, dateOfBirth, registrationNumber);
                int departmentId = Int32.Parse(ddlDepartment.SelectedValue);
                newEmployee.DepartmentID = departmentId;
                newDepartMent.Employees.Add(newEmployee);

                if (employeeManagement.IsExist(newEmployee))
                {
                    msgLabel.Text = employeeManagement.UpdateData(newEmployee);
                    GetClear();

                }
                else
                {
                    msgLabel.Text = "Employee Id Doesn't Exist, Please save the employee data first";
                    msgLabel.ForeColor = Color.Red;
                    registrationNumberTextBox.Focus();
                }

            }
        }
        protected void mobileNumberTextBoxLengthValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            employeeManagement.MobileNumberLengthValidate(source, args);
        }
        private void LoadDdLdepartment()
        {
            ddlDepartment.DataTextField = "DepartmentName";
            ddlDepartment.DataValueField = "DepartmentID";
            ddlDepartment.DataSource = newDepartMent.GetDepartments();
            ddlDepartment.DataBind();
        }
        private void GetClear()
        {
            employeeNameTextBox.Text = string.Empty;
            emailAddressTextBox.Text = String.Empty;
            mobileNumberTextBox.Text = String.Empty;
            districtTextBox.Text = String.Empty;
            genderDropDownList.SelectedValue = "0";
            dateSelectTextBox.Text = string.Empty;
            registrationNumberTextBox.Text = string.Empty;
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            employeeNameTextBox.ValidateRequestMode = ValidateRequestMode.Disabled;
            emailAddressTextBox.ValidateRequestMode = ValidateRequestMode.Disabled;
            mobileNumberTextBox.ValidateRequestMode = ValidateRequestMode.Disabled;
            districtTextBox.ValidateRequestMode = ValidateRequestMode.Disabled;
            genderDropDownList.ValidateRequestMode = ValidateRequestMode.Disabled;
            dateSelectTextBox.ValidateRequestMode = ValidateRequestMode.Disabled;
        }
    }
}