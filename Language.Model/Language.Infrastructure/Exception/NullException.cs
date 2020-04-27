using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Infrastructure.Exception
{
    public class NullException:CustomException
    {
        public NullException() : base("Input value is null!")
        { 
        }

        public NullException(string message) : base(message)
        { 
        } 
    }
}
