﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserManagment.ApplicationLogic.Validations
{
    internal class Validation
    {
        public static bool IsValidText(string text)
        {
            string pattern = "(?=^.{3,30}$)([A-Z]+[a-z]+)";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(text))
            {
                return true;
            }

            return false;
        }

        public static bool IsConsistEmail(string email)
        {
            string pattern = @"^([a-zA-Z0-9]{10,30})(@code\.edu\.az)$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(email))
            {
                return true;
            }

            return false;
        }
    }
}
