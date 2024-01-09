using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Телефонная_книга;

namespace Телефонная_книга {
    internal class Menu {

        //static PhoneBook phoneBook = new PhoneBook();

        public static void displayMenu()
        {
            Console.Clear();
            Console.WriteLine("Главное меню\n");
            Console.WriteLine("Выберите действие:\nadd - добавить контакт; view - посмотреть в книгу; close - закрыть книгу");

            dataEntry: string action = Console.ReadLine();

            switch (action) {
                case "add": // добавление чела
                    PhoneBook.addContact();
                    break;

                case "view": // просмотр телефонной книги
                    PhoneBook.displayContact();
                    break;

                case "close": // закрытие телефонной книги
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Ошибка ввода! Повторите ввод:");
                    goto dataEntry;
                    //break;
            }
        }

/*        Menu(PhoneBook phoneBook)
        {
            this.phoneBook = phoneBook;
        }*/
    }
}
