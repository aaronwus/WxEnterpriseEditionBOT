using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using wxBotModel;

namespace wxBot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
              .ConfigureAppConfiguration((context, builder) =>
              {
                  builder.SetBasePath(context.HostingEnvironment.ContentRootPath)
                  .AddJsonFile("wxBotCONFIGS/wxbotConfig.json");

                  #region 获取路径
                  string webRootPath = context.HostingEnvironment.WebRootPath;           //\wwwroot
                  string contentRootPath = context.HostingEnvironment.ContentRootPath;   //\根目录
                  _STATIC_DBConfig._STATIC_SQLITE_CONN = $"{webRootPath}\\webBot.db";
                  #endregion


              })
                .UseStartup<Startup>();
    }
}
