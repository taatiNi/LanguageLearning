using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Domain
{
    public class Package
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public ICollection<WordItem> WordItems { get; set; }
        public List<Package_Principal> PackagePrincipals { get; set; } 
    }
}
