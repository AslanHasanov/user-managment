using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
