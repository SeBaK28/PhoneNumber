using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Contacts
    {
        public Contacts(string name, string number) 
        { 
            Name = name;
            Number = number;
        }
        public string Name { get ; set; }
        public string Number { get; set; }
    }
}
