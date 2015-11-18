using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Configuration;
using Microsoft.AspNet.StaticFiles;
using Microsoft.AspNet.FileProviders;
using System.IO;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Server.Kestrel;

namespace Angular2Aspnet5
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.UseDefaultFiles();
            //app.UseStaticFiles(new StaticFileOptions() { FileProvider = new PhysicalFileProvider(env.WebRootPath) });

            app.UseDefaultFiles();
            app.UseMiddleware<StaticFileMiddleware>(new StaticFileOptions());
            app.UseMvcWithDefaultRoute();

            //app.UseStaticFiles();
            //app.UseWelcomePage();
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
