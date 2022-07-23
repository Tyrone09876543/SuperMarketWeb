using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SuperMercadoWeb.Data;

[assembly: HostingStartup(typeof(SuperMercadoWeb.Areas.Identity.IdentityHostingStartup))]
namespace SuperMercadoWeb.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SuperMercadoContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SuperMercadoContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<SuperMercadoContext>();
            });
        }
    }
}