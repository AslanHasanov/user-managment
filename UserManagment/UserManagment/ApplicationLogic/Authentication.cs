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

        public static string GetLastName()
        {
            Console.Write("Please enter your last name : ");
            string lastName = Console.ReadLine();

            while (!UserValidation.IsValidLastName(lastName))
            {
                Console.Write("Please enter correct last name : ");
                lastName = Console.ReadLine();
            }

            return lastName;
        }

        public static string GetEmail()
        {
            Console.Write("Please enter your e-mail : ");
            string email = Console.ReadLine();

            while (!UserValidation.IsValidEmail(email))
            {
                Console.Write("Please enter correct e-mail : ");
                email = Console.ReadLine();
            }

            return email;
        }

        public static string GetPassword()
        {
            Console.Write("Please enter your password : ");
            string password = Console.ReadLine();

            while (!UserValidation.IsValidPassword(password))
            {
                Console.Write("Please enter correct password : ");
                password = Console.ReadLine();
            }
            Console.Write("Please confirm password : ");
            string confirmPassword = Console.ReadLine();


            while (!UserValidation.IsValidConfirmPassword(password, confirmPassword))
            {
                Console.Write("Please confirm correct password : ");
            }

            return password;
        }

    }



}
