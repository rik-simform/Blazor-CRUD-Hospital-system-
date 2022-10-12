using Blazored.SessionStorage;
using HospitalSystem.Client.Authentication;
using HospitalSystem.Client.Extensions;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HospitalSystem.Shared;
using HospitalSystem.Client;

namespace HospitalSystem.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddBlazoredSessionStorage();

            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationstateProvider>();
            builder.Services.AddAuthorizationCore();
            await builder.Build().RunAsync();
            
        }
    }
}
