using System;
using System.Collections.Generic;
using System.Text;

namespace Lib2
{
    public class Book
    {
        // Private Fields
        private string _title;
        private string _author;
        private int _isbn;


        // Public Properties

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        // Constructor
        public Book(string booktitle, string bookauthor, int bookisbn)
        {
            Title = booktitle;
            Author = bookauthor;
            ISBN = bookisbn;
        }

        // Methods



        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
        }
    }
}
