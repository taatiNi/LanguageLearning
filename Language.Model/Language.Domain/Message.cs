using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Domain
{
    public class Message
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public Package Package { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public Principal Sender { get; set; }
        public Principal Receiver { get; set; }
    }
}
