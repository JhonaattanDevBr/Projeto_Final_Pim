using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using System;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDistributedMemoryCache(); // Adicione um mecanismo de cache para as sessões
        services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromMinutes(30); // Defina o tempo limite da sessão conforme necessário
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseSession(); // Adicione isso antes do app.UseRouting() e outros middlewares
        app.UseEndpoints(endpoints =>
        {
          
        });
    }
}

