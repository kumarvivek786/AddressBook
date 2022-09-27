using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        public List<Contact> contactlist = new List<Contact>();
        public void AddNewContact()
        {
            Contact contact = new Contact();

            Console.WriteLine("Enter First Name");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Second Name");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();

            Console.WriteLine("enter Phone No.");
            contact.PhNo = Console.ReadLine();

            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Zip Code");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter Email Id");
            contact.Email = Console.ReadLine();

            contactlist.Add(contact);

        }
        public void Display()
        {
            foreach (Contact contact in contactlist)
            {
                Console.WriteLine(contact.FirstName);
                Console.WriteLine(contact.LastName);
                Console.WriteLine(contact.Address);
                Console.WriteLine(contact.City);
                Console.WriteLine(contact.State);
                Console.WriteLine(contact.PhNo);
                Console.WriteLine(contact.Zip);
                Console.WriteLine(contact.Email);

            }
        }

    }
}
