using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-1 create a Contacts
            Console.WriteLine("Welcome to Address Book");
            AddressBook address = new AddressBook();
            address.AddNewContact();
            Console.WriteLine();
            address.Display();
            Console.ReadLine();
        }
      
    }
}