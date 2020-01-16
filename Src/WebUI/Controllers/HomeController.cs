using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Application.Themes.Queries.GetThemesList;
using Discussor.WebUI.Infrastructure.Pagination;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Discussor.WebUI.Controllers
{
    public class HomeController : BaseController
    {
        public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 7)
        {
            var themes = await Mediator.Send(new GetThemesListQuery
            {
                PageNumber = pageNumber,
                PageSize = pageSize 
            });

            ViewData["PagingInfo"] = new PagingInfo
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = themes.NumberOfAllThemes
            };

            return View(themes);
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
