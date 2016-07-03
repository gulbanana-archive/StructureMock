using Lib.Common;
using Lib.Plugin;
using Lib.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
#if NET_CORE
using System.Reflection;
#endif

namespace WebApp
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }

        public void ConfigureServices(IServiceCollection services)
        {
#if NET_CORE
            services.AddMvc().AddApplicationPart(typeof(PrintController).GetTypeInfo().Assembly);
#else
            services.AddMvc().AddApplicationPart(typeof(PrintController).Assembly);
#endif
            services.AddSingleton<IFormatter>(new QuoteFormatter());
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddDebug();
            app.UseMvc();
        }
    }
}
