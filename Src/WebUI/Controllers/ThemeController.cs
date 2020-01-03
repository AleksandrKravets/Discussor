using Application.Themes.Commands.CreateTheme;
using Infrastructure.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ThemeController : BaseController
    {
        private readonly IImageConverter _imageConverter;

        public ThemeController(IImageConverter imageConverter)
        {
            _imageConverter = imageConverter;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateThemeViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateThemeViewModel model)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(new CreateThemeCommand 
                {
                    Title = model.Title,
                    Image = _imageConverter.ConvertToByteArray(model.Image)
                });

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "The entered data is incorrect");
            return View(model);
        }
    }
}
