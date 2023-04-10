using System;
using Laba2_10;

class RCIS
{
    static void Main()
    {
        List<HomeLibrary> LibraryBooks = new List<HomeLibrary>();

        while (true)
        {
            Console.WriteLine(
                "1 - Add book\n2 - Delete book\n3 - Book search by parameter\n4 - sort book by field\nOther number - finish");
            int op = int.Parse(Console.ReadLine()!);
            switch (op)
            {
                case 1:
                    Console.Write("Введите имя автора: ");
                    string AuthorName = Console.ReadLine()!;
                    Console.Write("Введите кол-во страниц: ");
                    int numberPages = int.Parse(Console.ReadLine()!);
                    Console.Write("Введите дату создания книги: ");
                    int date = int.Parse(Console.ReadLine()!);
                    Console.Write("Введите название книги: ");
                    string name = Console.ReadLine()!;
                    LibraryBooks.Add(new HomeLibrary(AuthorName, numberPages, date, name));
                    break;
                case 2:
                    Console.Write("Введите название книги для удаления: ");
                    string DeleteName = Console.ReadLine()!;
                    LibraryBooks.Remove(LibraryBooks.First(book => book.Name == DeleteName));
                    break;
                case 3:
                    int Val;
                    Console.Write(
                        "Введите параметр поиска книги(1 - Name,2 - AuthorName,3 - NumberOfPages,4 - DateOfCreation): ");
                    int parametr = int.Parse(Console.ReadLine()!);
                    Console.Write("Введите значение пераметра: ");
                    string value = Console.ReadLine()!;
                    HomeLibrary result = new HomeLibrary();
                    switch (parametr)
                    {
                        case 1:
                            result = LibraryBooks.First(book => book.Name == value);
                            break;
                        case 2:
                            result = LibraryBooks.First(book => book.AuthorName == value);
                            break;
                        case 3:
                            Val = int.Parse(value);
                            result = LibraryBooks.First(book => book.NumberOfPages == Val);
                            break;
                        case 4:
                            Val = int.Parse(value);
                            result = LibraryBooks.First(book => book.DateOfCreation == Val);
                            break;
                    }

                    result.Info();
                    break;
                case 4:
                    Console.Write("Введите параметр сортировки книг(1 - Name,2 - AuthorName,3 - NumberOfPages,4 - DateOfCreation): ");
                    int par = int.Parse(Console.ReadLine()!);
                    WriteInfo(par, LibraryBooks);
                    break;
                default:
                    return;
            }
        }
    }

    static void WriteInfo(int number, List<HomeLibrary> librarybooks)
    {
        switch (number)
        {
            case 1:
                librarybooks.OrderBy(book => book.Name);
                break;
            case 2:
                librarybooks.OrderBy(book => book.AuthorName);
                break;
            case 3:
                librarybooks.OrderBy(book => book.NumberOfPages);
                break;
            case 4:
                librarybooks.OrderBy(book => book.DateOfCreation);
                break;
        }
        foreach (var book in librarybooks)
        {
            book.Info();
        }
    }
}