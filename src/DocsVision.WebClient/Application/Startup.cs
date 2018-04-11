using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using DocsVision.WebClient.DataModel;

namespace DocsVision.WebClient
{
	public class Startup : IStartup
	{
		private readonly IConfiguration _configuration;
		private readonly IHostingEnvironment _environment;

		private IServiceProvider _provider;

		public Startup(IConfiguration configuration, IHostingEnvironment environment)
		{
			_configuration = configuration;
			_environment = environment;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public IServiceProvider ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<DocsVisionContext>(ConfigureDatabase);

			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(ConfigureCookieAuthentication);

			services.AddMvc();

			_provider = services.BuildServiceProvider();
			return _provider;
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app)
		{
			if (_environment.IsDevelopment())
			{
				app.UseDatabaseErrorPage();
				app.UseDeveloperExceptionPage();
				app.UseBrowserLink();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}
			
			app.UseStaticFiles();
			app.UseAuthentication();
			app.UseMvc(ConfigureRoutes);
		}

		private void ConfigureDatabase(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = _configuration.GetConnectionString("DefaultConnection");

			optionsBuilder.UseSqlServer(connectionString, ConfigureSqlServer);
		}

		private void ConfigureSqlServer(SqlServerDbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.CommandTimeout(300);
			optionsBuilder.UseRelationalNulls(true);
		}

		private void ConfigureCookieAuthentication(CookieAuthenticationOptions options)
		{
			options.ClaimsIssuer = "DocsVision";
			options.Cookie.HttpOnly = true;
			options.ExpireTimeSpan = TimeSpan.FromDays(14.0);
			options.LoginPath = new PathString("/Account/Login");
			options.LogoutPath = new PathString("/Account/Logout");
			options.SlidingExpiration = true;
			
#if DEBUG
			options.Validate();
#endif
		}

		private void ConfigureRoutes(IRouteBuilder routeBuilder)
		{
			routeBuilder.MapRoute(
				name: "default",
				template: "{controller=Home}/{action=Index}/{id?}");
		}
	}
}
