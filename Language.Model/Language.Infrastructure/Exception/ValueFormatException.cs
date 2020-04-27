using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Infrastructure.Exception
{
   public class ValueFormatException : CustomException
   {
       public ValueFormatException() : base("Format is incorrect!")
       {
       }

       public ValueFormatException(string message) : base(message)
       {
       }
   }
}
