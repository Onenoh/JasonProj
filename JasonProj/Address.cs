using System;
using System.Collections.Generic;
using System.Text;

namespace JasonProj
{
    internal class Address
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string MainAddress { get; set; }
        public string City { get; set; }
        public string LGA { get; set; }
        public string State { get; set; }
        public Guid UserId { get; set; }
    }
}
