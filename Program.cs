
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;


namespace TravelApi
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Builder(args).Build().Run();
    }

    public static IWebHostBuilder Builder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseUrls("http://localhost:5003");
  }
}
