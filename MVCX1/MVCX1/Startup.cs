using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVCX1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace MVCX1
{
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
            //services.AddRazorPages();
            
            //配置数据库连接
            services.AddDbContextPool<PlayDB>(options => 
            { 
                var dataAppSetting = Configuration.GetConnectionString("UserLinkX");
                if (dataAppSetting == null)
                {
                    throw new Exception("未配置数据库连接");
                }
                options.UseSqlServer(Configuration.GetConnectionString("UserLinkX"));
            });

            services.AddMvc(options => options.EnableEndpointRouting = false);

            //依赖注入，指定实现该接口的实现类。问题是多个实现我都要用怎么办呢
            //services.AddSingleton<GetScore,Cards>();
            //使用context流实现dbcontext是，依赖注入必须要AddScoped
            services.AddScoped<GetScore,Cards>();

            //json数据格式为中文时应添加
            services.AddControllers().AddJsonOptions(option => {
                option.JsonSerializerOptions.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(UnicodeRanges.All);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseRouting();


            //app.UseMvcWithDefaultRoute();

            //传统路由
            app.UseMvc(routes => {
                routes.MapRoute("default","{controller=home}/{action=index}/{name?}") ;
            });

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    context.Response.ContentType = "text/plain; charset=utf-8";
                //    await context.Response.WriteAsync("终结点");
                //});
                
                //endpoints.MapControllerRoute(
                //name: "default",
                //pattern: "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
