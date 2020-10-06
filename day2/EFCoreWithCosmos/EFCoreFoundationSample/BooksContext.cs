using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFoundationSample
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {

        }

        public DbSet<Book> Books { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultContainer("BooksSample");

            modelBuilder.Entity<Book>().Property(b => b.Publisher).HasMaxLength(20);

            //var books = Enumerable.Range(1, 100).Select(x =>
            //{
            //    return new Book
            //    {
            //        BookId = x,
            //        Title = $"title {x}",
            //        Publisher = "sample pub"
            //    };
            //}).ToArray();
            // modelBuilder.Entity<Book>().HasData(books);
        }
    }
}
