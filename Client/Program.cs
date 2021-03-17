using BPMS.Components.Service;
using BPMS.Shared.UI;
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
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            
            builder.Services.AddDevExpressBlazor();
            builder.Services.AddHttpClient("BPMS2.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BPMS2.ServerAPI"));

            builder.Services.AddScoped<AjaxService>();
            builder.Services.AddScoped<StateNotificationService>();

            await builder.Build().RunAsync();
        }
    }
}
