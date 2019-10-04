using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeForm
{
    public partial class Form1 : Form
    {
        Dictionary<string, Employee> employeDictionary = new Dictionary<string, Employee>();


        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            Employee employeeInformation = new Employee(firstNameTextBox.Text, lastNameTextBox.Text, dateTimePicker.Text, salaryTextBox.Text);
            employeDictionary.Add(employeeInformation.ID, employeeInformation);

            ListViewItem itemAll = new ListViewItem(employeeInformation.ID+"");
            itemAll.SubItems.AddRange(new string[] { $"{firstNameTextBox.Text} {lastNameTextBox.Text}", dateTimePicker.Text,salaryTextBox.Text });
            mainListView.Items.Add(itemAll);
            GetClear();
            firstNameTextBox.Focus();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
          string  enteredKey = employeeIdTextBox.Text;
            if (employeDictionary.ContainsKey(enteredKey))
            {
                MessageBox.Show($"Name: {employeDictionary[enteredKey].FirstName} {employeDictionary[enteredKey].LastName}'\n'" +
                    $"ID: {enteredKey}");
            }
            else { MessageBox.Show("Please Enter A Valid ID");}
            GetClear();
            
        }

        private void removeDectionary_Click(object sender, EventArgs e)
        {

            if (employeDictionary.ContainsKey(mainListView.SelectedItems[0].Text))
            {
                employeDictionary.Remove(mainListView.SelectedItems[0].Text);
                MessageBox.Show("Successfully Removed");
            } 
            else { MessageBox.Show("Please Enter A Valid ID");}
            mainListView.SelectedItems[0].Remove();

        }

        private void mainListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem id = mainListView.SelectedItems[0];
           // string idText = id.SubItems[0].Text;
            string name = id.SubItems[1].Text;
            string dob = id.SubItems[2].Text;
            string salary = id.SubItems[3].Text;
            MessageBox.Show($"ID:  '\n'" +
                            $"Name: {name}'\n'" +
                            $"DOB: {dob}'\n'" +
                            $"Salary: {salary}"); 
        }
        private void GetClear()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            salaryTextBox.Clear();
            employeeIdTextBox.Clear();
        }
        
    }
}
