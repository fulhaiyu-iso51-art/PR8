using System.Collections.Generic;
using System.Linq;

public class Library
{
    public List<Book> Books { get; set; }

    public Library(List<Book> books)
    {
        Books = books;
    }

    public Book Find(string title)
    {
        return Books.FirstOrDefault(b => b.Title == title);
    }
}