using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
namespace UserRegistration
{
    public class RegExValidation
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public bool FirstNameVal(string fname)
        {
            Regex rg = new Regex(REGEX_PATTERN);
            return rg.IsMatch(fname); ;
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
            string PasswordPattern = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9].{8,}$";
            Regex rg = new Regex(PasswordPattern);
            bool validate = rg.IsMatch(password);
            return validate;
        }
        public bool MessageCheck(string Message)
        {
            var MessagePattern = "Happy";
            Regex rg = new Regex(MessagePattern);
            bool validate = rg.IsMatch(Message);
            return validate;
        }
        public string CheckMultipleEmail(string Mail1, string Mail2, string Mail3)
        {
            RegExValidation Mail = new RegExValidation();
            bool MailEntry1 = Mail.EmailValidation(Mail1);
            bool MailEntry2 = Mail.EmailValidation(Mail2);
            bool MailEntry3 = Mail.EmailValidation(Mail3);
            if (MailEntry1 && MailEntry2 && MailEntry3)
                return "succesfull";
            else
                return "fail";
        }
    }
}