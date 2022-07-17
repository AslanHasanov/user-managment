using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment.ApplicationLogic.Validations;
using UserManagment.DataBase.Models;
using UserManagment.DataBase.Repo;

namespace UserManagment.ApplicationLogic
{
    internal class Authentication
    {
        public static void Register()
        {
            string firstName = GetFirstName();

            string lastName = GetLastName();

            string email = GetEmail();

            string password = GetPassword();

            Console.WriteLine();

            if (!UserValidation.IsUserExist(email))
            {
                User user = UserRepo.AddUser(firstName, lastName, email, password);
                Console.WriteLine("You successfully registered, now you can login with your new account!");
                Console.WriteLine($"User's details: {user.GetUserInfo()} ");
            }

        }

        public static void Login()
        {
            Console.Write("Please enter your e-mail : ");
            string email = Console.ReadLine();

            Console.Write("Please enter your password : ");
            string password = Console.ReadLine();


            if (email == "admin@gmail.com" && password == "123321")
            {
                Console.WriteLine("/show-users");
                Console.WriteLine("Enter command :");
                string command = Console.ReadLine();
                if (command == "/show-users")
                {
                    foreach (User user in UserRepo.Users)
                    {
                        Console.WriteLine(user.GetAllForAdmin());
                    }
                }
                else
                {
                    Console.WriteLine($"{command} not found");
                }
            }
            else if (UserRepo.IsUserExistByEmailAndPassword(email, password))
            {
                User user = UserRepo.GetUserByEmail(email);
                Console.WriteLine($"Welcome to your account :  {user.GetUserInfo()}");
            }
            else
            {
                Console.WriteLine("404 not found");
            }
        }

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
