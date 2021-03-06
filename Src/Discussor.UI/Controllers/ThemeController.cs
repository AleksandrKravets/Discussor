﻿using Discussor.Core.Application.Themes.Commands.CreateTheme;
using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Contracts;
using Discussor.WebUI.Infrastructure.Filters;
using Discussor.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Discussor.WebUI.Controllers
{
    public class ThemeController : BaseController
    {
        private readonly IImageConverter _imageConverter;
        private readonly UserManager<ApplicationUser> _userManager;

        public ThemeController(IImageConverter imageConverter, UserManager<ApplicationUser> userManager)
        {
            _imageConverter = imageConverter;
            _userManager = userManager;
        }


        [HttpPost]
        [Authorize]
        [EmailConfirmation]
        public async Task<IActionResult> Create(CreateThemeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);

                await Mediator.Send(new CreateThemeCommand
                {
                    Title = model.Title,
                    Image = _imageConverter.ConvertToByteArray(model.Image),
                    CreatorId = currentUser.Id
                });

                return Ok();
            }

            return BadRequest();
        }
    }
}
