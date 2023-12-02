using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class PhoneBook
    {
        public List<Contacts> Contacts{get; set;} = new List<Contacts>();

        public void AddContact(Contacts contact)
        {
            Contacts.Add(contact);
            InputLength(contact);
            NumberLength(contact);
        }

        private void InputLength(Contacts contact)
        {
            if(contact.Name.Length <  3)
            {
                Console.WriteLine("Wrong name");
                return;
            }
            else
            {
                return;
            }
        }
        private void NumberLength(Contacts contact)
        {
            if (contact.Number.Length < 3)
            {
                Console.WriteLine("Wrong Number - inserted number is to short");
                return;
            }else if(contact.Number.Length > 3)
            {
                Console.WriteLine("Wrong Number - inserted number is to logn");
                return;
            }
            else
            {
                return;
            }

        }

        private void DisplayContactDetails(Contacts contact) 
        {
            Console.WriteLine($"Contact {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contacts> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayContact(string number) 
        {
            var contact = Contacts.FirstOrDefault(x => x.Number == number);
            if (contact == null) 
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);            
            }
        }
        public void DisplayAllContacts() 
        {
            DisplayContactsDetails(Contacts);
        }
        public void DisplayMatchingContacts (string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
        public void DeleteMatchingContact (string findNumber)
        {
            var numberToDelete = Contacts.FirstOrDefault(x => x.Number == findNumber);
            if (numberToDelete != null)
            {
                Contacts.Remove(numberToDelete);
            }
        }
    }
}
