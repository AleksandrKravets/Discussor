using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Application.Themes.Queries.GetThemesList;
using Discussor.WebUI.Infrastructure.Pagination;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Discussor.WebUI.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var themes = await Mediator.Send(new GetThemesListQuery());
            return Ok(themes);
        }
    }
}
