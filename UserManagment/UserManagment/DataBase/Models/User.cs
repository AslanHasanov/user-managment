using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagment.DataBase.Models
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public static int _idCounter = 1;
        public int Id { get; }
        public DateTime _registerTime;

        public User(string firstName, string lastName, string email, string password)
        {
            Id = _idCounter++;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            _registerTime = DateTime.Now;
        }
    }
}
