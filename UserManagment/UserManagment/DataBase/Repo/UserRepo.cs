﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment.DataBase.Models;

namespace UserManagment.DataBase.Repo
{
    internal class UserRepo
    {
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User("Admin","Super","admin@gmail.com","123321")

        };

        public static User AddUser(string firstName, string lastName, string email, string password)
        {
            User user = new User(firstName, lastName, email, password);
            Users.Add(user);
            return user;
        }
    }
}
