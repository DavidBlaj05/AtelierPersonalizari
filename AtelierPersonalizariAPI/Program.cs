using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AtelierPersonalizariAPI.Data;

namespace AtelierPersonalizariAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
          //  IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
           // var options = new DbContextOptionsBuilder<AtelierPersonalizariContext>().UseSqlServer(config.GetConnectionString("DefaultConnection")).Options;
           // using var db = new AtelierPersonalizariContext(options);
           // db.Database.EnsureDeleted();
          //  db.Database.EnsureCreated();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
