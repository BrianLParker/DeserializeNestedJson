using System.Net.Http.Json;
using System.Reflection;
using DeserializeNestedJson;
using DeserializeNestedJson.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace DeserializeNestedJson
{
    public class Program
    {
public static async Task Main(string[] args)
{
    var builder = WebAssemblyHostBuilder.CreateDefault(args);
    builder.RootComponents.Add<App>("#app");
    builder.RootComponents.Add<HeadOutlet>("head::after");
    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

    var host = builder.Build();
    var httpClient = host.Services.GetService<HttpClient>();
    var filters = await httpClient!.GetFromJsonAsync<Model>("filterOptions.json");
    builder.Services.AddSingleton(filters!);
    await builder.Build().RunAsync();
}
    }
}