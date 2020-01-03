using Application.Themes.Commands.CreateTheme;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ThemeController : BaseController
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateThemeCommand());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateThemeCommand command)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(command);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "The entered data is incorrect");
            return View(command);
        }
    }
}
