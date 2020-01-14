using Discussor.Core.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Discussor.WebUI.Infrastructure.Filters
{
    public class EmailConfirmationAttribute : Attribute, IAsyncAuthorizationFilter
    {
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            UserManager<ApplicationUser> _userManager =
                context.HttpContext.RequestServices.GetRequiredService<UserManager<ApplicationUser>>();

            var user = await _userManager.GetUserAsync(context.HttpContext.User);

            if (!user.EmailConfirmed)
                context.Result = new RedirectToActionResult("EmailConfirmationErrorPage", "Shared", null);
        }
    }
}
