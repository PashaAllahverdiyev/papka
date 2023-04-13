
using App.Core.Models;

Book[] Books = new Book[0];
Console.WriteLine("0. Close");
Console.WriteLine("1. Show Books");
Console.WriteLine("2. Create Book");

string RequestNumber = Console.ReadLine();

while (RequestNumber != "0")
{

    switch (RequestNumber)
    {
        case "1":
            if (Books.Length == 0)
            {
                Console.WriteLine("Not avialable Books");
            }
            foreach (Book Book in Books)
            {
                Book.GetFullInfo();
            }
            break;

        case "2":
            Book newBook = new Book();

            Console.WriteLine("Add name:");
            newBook.name = Console.ReadLine();
            Console.WriteLine("Add price:");
            newBook.price = Console.ReadLine();

            Array.Resize(ref Books, Books.Length + 1);

            Books[Books.Length - 1] = newBook;

            break;

        default:
            Console.WriteLine("Select correct number");
            break;


    }
    Console.WriteLine("0. Close");
    Console.WriteLine("1. Show Books");
    Console.WriteLine("2. Create Book");

    RequestNumber = Console.ReadLine();


}