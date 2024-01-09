using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using WireCalc.Client.Repository;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddRadzenComponents();
builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<WireRepository>();

var host = builder.Build();
await host.RunAsync();