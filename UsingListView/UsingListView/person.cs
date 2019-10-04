using System;

namespace UsingListView
{
    public class Person
    {
        public Person()
        {
            ID = new Random().Next(1, 1000); //will generate random id!
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            var details = string.Format("{0} - {1} {2} born on {3}", ID, FirstName, LastName, DateOfBirth.ToString("dd/mm/yyyy"));
            return details;
        }
    }
}