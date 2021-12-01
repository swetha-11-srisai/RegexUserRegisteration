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
            Console.WriteLine("Name:" + result);
           Console.WriteLine("LastName:"+resultlast);
            Console.WriteLine("Email:"+resultemail);
        }
    }
}
