using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using UserServiceYnov.UserService.Database;

namespace UserServiceYnov
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserDatabaseExemple userDatabaseExemple = new UserDatabaseExemple();
            CreateWebHostBuilder(args).UseUrls("http://localhost:9003").Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
