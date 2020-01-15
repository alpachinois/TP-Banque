using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BankAccount.BankAccountService.Database;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BankAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccountDatabase database = new BankAccountDatabase();
            CreateWebHostBuilder(args).UseUrls("http://localhost:9002").Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
