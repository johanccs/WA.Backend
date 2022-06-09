using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using WA.Data.Entities;
using WA.IoC;
using WA.LocationConsole.Helpers;
using WA.ProjectLocationConsole.Helpers;

namespace WA.LocationConsole
{
    class Program
    {
        #region Fields

        private static string _connString = string.Empty;

        #endregion

        static async Task Main(string[] args)
        {
            Output.GetStartConfirmation();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);
            var config = builder.Build();
            _connString = config.GetConnectionString("sqlConnection");

            IServiceCollection services = new ServiceCollection();

            services.RegisterServices();

            services.BuildServiceProvider();

            var sw = new Stopwatch();
            sw.Start();

            var result = await GetProjectLocationsAsync();

            await BulkInsert.WriteToServerAsync(result, _connString);

            Output.WriteFooter(sw, result);
        }

        private async static Task<RawProjectLocation> GetProjectLocationsAsync()
        {
            var serializer = new DeSerializer();

            var result = await serializer.DeSerialize();

            return result;
        }
    }
}
