using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Domain
{
    public class Summary
    {
        public Guid Id { get; set; }
        public Profile Profile { get; set; }
        public DateTime DateModify { get; set; }
        public string Body { get; set; } 
    }
}
