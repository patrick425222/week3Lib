using Lib2;

Book book = new Book();

// This is info for the book class
book.Title = "C# for beginners";
book.Author = "Steve Bills";
book.ISBN = 12345678;
book.DisplayInfo();

// Add another book
Book book1 = new Book();
book1.Title = "Methods and classes";
book1.Author = "John Microsoft";
book1.ISBN = 87654321;
book1.DisplayInfo();