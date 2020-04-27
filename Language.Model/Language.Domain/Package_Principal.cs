using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Domain
{
    public class Package_Principal
    {
        public Guid PackageId { get; set; }
        public Guid PrincipalId { get; set; }
        public Package Package { get; set; }
        public Principal Principal { get; set; }
    }
}
