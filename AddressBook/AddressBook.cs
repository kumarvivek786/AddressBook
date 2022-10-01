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
        public void EditContact()
        {
            Console.WriteLine("Enter The First Name You Want To Edit");
            string firstname = Console.ReadLine();
            foreach (Contact contact in contactlist)
            {
                if (contact.FirstName.ToLower() == firstname.ToLower())
                {
                    Console.WriteLine("Enter which Information You Want To Change");
                    Console.WriteLine("\nEnter 1 To Edit Last Name,\n2 To Change The City,\n3 To State,\n4 To Zip,\n5 to Email,\n6 to PhoneNumber");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter The Lastname");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter The City");
                            contact.City = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter The State");
                            contact.State = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter The Zip");
                            contact.Zip = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the Email");
                            contact.Email = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the PhoneNumber");
                            contact.PhNo = Console.ReadLine();
                            break;
                    }
                    return;
                }
            }
            Console.WriteLine("No Contact With this Firstname");
        }
        public void RemoveContact()
        {
            Console.WriteLine("enter the first name you want to remove");
            string firstname = Console.ReadLine();
            foreach (Contact contact in contactlist)
            {
                if (contact.FirstName.ToLower() == firstname.ToLower())
                {
                    contactlist.Remove(contact);
                    Console.WriteLine("the firstname you have entered is deleted ");
                    return;
                }
            }
            Console.WriteLine("contact not found");
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
