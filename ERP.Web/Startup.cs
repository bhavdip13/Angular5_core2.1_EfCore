using ERP.Data.Models;
using ERP.IRepository;
using ERP.IRepository.Interfaces;
using ERP.Service;
using ERP.Service.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ERP.Web
{
	public class Startup
	{
		public IConfiguration _configuration { get; }

		public Startup(IConfiguration configuration)
		{
			_configuration = configuration;

		}
		
		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
					.AddJwtBearer(options =>
					{
						options.TokenValidationParameters = new TokenValidationParameters
						{
							ValidateIssuer = true,
							ValidateAudience = true,
							ValidateLifetime = true,
							ValidateIssuerSigningKey = true,
							ValidIssuer = _configuration["Issuer"],
							ValidAudience = _configuration["Audience"],
							IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecurityKey"]))
						};
					});

			//services.AddDbContext<ERPContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
			services.AddDbContext<ERPContext>();

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

			// In production, the Angular files will be served from this directory
			services.AddSpaStaticFiles(configuration =>
			{
				configuration.RootPath = "ClientApp/dist";
			});

			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			
			services.AddTransient<ICategoriesService, CategoriesService>();
			services.AddTransient<IUserService, UserService>();
	
			
	


		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseSpaStaticFiles();
			app.UseAuthentication();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
									name: "default",
									template: "{controller}/{action=Index}/{id?}");
			});

			app.UseSpa(spa =>
			{
							// To learn more about options for serving an Angular SPA from ASP.NET Core,
							// see https://go.microsoft.com/fwlink/?linkid=864501

							spa.Options.SourcePath = "ClientApp";

				if (env.IsDevelopment())
				{
								//Modify your ASP.NET Core app to use the external Angular CLI instance instead of launching one of its 
								//own. In your Startup class, replace the spa.UseAngularCliServer invocation with the following:
								//spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
								spa.UseAngularCliServer(npmScript: "start");
				}
			});
		}
	}
}
