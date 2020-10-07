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
            var chapters = Enumerable.Range(1, 10).Select(x => new Chapter
            {
                ChapterId = Guid.NewGuid().ToString(),
                Title = $"chapter {x}"
            }).ToArray();
            var newBook = new Book(Guid.NewGuid().ToString(), "a new book", "Wrox Press");
            newBook.Chapters = chapters;
            
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
