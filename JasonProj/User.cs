using System;
using System.Collections.Generic;
using System.Text;

namespace JasonProj
{
    internal class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get => this.Email.Split("@")[0]; }   //emmanuel.ogidan@sbc.com
        public List<string> PhoneNumbers { get; set; } = new List<string>();
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
