using System;

namespace Language.Domain
{
    public class Experience
    {
        public Guid Id { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime DateModify { get; set; }
        public string Body { get; set; }
        public Profile Profile { get; set; }
    }
}
