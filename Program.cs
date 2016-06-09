using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace Avam.ArticleStore.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseWebRoot("wwwroot")
                    .UseStartup<Bootstrapper>()
                    .Build();
                host.Run();
        }
    }
}
