using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Themes.Commands.CreateTheme
{
    public class CreateThemeCommandHandler : IRequestHandler<CreateThemeCommand, int>
    {
        private readonly IThemeService _themeService;

        public CreateThemeCommandHandler(IThemeService themeService)
        {
            _themeService = themeService;
        }

        public async Task<int> Handle(CreateThemeCommand request, CancellationToken cancellationToken)
        {
            var theme = new Theme
            {
                Title = request.Title,
                Image = request.Image,
                DateOfCreation = DateTime.Now
            };

            return await _themeService.CreateAsync(theme);
        }
    }
}
