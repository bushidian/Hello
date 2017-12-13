using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace hello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json", optional: false, reloadOnChange: true)
                .AddCommandLine(args)
                .Build();

            BuildWebHost(args, config).Run();
        }

        public static IWebHost BuildWebHost(string[] args, IConfiguration config) =>
           WebHost.CreateDefaultBuilder(args)
               .UseConfiguration(config)
               .UseKestrel()
               .UseContentRoot(Directory.GetCurrentDirectory())
               .UseIISIntegration()
               .UseStartup<Startup>()
               .Build();
    }
}
