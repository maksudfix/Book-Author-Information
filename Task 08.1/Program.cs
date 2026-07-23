using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
class Books
{
    public int BookId { get; set; }
    public string Title { get; set; }
    
    public int AuthorId { get; set; }
    public string Genre { get; set; }
    public DateTime PublishedYear { get; set; }
    public Books(int bookid, string title, int authorid, string genre, DateTime publisheddate)
    {
        BookId = bookid;
        Title = title;
        AuthorId = authorid;
        Genre = genre;
        PublishedYear = publisheddate;
    }
}
class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public Author(int authorid, string name, string country)
    {
        AuthorId = authorid;
        Name = name;
        Country = country;
    }
}
class AuthorBook
{
    static void Main()
    {
        List<Books> books = new List<Books>
        {
            new Books(1, "The Canon of Medicine", 220, "Medicine", new DateTime(1025, 1, 1)),
            new Books(2, "The Book of Healing", 231, "Philosophy", new DateTime(1027, 1, 1)),
            new Books(3, "The Revival of the Religious Sciences", 242, "Islamic Studies", new DateTime(1100, 1, 1)),
            new Books(4, "The Incoherence of the Philosophers", 252, "Philosophy", new DateTime(1095, 1, 1)),
            new Books(5, "Tafsir Ibn Kathir", 263, "Quran Tafsir", new DateTime(1373, 1, 1)),
            new Books(6, "Sahih al-Bukhari", 274, "Hadith", new DateTime(846, 1, 1)),
            new Books(7, "Majmu' al-Fatawa", 285, "Islamic Law", new DateTime(1328, 1, 1)),
            new Books(8, "Masnavi", 296, "Poetry", new DateTime(1258, 1, 1)),
        };
        List<Author> authors = new List<Author>
        {
            new Author(220, "Ibn Sina (Avicenna)", "Persia"),
            new Author(231, "Imam Al-Ghazali", "Persia"),
            new Author(242, "Ibn Kathir", "Syria"),
            new Author(252, "Imam Al-Bukhari", "Uzbekistan"),
            new Author(263, "Ibn Taymiyyah", "Syria"),
            new Author(274, "Jalaluddin Rumi", "Persia"),
            new Author(285, "Ibn Khaldun", "Tunisia"),
            new Author(296, "Al-Farabi", "Kazakhstan")
        };
        var bookbyauthor=books.Where(b=>b.PublishedYear.Year>700)
            .Join(
            authors,
            book => book.AuthorId,
            author => author.AuthorId,
            (book, author)=> new
            {
                BookTitle=book.Title,
                AuthorName = author.Name,
                BookPublished=book.PublishedYear
            }
            )
            .OrderBy(x => x.BookPublished)
            .ThenBy(x => x.BookTitle)
            .Select(x => new
               {
                   x.BookTitle,
                   x.AuthorName,
                   x.BookPublished
               })
               .ToList();
        Console.WriteLine("--Book Information--");
        foreach (var info in bookbyauthor)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Book Title: {info.BookTitle}");
            Console.WriteLine($"Writer   : {info.AuthorName}");
            Console.WriteLine($"Published : {info.BookPublished.Year}");
            Console.ResetColor();
        }
    }
}