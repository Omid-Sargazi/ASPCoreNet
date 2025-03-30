public class User
{
    public string Name { get; set; }
    public List<Book> BorrowedBooks {get;} = new List<Book>();
    public void BorrowBook(Book book)
    {
        if(book.IsBorrowed)
        {
            throw new InvalidOperationException("Book is already borrowed");
        }
        book.Borrow();
        BorrowedBooks.Add(book);
    }
    public void ReturnBook(Book book)
    {
        if(!book.IsBorrowed)
        {
            throw new InvalidOperationException("Book is not borrowed");
        }
        book.Return();
        BorrowedBooks.Remove(book);
    }
}