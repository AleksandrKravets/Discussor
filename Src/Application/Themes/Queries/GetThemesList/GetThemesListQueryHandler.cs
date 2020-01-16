using Discussor.Core.Application.Common.Contracts.Services;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Themes.Queries.GetThemesList
{
    public class GetThemesListQueryHandler : IRequestHandler<GetThemesListQuery, ThemesListViewModel>
    {
        private readonly IThemeService _themeService;

        public GetThemesListQueryHandler(IThemeService themeService)
        {
            _themeService = themeService;
        }

        public async Task<ThemesListViewModel> Handle(GetThemesListQuery request, CancellationToken cancellationToken)
        {
            var themes = _themeService.GetThemesByPageNumber(request.PageNumber, request.PageSize)
                .Select(theme => new ThemeDto
                {
                    Id = theme.Id,
                    Title = theme.Title,
                    DateOfCreation = theme.DateOfCreation,
                    Image = theme.Image,
                    PostsNumber = theme.Posts.Count()
                }).ToList();

            var themesList = new ThemesListViewModel
            {
                Themes = themes,
                NumberOfAllThemes = _themeService.GetThemesNumber()
            };

            return themesList;
        }
    }
}
