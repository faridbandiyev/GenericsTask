using GenericsTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    public class Book : Product
    {
        public string AuthorName { get; private set; }
        public int PageCount { get; private set; }

        public Book(string name, double price, int count, string authorName, int pageCount)
            : base(name, price, count)
        {
            if (string.IsNullOrEmpty(authorName) || pageCount <= 0)
            {
                throw new ArgumentException("Invalid arguments for book creation.");
            }

            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override void Sell()
        {
            if (Count == 0)
            {
                throw new ProductCountIsZeroException("The book count is zero, cannot sell.");
            }

            Count--;
            TotalInCome += Price;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Book ID: {Id}\nName: {Name}\nPrice: {Price}\nCount: {Count}\nAuthor: {AuthorName}\nPage Count: {PageCount}\nTotal Income: {TotalInCome}");
        }
    }

}
