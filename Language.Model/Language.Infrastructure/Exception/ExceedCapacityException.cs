using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Infrastructure.Exception
{
   public class ExceedCapacityException : CustomException
   {
   public ExceedCapacityException() : base("Input value is More than capacity is allowed!")
   {
   }

   public ExceedCapacityException(string message) : base(message)
   {
   }
   }
}
