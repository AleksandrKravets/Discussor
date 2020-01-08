using Discussor.Core.Application.Themes.Queries.GetThemesList;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Discussor.WebUI.Controllers
{
    public class HomeController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            var themes = await Mediator.Send(new GetThemesListQuery());
            return View(themes);
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
