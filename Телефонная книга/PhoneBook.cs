using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PhoneBook {
    internal class PhoneBook {
        static private List<Contact> contacts = new List<Contact>();

        public static void addContact()
        {
            Console.Clear();
            Console.WriteLine("Добавление контакта\n\nВведи имя:");
            string name = Console.ReadLine();
            
            Console.WriteLine("Введи номер телефона:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Введи адрес:");
            string address = Console.ReadLine();

            Contact newContact = new Contact { Name = name, PhoneNumber = phoneNumber, Address = address };

            contacts.Add(newContact);
        }
        public static void displayContact()
        {
            Console.Clear();
            Console.WriteLine("Просмотр книги\n");

            if (contacts.Count == 0) {
                Console.WriteLine("Телефонная книга пуста\n");
                Console.WriteLine("Выберите действие:\nmenu - перейти в главное меню; add - добавить контакт");
                
                string action = Console.ReadLine();
                while(true) {
                    switch (action) {
                        case "add":
                            addContact();
                            break;

                        case "menu":
                            return;

                        default:
                            Console.WriteLine("Допущена опечатка! Повторите ввод:");
                            break;
                    }
                }        
            }
            else {
                foreach (var contact in contacts) {
                    Console.WriteLine($"{contact.Name} – {contact.PhoneNumber}, {contact.Address}");
                }

                Console.WriteLine("\nВыберите действие: menu - перейти в главное меню");

                string action = Console.ReadLine();
                while (true) {
                    switch (action) {
                        case "add":
                            addContact();
                            break;

                        case "menu":
                            return;

                        default:
                            Console.WriteLine("Допущена опечатка! Повторите ввод:");
                            break;
                    }
                }
            }   
        }
    }
}
