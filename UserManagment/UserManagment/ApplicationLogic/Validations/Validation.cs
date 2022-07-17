using System;
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
    }
}
