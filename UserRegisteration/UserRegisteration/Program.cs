using System;

namespace UserRegisteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registeration form");
            UserRegisterationForm user = new UserRegisterationForm();
            bool result = user.ValidateFirstName();
            bool resultlast = user.ValidateLastName();
            bool resultemail = user.ValidateEmail();
            bool resultnumber = user.ValidatePhoneNumber();
            bool resultpwd = user.ValidatePassword();
            Console.WriteLine("Name:" + result);
            Console.WriteLine("LastName:"+resultlast);
            Console.WriteLine("Email:"+resultemail);
            Console.WriteLine("PhoneNumber:" + resultnumber);
            Console.WriteLine("PWD:" + resultpwd);
        }
    }
}
