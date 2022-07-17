using System;
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
    }
}
