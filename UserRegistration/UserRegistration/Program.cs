using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
   public class Program
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static Program p = new Program();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome_To_UserRegistration_RegeEx");
            Console.Write("Enter First Name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine(p.FirstNameVal(FirstName));
            Console.Write("Enter Last Name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine(p.LastNameVal(LastName));
            Console.Write("Enter E-mail: ");
            string Email = Console.ReadLine();
            Console.WriteLine(p.EmailValidation(Email));
            Console.Write("Enter Mobile_NO: ");
            string mobile = Console.ReadLine();
            Console.WriteLine(p.MobileValidation(mobile));
            Console.Write("Enter Password : ");
            string password = Console.ReadLine();
            Console.WriteLine(p.PasswordRule(password));
        }
        public bool FirstNameVal(string first_name)
        {
            Regex rg = new Regex(REGEX_PATTERN);
            return rg.IsMatch(first_name); ;
        }
        public bool LastNameVal(string last_name)
        {
            Regex rg = new Regex(REGEX_PATTERN);
            bool validate = rg.IsMatch(last_name);
            return validate;
        }
        public bool EmailValidation(string email)
        {
            string EMAIL_PATTERN = "^[a-zA-Z0-9]+[.(a-zA-Z0-9)]*(\\@)[a-zA-Z0-9]+(\\.)[a-z]{2,3}[.(a-z)]*$";
            Regex rg = new Regex(EMAIL_PATTERN);
            bool validate = rg.IsMatch(email);
            return validate;
        }
        public bool MobileValidation(string mobile)
        {
            string MobilePattern = "^(91){1}[ ]+[0-9]{10}$";
            Regex rg = new Regex(MobilePattern);
            bool validate = rg.IsMatch(mobile);
            return validate;
        }
        public bool PasswordRule(string password)
        {
            string PasswordPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[~!@#$%^&*.-])[a-zA-Z0-9].{8,}$";
            Regex rg = new Regex(PasswordPattern);
            bool validate = rg.IsMatch(password);
            return validate;
        }
    }
}
