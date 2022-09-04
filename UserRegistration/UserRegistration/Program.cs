using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[a-zA-Z]{2,}";
        public static string EMAIL_PATTERN = "^[a-zA-Z0-9]+[.(a-zA-Z0-9)]*(\\@)[a-zA-Z0-9]+(\\.)[a-z]{2,3}[.(a-z)]*$";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome_To_UserRegistration_RegeEx");
            FirstNameVal();
            LastNameVal();
            EmailValidation();
            MobileValidation();
        }
        public static void FirstNameVal()
        {
            Regex rg = new Regex(REGEX_PATTERN);
            Console.Write("Enter First Name: ");
            string first_name = Console.ReadLine();
            bool validate = rg.IsMatch(first_name);
            if (validate)
                Console.WriteLine("Name is Valid : " + first_name);
            else
                Console.WriteLine("Invalid FirstName");
        }
        public static void LastNameVal()
        {
            Regex rg = new Regex(REGEX_PATTERN);
            Console.Write("Enter Last Name: ");
            string last_name = Console.ReadLine();
            bool validate = rg.IsMatch(last_name);
            if (validate)
                Console.WriteLine("Name is Valid : " + last_name);
            else
                Console.WriteLine("Invalid LastName");
        }
        public static void EmailValidation()
        {
            Regex rg = new Regex(EMAIL_PATTERN);
            Console.Write("Enter E-mail: ");
            string email = Console.ReadLine();
            bool validate = rg.IsMatch(email);
            if (validate)
                Console.WriteLine("Email is valid : " + email);
            else
                Console.WriteLine("Invalid E-mail.");
        }
        public static void MobileValidation()
        {
            string MobilePattern = "^(91){1}[ ]+[0-9]{10}$";
            Regex rg = new Regex(MobilePattern);
            Console.Write("Enter Mobile_NO: +");
            string mobile = Console.ReadLine();
            bool validate = rg.IsMatch(mobile);
            if (validate)
                Console.WriteLine("Mobile is valid : " + mobile);
            else
                Console.WriteLine("Invalid Mobile..");
        }
    }
}
