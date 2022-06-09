using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using WA.Contracts;
using WA.IoC;

namespace WA.ConsoleOutput
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();           

            IServiceCollection services = new ServiceCollection();

            services.RegisterServices();
            services.RegisterDBContext(config);

            var serviceProvider = services.BuildServiceProvider();

            var rt = new Runtime(serviceProvider.GetService<IEmployeeService>());

            await rt.Run();
        }
    }
}
