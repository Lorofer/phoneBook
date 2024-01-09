using Телефонная_книга;

PhoneBook phoneBook = new PhoneBook();
while (true) {
    Console.WriteLine("Че делаем? add; view; to beat the forehead?");

    dataEntry: string action = Console.ReadLine();

    switch (action) {
        case "add": // добавление чела
            phoneBook.addContact();
            break;

        case "view": // просмотр телефонной книги
            phoneBook.displayContact();
            break;

        case "to beat the forehead":
            Console.WriteLine("to beat the forehead");
            //очиска телефонной книги
            break;
        default:
            Console.WriteLine("Ты ошибся! Повтори ввод:");
            goto dataEntry;
            //break;
    }
}