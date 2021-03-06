using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjetoModeloDDD.Infra.Data.Context;
using AutoMapper;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Infra.Data.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Services;
using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Application.AppService;

namespace ProjetoModeloDDD.API
{
    public class Startup
    {
        private IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // INJEC��O DE DEPENDENCIA DE REPOSITORIO
            services.AddDbContext<ProjetoModeloContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClientAppService, ClientAppService>();
            services.AddScoped<IClientService, ClientService>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductAppService, ProductAppService>();
            services.AddScoped<IProductService, ProductService>();
            // FIM INJEC��O DE DEPENDENCIA DE REPOSITORIO

            services.AddAutoMapper(typeof(Startup));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
