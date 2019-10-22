using System;

namespace PropertiesInCSharp
{
    public class Person
    {
        public DateTime BirthDate { get; private set; }
        public  int _age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        

    }
}
