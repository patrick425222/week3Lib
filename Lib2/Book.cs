using System;
using System.Collections.Generic;
using System.Text;

namespace Lib2
{
    public class Book
    {
        public string Title;
        public string Author;
        public int ISBN;

        // Parameterized constructor
        public Book(string booktitle, string bookauthor, int bookisbn)
        {
            Title = booktitle;
            Author = bookauthor;
            ISBN = bookisbn;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
        }
    }
}
