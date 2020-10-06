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
                .ConfigureAppConfiguration(config =>
                {
                    config.AddUserSecrets("9c55b495-adcb-4e63-ab7a-b20a8ec084cc");
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<BooksContext>(options =>
                    {
                        var section = context.Configuration.GetSection("CosmosConfig");

                        var connectionString = section["CosmosConnectionString"];
                        var databaseName = section["DatabaseName"];
                        
                        options.UseCosmos(connectionString, databaseName);
                    });
                    services.AddTransient<SampleRunner>();
                }).Build();

            var runner = host.Services.GetRequiredService<SampleRunner>();
            // await runner.CreateDatabaseAsync();
            await runner.CreateBooksAsync();
            await runner.QueryBooksAsync();


        }
    }
}
