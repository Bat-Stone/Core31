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
            
            //�������ݿ�����
            services.AddDbContextPool<PlayDB>(options => 
            { 
                var dataAppSetting = Configuration.GetConnectionString("UserLinkX");
                if (dataAppSetting == null)
                {
                    throw new Exception("δ�������ݿ�����");
                }
                options.UseSqlServer(Configuration.GetConnectionString("UserLinkX"));
            });

            services.AddMvc(options => options.EnableEndpointRouting = false);

            //����ע�룬ָ��ʵ�ָýӿڵ�ʵ���ࡣ�����Ƕ��ʵ���Ҷ�Ҫ����ô����
            //services.AddSingleton<GetScore,Cards>();
            //ʹ��context��ʵ��dbcontext�ǣ�����ע�����ҪAddScoped
            services.AddScoped<GetScore,Cards>();

            //json���ݸ�ʽΪ����ʱӦ���
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

            //��ͳ·��
            app.UseMvc(routes => {
                routes.MapRoute("default","{controller=home}/{action=index}/{name?}") ;
            });

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    context.Response.ContentType = "text/plain; charset=utf-8";
                //    await context.Response.WriteAsync("�ս��");
                //});
                
                //endpoints.MapControllerRoute(
                //name: "default",
                //pattern: "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
