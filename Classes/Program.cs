using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {   
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord Of The Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.author);
            Console.ReadLine();
        }
    }
}