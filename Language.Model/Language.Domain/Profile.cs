using System;
using System.Collections.Generic;

namespace Language.Domain
{
    public class Profile
    {
        public Guid Id { get; set; }
        public Guid SummaryId { get; set; }
        public Principal Principal{ get; set; }
        public Summary Summary { get; set; }  
        public ICollection<Experience> Experiences { get; set; }
    }
}
