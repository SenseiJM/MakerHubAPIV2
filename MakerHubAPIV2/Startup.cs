using MakerhubAPIV2.BLL.Services;
using MakerHubAPIV2.DAL;
using MakerHubAPIV2.DAL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace MakerHubAPIV2 {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            services.AddControllers().AddJsonOptions(opts => {
                var enumConverter = new JsonStringEnumConverter();
                opts.JsonSerializerOptions.Converters.Add(enumConverter);
            });
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MakerHubAPIV2", Version = "v1" });
            });

            services.AddCors(options => options.AddPolicy("default", builder => {
                    builder.WithOrigins("http://localhost:4200", "http://localhost:8100");
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();
            }));

            services.AddDbContext<CTTDBContext>();

            services.AddScoped<SouperService>();
            services.AddScoped<SouperRepository>();

            services.AddScoped<JoueurRepository>();
            services.AddScoped<JoueurService>();

            services.AddScoped<JoueurSouperRepository>();
            services.AddScoped<JoueurSouperService>();

            services.AddScoped<StageRepository>();
            services.AddScoped<StageService>();

            services.AddScoped<HttpClient>(b => new HttpClient { BaseAddress = new Uri("http://localhost:3004") });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MakerHubAPIV2 v1"));
            }

            app.UseCors("default");

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
