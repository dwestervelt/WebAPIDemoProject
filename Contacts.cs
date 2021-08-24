using System;
using System.Collections.Generic;

namespace WebAPIDemoProject
{
    public class Contacts
    {
        public int Id { get; set; }
        public ContactsName Name { get; set; }
        public ContactsAddress Address { get; set; } 
        
        public ICollection<ContactsPhone> Phone { get; set; }

        public ContactsEmail Email { get; set; }

    }
}
