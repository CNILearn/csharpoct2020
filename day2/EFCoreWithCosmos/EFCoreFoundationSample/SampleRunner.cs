using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFoundationSample
{
    public class SampleRunner
    {
        private readonly BooksContext _booksContext;

        public SampleRunner(BooksContext booksContext)
        {
            _booksContext = booksContext;
        }

        public async Task CreateDatabaseAsync()
        {
            bool created = await _booksContext.Database.EnsureCreatedAsync();
            Console.WriteLine($"created: {created}");
        }

        public async Task CreateBooksAsync()
        {
            var newBook = Book.CreateNewBook();
            newBook.Title = "Professional C# 9"; 
            newBook.Publisher = "Wrox Press";

            _booksContext.Books.Add(newBook);
            int numberRecords = await _booksContext.SaveChangesAsync();
            Console.WriteLine($"inserted {numberRecords} records");
        }

        public async Task QueryBooksAsync()
        {
            var asyncBooks = _booksContext.Books.Where(b => b.Publisher == "sample pub").AsAsyncEnumerable();
            await foreach(var book in asyncBooks)
            {
                Console.WriteLine($"{book.Title}");
            }
        }

    }
}
