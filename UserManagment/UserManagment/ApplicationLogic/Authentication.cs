using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment.ApplicationLogic.Validations;

namespace UserManagment.ApplicationLogic
{
    internal class Authentication
    {
        public static string GetFirstName()
        {
            Console.Write("Please enter your name : ");
            string firstName = Console.ReadLine();

            while (!UserValidation.IsValidFirstName(firstName))
            {
                Console.Write("Please enter correct name : ");
                firstName = Console.ReadLine();
            }

            return firstName;
        }
    }
}
