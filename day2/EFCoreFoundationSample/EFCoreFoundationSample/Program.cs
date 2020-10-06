using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace EFCoreFoundationSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<BooksContext>(options =>
                    {
                        var connectionString = context.Configuration.GetConnectionString("BooksConnection");

                        options.UseSqlServer(connectionString);
                    });
                    services.AddTransient<SampleRunner>();
                }).Build();

            var runner = host.Services.GetRequiredService<SampleRunner>();
            await runner.CreateBooksAsync();
            await runner.QueryBooksAsync();


        }
    }
}
