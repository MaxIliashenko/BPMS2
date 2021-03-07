using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BPMS.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //await Task.Delay(3000); // This allows time for the debugger to attach before any client code runs

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            
            builder.Services.AddDevExpressBlazor();
            builder.Services.AddHttpClient("BPMS2.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BPMS2.ServerAPI"));

            await builder.Build().RunAsync();
        }
    }
}
