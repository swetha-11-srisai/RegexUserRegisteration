using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegisteration
{
    class UserRegisterationForm
    {
        public string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{3,}$";
        public string LASTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{3,}$";
        public string EMAIL_REGEX = "^[A-Za-z0-9]+[.+_-]{0,1}[a-z0-9A-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";
        public string PHONENUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";
        public bool ValidateFirstName()
        {
            return Regex.IsMatch("Swetha",FIRSTNAME_REGEX);
        }
        public bool ValidateLastName()
        {
            return Regex.IsMatch("Eswar", LASTNAME_REGEX);
        }
        public bool ValidateEmail()
        {
            return Regex.IsMatch("swetha.11@sasi.in", EMAIL_REGEX);
        }
        public bool ValidatePhoneNumber()
        {
            return Regex.IsMatch("6321456987", PHONENUMBER_REGEX);
        }
    }
}
