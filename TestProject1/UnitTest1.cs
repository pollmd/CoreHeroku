using CoreHeroku;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestWithChromeDriver()
        {
            string[] t = { };
            //var o = CoreHeroku.Program.CreateHostBuilder(t);

            //    CoreHeroku.Program.CreateHostBuilder(t).Build().StartAsync();

            Host.CreateDefaultBuilder(t)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<Startup>();
    })
    .Build()
    .RunAsync();

            //    var builder = WebApplication.CreateBuilder(args);
            //  var startup = new Startup(builder.Configuration);
            //startup.ConfigureServices(builder.Services);
            //var app = builder.Build();
            //startup.Configure(app);
            //app.Run();

            //var builder = (IHostBuilder)(new object());

            //var startup = new Startup(builder);
            //startup.ConfigureServices(obj.Services);
            //var app = builder.Build();
            //startup.Configure(app);
            //app.Run();

            var driver = new ChromeDriver("C:/WebDriver");
            driver.Navigate().GoToUrl("https://localhost:5001/");
        }
    }
}
