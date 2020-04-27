using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Infrastructure.Exception
{
    public class CustomException : System.Exception
    {
        public CustomException(string message) => Message = message;

        public override string Message { get; }
    }
}
