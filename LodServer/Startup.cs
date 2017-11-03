using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LodServer
{
  public class Startup
  {
    public Startup(IHostingEnvironment hosting)
    {
      var builder = new ConfigurationBuilder()
      .SetBasePath(hosting.ContentRootPath)
      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
      .AddJsonFile($"peopleList.json", optional: false, reloadOnChange: true)
      .AddEnvironmentVariables();

      Configuration = builder.Build();
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.Configure<People>(Configuration.GetSection("People"));
      services.AddMvc();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory log)
    {
      log.AddConsole(Configuration.GetSection("Logging"));
      log.AddDebug();
      app.UseMvc();
    }
  }
}

