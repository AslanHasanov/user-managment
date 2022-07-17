using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment.DataBase.Repo;

namespace UserManagment.ApplicationLogic.Validations
{
    internal class UserValidation
    {
        public static bool IsValidFirstName(string firstName)
        {
            if (Validation.IsValidText(firstName))
            {
                return true;
            }
            Console.WriteLine("Entered name is incorrect," +
                " make sure the name contains only letters," +
                " the first letter is uppercase," +
                " and the length is greater than 3 and less than 30");

            return false;
        }

        public static bool IsValidLastName(string lastName)
        {
            if (Validation.IsValidText(lastName))
            {
                return true;
            }
            Console.WriteLine("Entered last name is incorrect," +
                " make sure the name contains only letters," +
                " the first letter is uppercase," +
                " and the length is greater than 3 and less than 30");

            return false;
        }

        public static bool IsValidEmail(string email)
        {
            if (Validation.IsConsistEmail(email))
            {
                return true;
            }
            Console.WriteLine("Receipent- can consist of only letters and numbers," +
                " the total length can be min 10 max 30," +
                "Separator - there must be an @ in between," +
                "Domain - can only end with code.edu.az," +
                "Example: mahmood@code.edu.az");

            return false;
        }

        public static bool IsUserExist(string email)
        {
            if (UserRepo.IsUserExistsByEmail(email))
            {
                Console.WriteLine("User already exists");

                return true;
            }

            return false;
        }
    }
}
