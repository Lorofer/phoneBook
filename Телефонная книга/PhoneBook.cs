using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Телефонная_книга {
    internal class PhoneBook {
        static private List<Contact> contacts = new List<Contact>();

        public static void addContact()
        {
            Console.Clear();
            Console.WriteLine("Добавление контакта\n");
            Console.WriteLine("Введи имя:");
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
                Console.WriteLine("Выберите действие:\nmenu - перейти в главное меню; add - добавить контакт; close - закрыть книгу");
                
                dataEntry: string action = Console.ReadLine();
                switch (action) {
                    case "add": // добавление чела
                        addContact();
                        break;

                    case "menu": // переход в главное меню
                        Menu.displayMenu();
                        break;

                    case "close": // закрытие телефонной книги
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Допущена опечатка! Повторите ввод:");
                        goto dataEntry;
                }
            }
            else {
                foreach (var contact in contacts) {
                    Console.WriteLine($"Имя: {contact.Name} – Номер телефона: {contact.PhoneNumber}, Адрес: {contact.Address}");
                }

                Console.WriteLine("\nВыберите действие: close - закрыть книгу; menu - перейти в главное меню");

                dataEntry: string action = Console.ReadLine();
                switch (action) {
                    case "menu": // переход в главное меню
                        Menu.displayMenu();
                        break;

                    case "close": // закрытие телефонной книги
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Допущена опечатка! Повторите ввод:");
                        goto dataEntry;
                }
            }   
        }
    }
}
