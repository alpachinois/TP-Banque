using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ApiGatewayAgenceBancaire
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("jsconfig.json"))
            {
                string json = r.ReadToEnd();
                ServerUrls urls = JsonConvert.DeserializeObject<ServerUrls>(json);
            }
            CreateWebHostBuilder(args).UseUrls("http://localhost:9004").Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
