using Discussor.Core.Application.Common.Contracts.Repositories;
using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Contracts;
using Discussor.Infrastructure.Repositories;
using Discussor.Infrastructure.Services;
using DiscussorInfrastructure.Services;
using Infrastructure.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Discussor.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IThemeRepository, ThemeRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IReplyRepository, ReplyRepository>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DiscussorDatabase")));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

            services.AddIdentity<ApplicationUser, IdentityRole>(options => {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            }).AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options => {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(30);

                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Home/Index";

            });

            services.AddTransient<IEmailSender, EmailSender>(i =>
                new EmailSender(
                    configuration["EmailSender:Host"],
                    configuration.GetValue<int>("EmailSender:Port"),
                    configuration.GetValue<bool>("EmailSender:EnableSSL"),
                    configuration["EmailSender:UserName"],
                    configuration["EmailSender:Password"]
                )
            );

            services.AddScoped<IImageConverter, ImageConverter>();

            return services;
        }
    }
}
