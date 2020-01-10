using Discussor.Core.Application.Common.Behaviours;
using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Application.Common.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Discussor.Core.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IThemeService, ThemeService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IReplyService, ReplyService>();
            services.AddScoped<IUserService, UserService>();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            return services;
        }
    }
}
