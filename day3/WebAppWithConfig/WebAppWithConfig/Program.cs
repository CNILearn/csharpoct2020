using Azure.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWithConfig
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(config =>
                {
                    //var c = config.Build();
                    //var connection = c["AzureAppConfigConnection"];
                    //config.AddAzureAppConfiguration(connection);

                    config.AddAzureAppConfiguration(options =>
                    {
                        var settings = config.Build();
                        config.AddAzureAppConfiguration(options =>
                            options.Connect(new Uri("https://etcappconfig.azconfig.io"), new ManagedIdentityCredential()));
                    });
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
