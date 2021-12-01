using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegisteration
{
    class UserRegisterationForm
    {
        public string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{3,}$";
        public bool ValidateFirstName()
        {
            return Regex.IsMatch("Swetha",FIRSTNAME_REGEX);
        }
    }
}
