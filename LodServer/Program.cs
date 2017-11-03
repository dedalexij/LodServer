using System;
using System.IO;
using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace LodServer
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int port=5000;
      //port = int.Parse(Console.ReadLine());
      Host(args, port).Run();
    }

    public static IWebHost Host(string[] args, int port) =>
      WebHost.CreateDefaultBuilder(args)
      .UseKestrel(options =>
        {
          options.Listen(IPAddress.Any, port);
        })
      .UseContentRoot(Directory.GetCurrentDirectory())
      .UseIISIntegration()
      .UseStartup<Startup>()
      .Build();
  }
}
