using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace userManagement.validations
{
    public class Validations
    {

        public bool validateName (string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-ZñÑáéíóúÁÉÍÓÚ\s\d']{2,}$");
        }
        public bool validateEmail (string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-ZñÑ]{2,}$");
        }
        public bool validatePassword (string password)
        {
            return !string.IsNullOrEmpty(password);
        }
        public bool validateDouble (string num)
        {
           return  Regex.IsMatch(num, @"^-?\d+$");
        }
    }
}
