using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Телефонная_книга;
using static System.Collections.Specialized.BitVector32;

namespace Телефонная_книга {
    internal class Menu {
        public static void displayMenu()
        {
            string action;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Главное меню\n");
                Console.WriteLine("Выберите действие:\nadd - добавить контакт; view - посмотреть в книгу; exit - выйти");
                action = Console.ReadLine();

                switch (action) {
                    case "add":
                        PhoneBook.addContact();
                        break;

                    case "view":
                        PhoneBook.displayContact();
                        break;

                    case "exit":
                        return;

                    default:
                        Console.WriteLine("Ошибка ввода! Повторите ввод:");
                        break;
                }
            }
        }
    }
}
