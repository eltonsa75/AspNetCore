using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Aula2 {
    class Program {
        static void Main(string[] args) {

            var host = new WebHostBuilder()
            .UseKestrel()
            .Configure(app => {
                app.Run(context => context.Response.WriteAsync("Bem vindo ao curso"));
            })
            .Build();
            host.Run();
            
        }
    }
}