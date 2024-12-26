using ibraryManagementSystem;
using ibraryManagementSystem.Models;



public class Program
{
    public static void Main(string[] args)
    {
        LibraryContext context = new LibraryContext();

        SeedData(context);
        Console.WriteLine("Hello");
        var books = context.Books.ToList();
        var authors = context.Authors.ToList();

        foreach(var book in books)
        {
            Console.WriteLine(book.Title);
        }

        foreach(var author in authors)
        {
            Console.WriteLine(author.Name);
        }
        
    }



    private static void SeedData(LibraryContext context)
{
    if(!context.Libraries.Any())
    {
        var library = new Library{Name="Main Library"};

        var author1 = new Author{Name="Author A"};
        var author2 = new Author { Name = "Author B" };


        var book1 = new Book { Title = "Book 1", YearPublished = 2000, Author = author1, Library = library };
        var book2 = new Book { Title = "Book 2", YearPublished = 2005, Author = author1, Library = library };
        var book3 = new Book { Title = "Book 3", YearPublished = 2010, Author = author2, Library = library };

        var borrower1 = new Borrower { Name = "John Doe", Age = 25 };
        var borrower2 = new Borrower { Name = "Jane Smith", Age = 30 };

        var record1 = new BorrowingRecord { Book = book1, Borrower = borrower1, BorrowedDate = DateTime.Now.AddDays(-10) };
        var record2 = new BorrowingRecord { Book = book2, Borrower = borrower2, BorrowedDate = DateTime.Now.AddDays(-5) };

        context.Libraries.Add(library);
        context.Authors.AddRange(author1, author2);
        context.Books.AddRange(book1, book2, book3);
        context.Borrowers.AddRange(borrower1, borrower2);
        context.BorrowingRecords.AddRange(record1, record2);

        context.SaveChanges();

    }
}



}