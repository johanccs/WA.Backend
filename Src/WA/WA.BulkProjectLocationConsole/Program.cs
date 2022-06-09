using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace WA.BulkProjectLocationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();

            var connString = config.GetConnectionString("sqlConnection");

        }
    }
}
