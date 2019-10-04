using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var people = GetPeopleList();
            listViewPeople.Items.Clear();
            foreach (var person in people)
            {
                var row = new string[] { person.FirstName, person.LastName, person.DateOfBirth.ToString("dd/mm/yyyy") };
                var items = new ListViewItem(row);
                //we add the whole object to the Tag property, if we want 
                //later to display details about the selected item
                items.Tag = person; //we need to cast to Person when we get the value

                //add the item to the list view control
                listViewPeople.Items.Add(items);
            }
        }

        private List<Person> GetPeopleList()
        {
            var list = new List<Person>();
            list.Add(new Person() { FirstName = "Zoynal ", LastName = "Abedin",DateOfBirth = DateTime.Now.AddYears(-17) });
            list.Add(new Person() { FirstName = "Rafiqul", LastName = "Islam", DateOfBirth = DateTime.Now.AddYears(-32) });
            list.Add(new Person() { FirstName = "Mohiudiin", LastName = "Shibli", DateOfBirth = DateTime.Now.AddYears(-35) });
            list.Add(new Person() { FirstName = "Aramnul", LastName = "Islam", DateOfBirth = DateTime.Now.AddYears(-29 )});
            return list;
        }

        private void listViewPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Person)listViewPeople.SelectedItems[0].Tag;
                if(selectedItem != null)
                {
                    MessageBox.Show(selectedItem.ToString(), "Person details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
