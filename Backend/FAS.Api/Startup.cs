using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using FAS.Repository;
using FAS.Repository.Context;
using FAS.Repository.Implementation;
using FAS.Service;
using FAS.Service.Implementacion;
using Swashbuckle.AspNetCore.Swagger;

namespace FAS.Api
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
            services.AddDbContext<ApplicationDbContext> (options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IBreveteRepository, BreveteRepository> ();
            services.AddTransient<IBreveteService, BreveteService> ();
 
            services.AddTransient<ICatBreveteRepository, CatBreveteRepository> ();
            services.AddTransient<ICatBreveteService, CatBreveteServivce> ();
 
            services.AddTransient<IConductorRepository, ConductorRepository> ();
            services.AddTransient<IConductorService, ConductorServivce> ();
 
            services.AddTransient<IModeloRepository, ModeloRepository> ();
            services.AddTransient<IModeloService, ModeloServivce> ();
 
            services.AddTransient<ITrabajadorRepository, TrabajadorRepository> ();
            services.AddTransient<ITrabajadorService, TrabajadorServivce> ();
 
            services.AddTransient<IUsuarioRepository, UsuarioRepository> ();
            services.AddTransient<IUsuarioService, UsuarioServivce> ();
 
            services.AddTransient<IVehiculoRepository, VehiculoRepository> ();
            services.AddTransient<IVehiculoService, VehiculoServivce> ();
 
            services.AddTransient<IViajeRepository, ViajeRepository> ();
            services.AddTransient<IViajeService, ViajeServivce> ();
 
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen (swagger => {
                var contact = new Contact () { Name = SwaggerConfiguration.ContactName, Url = SwaggerConfiguration.ContactUrl };
                swagger.SwaggerDoc (SwaggerConfiguration.DocNameV1,
                    new Info {
                        Title = SwaggerConfiguration.DocInfoTitle,
                            Version = SwaggerConfiguration.DocInfoVersion,
                            Description = SwaggerConfiguration.DocInfoDescription,
                            Contact = contact
                    }
                );
                });

            services.AddCors (options => {
                options.AddPolicy ("Todos",
                    builder => builder.WithOrigins ("*").WithHeaders ("*").WithMethods ("*"));
            });
        }


        //https://localhost:5001/swagger/index.html
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger ();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI (c => {
                c.SwaggerEndpoint (SwaggerConfiguration.EndpointUrl, SwaggerConfiguration.EndpointDescription);
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }
            app.UseCors ("Todos");
            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
