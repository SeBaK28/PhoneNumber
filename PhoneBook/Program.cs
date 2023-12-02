using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook");
            Console.WriteLine("Set operation");
            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 Display all contacts");
            Console.WriteLine("4 Search contacts");
            Console.WriteLine("5 Delete contact");
            Console.WriteLine("6 To exit");
            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();
            while (true) 
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert Number");
                        var number = Console.ReadLine();
                        Console.WriteLine("Insert Name");
                        var name = Console.ReadLine();

                        var newContact = new Contacts(name, number);

                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Insert Number");
                        var numberToSearch = Console.ReadLine();

                        phoneBook.DisplayContact(numberToSearch);
                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "5":
                        Console.WriteLine("Type number which you waned to delete");
                        phoneBook.DisplayAllContacts();
                        var findNumber = Console.ReadLine();
                        phoneBook.DeleteMatchingContact(findNumber);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid operatin");
                        break;

                }
                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();
            }
            
        }
    }
}
