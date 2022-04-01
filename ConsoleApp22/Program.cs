using System;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Book book2 = new Book();
            book2.Name = "MUSTAFA";
            book2.AuthorName = "Qasimzade";
            book2.PageCount = 1;
            Book book3 = new Book();
            book3.Name = "ELI";
            book3.AuthorName = "Veli";
            book3.PageCount = 2;
            Book Books= new Book();
            Library books = new Library();
           
            books.Book1.Add(book2);
            books.Book1.Add(book3);
            Console.WriteLine("kitab tapmaq ucun bura :");
            foreach (Book item in books.FindAllBooksByName("asd"))
            {
                Console.WriteLine($"BookName : {item.Name} BookPageCount : {item.PageCount} BookAuthorName : {item.AuthorName}");
            }

            Console.WriteLine("kitab count :");
            foreach (Book item in books.Book1)
            {
                Console.WriteLine($"BookName : {item.Name} BookPageCount : {item.PageCount} BookAuthorName : {item.AuthorName}");
            }
            Console.WriteLine("filtir edilmis kitab(seyfe)");
            foreach (Book item in books.FindAllBooksByPageCountRange(1, 5))
            {
                Console.WriteLine($"kitab ad : {item.Name} seyfe : {item.PageCount} bookAuthorName : {item.AuthorName}");
            }
           



        }
    }
}
