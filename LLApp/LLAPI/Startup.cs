using LLDB;
using LLDB.Repos;
using LLLib;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLAPI
{
    public class Startup
    {
        //CORS Policy
        readonly string AllowedOrigins = "allowedOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Add CORS with policy
            services.AddCors(options => {
                options.AddPolicy(name: AllowedOrigins,
                    builder => {
                        builder.WithOrigins("*") //http://127.0.0.1:5500
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });

            services.AddControllers();

            //TODO change this to the correct context name
            services.AddDbContext<LLContext>(options => options.UseNpgsql(Configuration.GetConnectionString("")));

            services.AddScoped<IChildService, ChildService>();
            services.AddScoped<IChildRepo, DBRepo>();

            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IGameRepo, DBRepo>();

            services.AddScoped<IParentService, ParentService>();
            services.AddScoped<IParentRepo, DBRepo>();

            services.AddScoped<IPracticeService, PracticeService>();
            services.AddScoped<IPracticeRepo, DBRepo>();

            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ITeamRepo, DBRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //Allowing use of CORS in app
            app.UseCors(AllowedOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
