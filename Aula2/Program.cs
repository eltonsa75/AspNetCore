using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Aula2 {
    class Program {
        static void Main(string[] args) 
        {

          var host = WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
            host.Run();            
        }
    }

    internal class Startup {

        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
         {
            _configuration = configuration;
        }
       public void Configure(IApplicationBuilder app) 
{
    app.Use(async (context, next) => {
        // Antes de manipular a requisição...

        await next(); // Chama o próximo middleware na cadeia

        // Depois de receber uma resposta do próximo middleware...
        await context.Response.WriteAsync("Bem vindo 1 ");
    });

    app.Use(async (context, next) => {
        // Antes de manipular a requisição...

        await next(); // Chama o próximo middleware na cadeia

        // Depois de receber uma resposta do próximo middleware...
        await context.Response.WriteAsync("Bem vindo 2");
    });
}

        }
    }
