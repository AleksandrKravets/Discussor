using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Contracts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Discussor.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Seed().Result.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }

    public static class DatabaseSeedInitializer
    {
        public async static Task<IHost> Seed(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetService<IApplicationDbContext>();

                try
                {
                    if (context.ApplicationUsers.Where(user => user.UserName == "TestAccount").FirstOrDefault() == null)
                    {
                        var user = new ApplicationUser
                        {
                            UserName = "TestAccount",
                            Email = "testacc@mail.com",
                            NormalizedEmail = "testacc@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            SecurityStamp = Guid.NewGuid().ToString(),
                            NormalizedUserName = "TestAccount",
                        };

                        context.ApplicationUsers.Add(user);
                        var hasher = new PasswordHasher<ApplicationUser>();
                        var hashedPassword = hasher.HashPassword(user, "TestAccount");
                        user.PasswordHash = hashedPassword;

                        await context.SaveChangesAsync();
                    }
                } catch (Exception)
                {
                }
            }
            return host;
        }
    }
}
