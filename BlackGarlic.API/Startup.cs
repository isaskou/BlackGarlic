using BlackGarlic.DAL.Interfaces;
using BlackGarlic.DAL.Interfaces.ICaddieRepos;
using BlackGarlic.DAL.Interfaces.IPeopleRepos;
using BlackGarlic.DAL.Interfaces.IProductsRepos;
using BlackGarlic.DAL.Repositories.CaddiesRepo;
using BlackGarlic.DAL.Repositories.People;
using BlackGarlic.DAL.Repositories.ProductsRepo;
using BlackGarlic.DTO.Interfaces.ICaddieServices;
using BlackGarlic.DTO.Interfaces.IPeopleService;
using BlackGarlic.DTO.Interfaces.IProductsServices;
using BlackGarlic.DTO.Services.CaddieService;
using BlackGarlic.DTO.Services.PeopleService;
using BlackGarlic.DTO.Services.ProductsServices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenTools;

namespace BlackGarlic.API
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
            services.AddSingleton(typeof(TokenManager));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateAudience = false,
                        ValidateIssuer = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["Jwt:Issuer"],
                        ValidAudience = Configuration["Jwt:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                    };
                });
            services.AddControllers();
            

            services.AddCors();

            #region Product
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<ICategoryProductRepository, CategoryProductRepository>();
            services.AddScoped<ICategoryService, CategoryService>();

            #endregion
            #region People

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();

            services.AddScoped<IAdressRepository, AdressRepository>();
            services.AddScoped<IAdressService, AdressService>();

            services.AddScoped<ICustomerAdressRepository, CustomerAdressRepository>();
            services.AddScoped<ICustomerAdressService, CustomerAdressService>();

            services.AddScoped<IRoleRepository, RoleRepository>();
            #endregion

            #region Caddie
            services.AddScoped<ICommandRepository, CommandRepository>();
            services.AddScoped<ICommandService, CommandService>();
            #endregion

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BlackGarlic.API", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BlackGarlic.API v1"));
            }

            

            app.UseHttpsRedirection();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
