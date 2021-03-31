using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PT.TrainningBesa04.Models;
using PT.TrainningBesa04.Repositories;
using PT.TrainningBesa04.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PT.TrainningBesa04
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
                        
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            string conn = Configuration.GetConnectionString("TrainingBesaConn");
            services.AddDbContext<RDL00001TrainingBesa04Context>(
                options => options.UseSqlServer(conn));

            services.AddScoped<IContactsRepository, ContactsRepository>();
            services.AddScoped<IAccountsRepository, AccountsRepository>();
            services.AddScoped<Services.IContactsService, ContactsService>();
            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
