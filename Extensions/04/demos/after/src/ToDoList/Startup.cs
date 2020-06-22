using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using ToDoList.Model;
using ToDoList.Services;

namespace ToDoList
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            
            services.AddDiagnostics();

            var dbProvider = Configuration.GetValue<DbProvider>("Database:Provider");
            _ = dbProvider switch
            {
                DbProvider.Sqlite => services.AddDbContext<ToDoContext>(options =>
                     options.UseSqlite(Configuration.GetConnectionString("ToDoDb"))),

                DbProvider.Postgres => services.AddDbContext<ToDoContext>(options =>
                     options.UseNpgsql(Configuration.GetConnectionString("ToDoDb"),
                     postgresOptions => postgresOptions.EnableRetryOnFailure())),

                _ => throw new NotSupportedException("Supported providers: Sqlite and Posgtres")
            };            

            services.AddScoped<ToDoService>();           
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStandardPipeline(env.IsDevelopment());

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
