using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Domain
{

    public class Principal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Package_Principal> PackagePrincipals { get; set; }
        public Profile Profile { get; set; }
        public Guid ProfileId { get; set; }
        public ICollection<Message> SendMessages { get; set; }
        public ICollection<Message> ReceivedMessages { get; set; }
    }
}
