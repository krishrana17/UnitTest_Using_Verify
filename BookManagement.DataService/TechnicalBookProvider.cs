using System;
using System.Collections.Generic;
using System.Linq;
using BookManagement.DataService.Models;

namespace BookManagement.DataService
{
    public class TechnicalBookProvider
    {
        private static readonly List<Book> BookList = new()
        {
            new()
            {
                Id = new Guid("C71AE620-CA18-4897-853B-C988A92375F9"),
                BookName = "The Pragmatic Programmer",
                Author = "Andrew Hunt & David Thomas",
                ISBN = "9780201616224",
                Publisher = "Addison Wesley",
                Price = 95.99m
            },
            new()
            {
                Id = new Guid("F56A628F-5184-4E44-BBC9-4EE137610C46"),
                BookName = "Clean Code",
                Author = "Robert C. Martin",
                ISBN = "9780132350884",
                Publisher = "Prentice Hall; ",
                Price = 84.99m
            }
        };

        /// <summary>
        /// Returns a list of books
        /// </summary>
        /// <returns></returns>
        public IList<Book> GetAllBooks() =>
            BookList;

        /// <summary>
        /// Return a single book by id
        /// </summary>
        /// <param name="bookId">GUID of Book</param>
        /// <returns></returns>
        public Book GetBookById(Guid bookId) =>
            BookList.SingleOrDefault(book => book.Id == bookId);
    }
}
