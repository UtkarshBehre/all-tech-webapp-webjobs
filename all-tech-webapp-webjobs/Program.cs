using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace all_tech_webapp_webjobs
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.UseEnvironment(EnvironmentName.Production);

            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
                b.AddTimers();
            });

            builder.ConfigureLogging((context, b) =>
            {
                b.AddConsole();
                b.AddApplicationInsightsWebJobs();
            });

            var host = builder.Build();
            using (host)
            {
                await host.RunAsync();
            }
        }
    }
}
