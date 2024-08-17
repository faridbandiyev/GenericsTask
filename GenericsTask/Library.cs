using GenericsTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    public class Library
    {
        public int BookLimit { get; private set; }
        private List<Book> Books { get; set; }

        public Library(int bookLimit)
        {
            if (bookLimit <= 0)
            {
                throw new ArgumentException("Book limit must be greater than zero.");
            }

            BookLimit = bookLimit;
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (Books.Count >= BookLimit)
            {
                throw new CapacityLimitException("The library has reached its book limit.");
            }

            Books.Add(book);
        }

        public Book GetBookById(int id)
        {
            Book book = Books.Find(b => b.Id == id);

            if (book == null)
            {
                throw new NotFoundException($"No book found with ID: {id}");
            }

            return book;
        }

        public List<Book> GetAllBooks()
        {
            return new List<Book>(Books);
        }

        public void RemoveById(int id)
        {
            Book book = GetBookById(id);

            if (book == null)
            {
                throw new NotFoundException($"No book found with ID: {id}");
            }

            Books.Remove(book);
        }
    }
}
