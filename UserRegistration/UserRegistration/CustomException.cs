using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FirstName,
            INVALID_LastName,
            INVALID_EmailId,
            INVALID_Zip,
            INVALID_MobileNo
        }
        private readonly ExceptionType Type;
        public CustomException(ExceptionType Type, string Message) : base(Message)
        {
            this.Type = Type;
        }
    }
}
