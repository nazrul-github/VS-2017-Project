using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidationGroups.Models
{
    public class User
    {
        public User(int userId)
        {
            UserId = userId;
        }

        public User(string email, string userName, string password, int age, DateTime openingDate)
        {
            Email = email;
            UserName = userName;
            Password = password;
            Age = age;
            OpeningDate = openingDate;
        }

        public User(string email, string userName, string password, int age, DateTime openingDate, int userId) :
            this(userId)
        {

        }

        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Age  { get; set; }
        public DateTime OpeningDate { get; set; }
        public int UserId { get; set; }



       
    }
}