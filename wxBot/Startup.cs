using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using wxBotLibrary;
using wxBotModel;
using wxBotModel.DbModel_Sqlite;

namespace wxBot
{
    /// <summary>
    /// 微信机器人
    /// author AARON wu
    /// addtime ： 2019 12
    /// rmk: 仅供学习使用
    /// </summary>
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddBotConfigs(Configuration); 
         
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            using (var database = new ModelBase())    //新增
            {
                database.Database.EnsureCreated(); //如果没有创建数据库会自动创建，最为关键的一句代码
            }
            services.AddDbContext<ModelBase>(options => options.UseSqlite(_STATIC_DBConfig._STATIC_SQLITE_CONN));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //#region 获取路径
            //string webRootPath = env.WebRootPath;           //\wwwroot
            //string contentRootPath = env.ContentRootPath;   //\根目录
            //_STATIC_DBConfig._STATIC_SQLITE_CONN = $"{webRootPath}\\webBot.db";
            //#endregion
           
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "index_page",
                    template: "{action}/{id?}",
                    defaults: new { controller = "Home", action = "{action}" }
                    );
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
