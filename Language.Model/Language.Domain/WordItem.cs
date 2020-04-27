using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Domain
{
   public class WordItem
    {
        public Guid Id { get; set; }
        public Package Package { get; set; }
        public string WordKey { get; set; }
        public string WordValue { get; set; }
    }
}
