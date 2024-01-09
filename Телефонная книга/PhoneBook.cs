using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Телефонная_книга {
    internal class PhoneBook {
        private List<Contact> contacts = new List<Contact>();

        public void addContact()
        {
            Console.WriteLine("Введи имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введи номер телефона:");
            string phoneNumber = Console.ReadLine();

            Contact newContact = new Contact { Name = name, PhoneNumber = phoneNumber };

            contacts.Add(newContact);
        }
        public void displayContact()
        {
            foreach(var contact in contacts) {
                Console.WriteLine($"Name: {contact.Name} – Phone Number: {contact.PhoneNumber}");
            }
        }
    }
}
