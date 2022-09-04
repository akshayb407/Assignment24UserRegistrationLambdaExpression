using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
   public class Program
    {
        public static RegExValidation regex = new RegExValidation();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome_To_UserRegistration");
            Console.Write("Enter First Name : ");
            string first_name = Console.ReadLine();
            Console.WriteLine(regex.FirstNameVal(first_name));
            Console.Write("Enter Last Name : ");
            string last_name = Console.ReadLine();
            Console.WriteLine(regex.LastNameVal(last_name));
            Console.Write("Enter E-mail : ");
            string email = Console.ReadLine();
            Console.WriteLine(regex.EmailValidation(email));
            Console.Write("Enter Mobile_NO : ");
            string mobile = Console.ReadLine();
            Console.WriteLine(regex.MobileValidation(mobile));
            Console.Write("Enter Password : ");
            string password = Console.ReadLine();
            Console.WriteLine(regex.PasswordRule(password));

        }
    }
}
