using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Application.Common.Exceptions;
using Discussor.Core.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Themes.Queries.GetTheme
{
    public class GetThemeQueryHandler : IRequestHandler<GetThemeQuery, ThemeViewModel>
    {
        private readonly IThemeService _themeService;

        public GetThemeQueryHandler(IThemeService themeService)
        {
            _themeService = themeService;
        }

        public async Task<ThemeViewModel> Handle(GetThemeQuery request, CancellationToken cancellationToken)
        {
            var theme = await _themeService.GetThemeByIdAsync(request.ThemeId);

            if (theme == null)
                throw new NotFoundException(nameof(Theme), request.ThemeId);

            var result = new ThemeViewModel
            {
                Id = theme.Id,
                Title = theme.Title,
                DateOfCreation = theme.DateOfCreation,
                Image = theme.Image
            };

            return result;
        }
    }
}
