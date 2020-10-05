using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tommy_Skrak_LexDo.Areas.Identity.Data;
using Tommy_Skrak_LexDo.Data;

[assembly: HostingStartup(typeof(Tommy_Skrak_LexDo.Areas.Identity.IdentityHostingStartup))]
namespace Tommy_Skrak_LexDo.Areas.Identity
{
	public class IdentityHostingStartup : IHostingStartup
	{
		public void Configure(IWebHostBuilder builder)
		{
			builder.ConfigureServices((context, services) =>
			{
				services.AddDbContext<AuthDBContext>(options =>
					options.UseSqlServer(
						context.Configuration.GetConnectionString("DefaultConnection")));

				services.AddDefaultIdentity<ApplicationUser>(options =>
				{
					options.SignIn.RequireConfirmedAccount = false;
					options.Password.RequireLowercase = false;
					options.Password.RequireUppercase = false;

				})
					.AddEntityFrameworkStores<AuthDBContext>();
			});
		}
	}
}