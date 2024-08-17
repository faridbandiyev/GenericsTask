using GenericsTask.Exceptions;
using GenericsTask;


try
{
    Library library = new Library(2);

    Book book1 = new Book("The Catcher in the Rye", 29.99, 10, "J.D. Salinger", 277);
    library.AddBook(book1);

    Book book2 = new Book("1984", 19.99, 5, "George Orwell", 328);
    library.AddBook(book2);

    book1.Sell();
    book1.ShowInfo();

    library.RemoveById(1);

    Book foundBook = library.GetBookById(2);
    foundBook.ShowInfo();

    Book book3 = new Book("Brave New World", 24.99, 8, "Aldous Huxley", 311);
    library.AddBook(book3);

}
catch (CapacityLimitException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ProductCountIsZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
