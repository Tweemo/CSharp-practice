using System;
namespace CSharp
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string atitle, string aauthor, int apages)
        {
            Console.WriteLine("Creating book");
            title = atitle;
            author = aauthor;
            pages = apages;

        }
    }
}

