using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFoundationSample
{
    public class BooksContextFactory : IDesignTimeDbContextFactory<BooksContext>
    {
        public BooksContext CreateDbContext(string[] args)
        {
            var connectionString = @"server = (localdb)\mssqllocaldb; database = BooksData; trusted_connection = true";
            var optionsBuilder = new DbContextOptionsBuilder<BooksContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new BooksContext(optionsBuilder.Options);
        }
    }
}
