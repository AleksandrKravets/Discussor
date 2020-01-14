using Discussor.Core.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Discussor.WebUI.Infrastructure.Filters
{
    public class EmailConfirmationAttribute : Attribute, IAuthorizationFilter
    {
        public async void OnAuthorization(AuthorizationFilterContext context)
        {
            UserManager<ApplicationUser> _userManager =
                context.HttpContext.RequestServices.GetRequiredService<UserManager<ApplicationUser>>();

            var user = await _userManager.GetUserAsync(context.HttpContext.User);

            if (!user.EmailConfirmed)
                context.Result = new RedirectResult("~/Home/Index");
        }
    }
}
